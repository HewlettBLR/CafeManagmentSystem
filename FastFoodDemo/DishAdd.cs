using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace FastFoodDemo
{
    public partial class DishAdd : Form
    {
        string file;
        public int ID { get; set; }
        public bool Edit { get; set; }

        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
        public DishAdd()
        {
            InitializeComponent();
        }
        public void LoadDropDownCategoryDishes()
        {
            string query = "Select * From Category_Of_Dishes ";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    bunifuDropdown1.DataSource = dataTable;
                bunifuDropdown1.DisplayMember = "Name_Category";
                bunifuDropdown1.ValueMember = "ID_Category";
            }
        }
        public void LoadDropDownCategoryWeight()
        {
            string query = "Select * From Units_Of_Measurement";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    bunifuDropdown2.DataSource = dataTable;
                bunifuDropdown2.DisplayMember = "Abbreviation_Weight";
                bunifuDropdown2.ValueMember = "ID_Weight";
            }
        }

        private void AddD_Click(object sender, EventArgs e)
        {
            if (Edit)
            {

                string query = "UPDATE Dishes SET Name_Dish=@Name_Dish, " +
                    "Recipe_Dish=@Recipe_Dish, Weight_Dish=@Weight_Dish, Photo_Dish=@Photo_Dish, " +
                    "Price_Dish=@Price_Dish, ID_Category_Dish=@ID_Category_Dish, ID_Weight=@ID_Weight WHERE ID_Dish = " + ID;
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(bunifuTextBox2.Text) || String.IsNullOrWhiteSpace(bunifuTextBox3.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Name_Dish", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Recipe_Dish", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Weight_Dish", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Photo_Dish", ImageB.ImageLocation);
                            command.Parameters.AddWithValue("@Price_Dish", bunifuTextBox3.Text);

                            command.Parameters.AddWithValue("@ID_Category_Dish", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Weight", (int)bunifuDropdown2.SelectedValue);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.SR.flowLayoutPanel3.Controls.Find("DishCard", true);
                            foreach (Dish c in cards.OfType<Dish>())
                                if (c.ID == ID)
                                {
                                    c.Nazv.Text = bunifuTextBox1.Text;

                                    c.Opisanie.Text = bunifuTextBox4.Text;
                                    c.Price.Text = bunifuTextBox3.Text;
                                    c.weight.Text = bunifuTextBox2.Text;
                                    c.pictureDish.Image = Image.FromFile(ImageB.ImageLocation);
                                    break;
                                }
                            Close();
                            MessageBox.Show("Запись успешно изменена!", "Изменение записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось изменить запись!", "Ошибка изменения", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    FormMain.SR.RefreshDish();
                    FormMain.SR.RefreshOrder();
                }
            }
            else
            {
                string query = "INSERT INTO Dishes (Name_Dish, Recipe_Dish, Weight_Dish, Price_Dish, " +
                    "Photo_Dish, ID_Category_Dish, ID_Weight ) VALUES " +
                    "(@Name_Dish, @Recipe_Dish, @Weight_Dish, @Price_Dish, @Photo_Dish, @ID_Category_Dish, @ID_Weight )";
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(bunifuTextBox2.Text) || String.IsNullOrWhiteSpace(bunifuTextBox3.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Name_Dish", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Recipe_Dish", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Weight_Dish", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Price_Dish", bunifuTextBox3.Text);
                            command.Parameters.AddWithValue("@Photo_Dish", Convert.ToString(file));

                            command.Parameters.AddWithValue("@ID_Category_Dish", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Weight", (int)bunifuDropdown2.SelectedValue);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.SR.flowLayoutPanel3.Controls.Find("DishCard", true);
                            Dish lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Dish;
                                lastCardIndex = FormMain.SR.flowLayoutPanel3.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Dish newCard = new Dish
                            {
                                Name = "DishCard",
                                Parent = FormMain.SR.flowLayoutPanel3,
                                ID = id
                            };
                            newCard.Opisanie.Text = bunifuTextBox4.Text;
                            newCard.weight.Text = bunifuTextBox2.Text;
                            newCard.Price.Text = bunifuTextBox3.Text;
                            newCard.pictureDish.Image = Image.FromFile(Convert.ToString(ImageB.Tag));
                            FormMain.SR.flowLayoutPanel3.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.SR.RefreshDish();
            }

        }

        private void DishAdd_Load(object sender, EventArgs e)
        {

            LoadDropDownCategoryDishes();
            LoadDropDownCategoryWeight();
        }

        private void ImageB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openFileDialog1.Filter = "ImageFiles(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";
                    file = openFileDialog1.FileName;
                    ImageB.Image = Image.FromFile(file);
                    ImageB.ImageLocation = file;
                    ImageB.InitialImage = Image.FromFile(file);
                    ImageB.Tag = file;

                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DishAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query =
                    "Select Dishes.ID_Dish, Dishes.Name_Dish, Dishes.Recipe_Dish, Dishes.Weight_Dish, Dishes.Price_Dish, " +
                    "Dishes.Photo_Dish, Dishes.ID_Category_Dish, Dishes.ID_Weight, Units_Of_Measurement.ID_Weight," +
                    " Units_Of_Measurement.Abbreviation_Weight " +
                    "from Dishes, Units_Of_Measurement" +
                    " where Units_Of_measurement.ID_Weight=Dishes.ID_Weight and ID_Dish = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bunifuDropdown1.SelectedValue = dataTable.Rows[0][6].ToString();
                    bunifuDropdown2.SelectedValue = dataTable.Rows[0][7].ToString();
                    bunifuTextBox1.Text = dataTable.Rows[0][1].ToString();
                    bunifuTextBox4.Text = dataTable.Rows[0][2].ToString();
                    bunifuTextBox3.Text = dataTable.Rows[0][4].ToString();
                    bunifuTextBox2.Text = dataTable.Rows[0][3].ToString();
                    ImageB.Image = Image.FromFile(dataTable.Rows[0][5].ToString());
                    ImageB.InitialImage = Image.FromFile(dataTable.Rows[0][5].ToString());
                    ImageB.ImageLocation = dataTable.Rows[0][5].ToString();
                }
                dd.Text = "Редактирование блюда";
                EditD.ButtonText = "Редактировать";
                _ = ImageB.Image;

            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);

        }

        private void BunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);
        }
    }
}
