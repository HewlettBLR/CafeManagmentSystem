using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class DishAdd : Form
    {
        private string file;
        public int ID { get; set; }
        public bool Edit { get; set; }
        private string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

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
                    CategoryDishDropdown.DataSource = dataTable;
                CategoryDishDropdown.DisplayMember = "Name_Category";
                CategoryDishDropdown.ValueMember = "ID_Category";
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
                    CategoryWeightDropdown.DataSource = dataTable;
                CategoryWeightDropdown.DisplayMember = "Abbreviation_Weight";
                CategoryWeightDropdown.ValueMember = "ID_Weight";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Dishes SET " +
                               "Name_Dish=@Name_Dish, " +
                               "Recipe_Dish=@Recipe_Dish, " +
                               "Weight_Dish=@Weight_Dish, " +
                               "Photo_Dish=@Photo_Dish, " +
                               "Price_Dish=@Price_Dish, " +
                               "ID_Category_Dish=@ID_Category_Dish, " +
                               "ID_Weight=@ID_Weight " +
                               "WHERE ID_Dish = " + ID;
                if (String.IsNullOrWhiteSpace(NameDishField.Text) || CategoryDishDropdown.Text.Equals("Выбрать") || CategoryWeightDropdown.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(WeightField.Text) || String.IsNullOrWhiteSpace(PriceField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Name_Dish", NameDishField.Text);
                            command.Parameters.AddWithValue("@Recipe_Dish", RecipeField.Text);
                            command.Parameters.AddWithValue("@Weight_Dish", WeightField.Text);
                            command.Parameters.AddWithValue("@Photo_Dish", AddImageDish.ImageLocation);
                            command.Parameters.AddWithValue("@Price_Dish", PriceField.Text);
                            command.Parameters.AddWithValue("@ID_Category_Dish", (int)CategoryDishDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Weight", (int)CategoryWeightDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.FM.DishesPanel.Controls.Find("DishCard", true);
                            foreach (Dish c in cards.OfType<Dish>())
                                if (c.ID == ID)
                                {
                                    c.NameDishField.Text = NameDishField.Text;
                                    c.RecipeField.Text = RecipeField.Text;
                                    c.PriceField.Text = PriceField.Text;
                                    c.WeightField.Text = WeightField.Text;
                                    c.pictureDish.Image = Image.FromFile(AddImageDish.ImageLocation);
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
                    FormMain.FM.RefreshDish();
                    FormMain.FM.RefreshOrder();
                }
            }
            else
            {
                string query = "INSERT INTO Dishes " +
                    "(Name_Dish, Recipe_Dish, Weight_Dish, Price_Dish, " +
                    "Photo_Dish, ID_Category_Dish, ID_Weight ) " +
                    "VALUES (@Name_Dish, @Recipe_Dish, @Weight_Dish, " +
                    "@Price_Dish, @Photo_Dish, @ID_Category_Dish, @ID_Weight )";
                if (String.IsNullOrWhiteSpace(NameDishField.Text) || CategoryDishDropdown.Text.Equals("Выбрать")
                    || CategoryWeightDropdown.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(WeightField.Text) || String.IsNullOrWhiteSpace(PriceField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Name_Dish", NameDishField.Text);
                            command.Parameters.AddWithValue("@Recipe_Dish", RecipeField.Text);
                            command.Parameters.AddWithValue("@Weight_Dish", WeightField.Text);
                            command.Parameters.AddWithValue("@Price_Dish", PriceField.Text);
                            command.Parameters.AddWithValue("@Photo_Dish", Convert.ToString(file));
                            command.Parameters.AddWithValue("@ID_Category_Dish", (int)CategoryDishDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Weight", (int)CategoryWeightDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.FM.DishesPanel.Controls.Find("DishCard", true);
                            Dish lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Dish;
                                lastCardIndex = FormMain.FM.DishesPanel.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Dish newCard = new Dish
                            {
                                Name = "DishCard",
                                Parent = FormMain.FM.DishesPanel,
                                ID = id
                            };
                            newCard.RecipeField.Text = RecipeField.Text;
                            newCard.WeightField.Text = WeightField.Text;
                            newCard.PriceField.Text = PriceField.Text;
                            newCard.pictureDish.Image = Image.FromFile(Convert.ToString(AddImageDish.Tag));
                            FormMain.FM.DishesPanel.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.FM.RefreshDish();
            }
        }

        private void DishAdd_Load(object sender, EventArgs e)
        {
            LoadDropDownCategoryDishes();
            LoadDropDownCategoryWeight();
        }

        private void AddImageDish_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openFileDialog1.Filter = "ImageFiles(*.BMP;*.JPG;*.PNG;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";
                    file = openFileDialog1.FileName;
                    AddImageDish.Image = Image.FromFile(file);
                    AddImageDish.ImageLocation = file;
                    AddImageDish.InitialImage = Image.FromFile(file);
                    AddImageDish.Tag = file;
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
                    "Select Dishes.ID_Dish, Dishes.Name_Dish, Dishes.Recipe_Dish, " +
                    "Dishes.Weight_Dish, Dishes.Price_Dish, Dishes.Photo_Dish, " +
                    "Dishes.ID_Category_Dish, Dishes.ID_Weight, Units_Of_Measurement.ID_Weight," +
                    " Units_Of_Measurement.Abbreviation_Weight " +
                    "from Dishes, Units_Of_Measurement" +
                    " where Units_Of_measurement.ID_Weight=Dishes.ID_Weight and ID_Dish = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CategoryDishDropdown.SelectedValue = dataTable.Rows[0][6].ToString();
                    CategoryWeightDropdown.SelectedValue = dataTable.Rows[0][7].ToString();
                    NameDishField.Text = dataTable.Rows[0][1].ToString();
                    RecipeField.Text = dataTable.Rows[0][2].ToString();
                    PriceField.Text = dataTable.Rows[0][4].ToString();
                    WeightField.Text = dataTable.Rows[0][3].ToString();
                    AddImageDish.Image = Image.FromFile(dataTable.Rows[0][5].ToString());
                    AddImageDish.InitialImage = Image.FromFile(dataTable.Rows[0][5].ToString());
                    AddImageDish.ImageLocation = dataTable.Rows[0][5].ToString();
                }
                HeaderLabel.Text = "Редактирование блюда";
                AddButton.ButtonText = "Редактировать";
                _ = AddImageDish.Image;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }

        private void BunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }
    }
}