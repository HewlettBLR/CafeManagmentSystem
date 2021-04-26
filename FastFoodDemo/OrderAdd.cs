using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class OrderAdd : Form
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public OrderAdd()
        {
            InitializeComponent();
        }

        private void ByeDish_Load(object sender, EventArgs e)
        {
            LoadDropDownTypeOrder();
            LoadDropDownSotrud();
            LoadDropDownClients();
            LoadDropDownDish();
        }
        public void LoadDropDownSotrud()
        {
            string query = "SELECT ID_Staff, Surname_Staff, Name_Staff, Position_Staff FROM Staff WHERE Position_Staff <> 4";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    dataTable.Rows[i][1] = dataTable.Rows[i][1] + " " + dataTable.Rows[i][2].ToString();
                bunifuDropdown2.DataSource = dataTable;
                bunifuDropdown2.DisplayMember = "Surname_Staff";
                bunifuDropdown2.ValueMember = "ID_Staff";
            }
        }
        public void LoadDropDownClients()
        {
            string query = "SELECT ID_Client, Surname_Client, Name_Client FROM Clients";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    dataTable.Rows[i][1] = dataTable.Rows[i][1] + " " + dataTable.Rows[i][2].ToString();
                bunifuDropdown3.DataSource = dataTable;
                bunifuDropdown3.DisplayMember = "Surname_Client";
                bunifuDropdown3.ValueMember = "ID_Client";
            }
        }
        public void LoadDropDownDish()
        {
            string query = "SELECT ID_Dish, Name_Dish FROM Dishes Where ID_Dish";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    bunifuDropdown1.DataSource = dataTable;
                bunifuDropdown1.DisplayMember = "Name_Dish";
                bunifuDropdown1.ValueMember = "ID_Dish";
                bunifuDropdown1.SelectedValue = ID;
            }
        }
        public void LoadDropDownTypeOrder()
        {
            string query = "SELECT ID_Type_Order, Name_Type_Order FROM Type_Order";

            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    bunifuDropdown4.DataSource = dataTable;
                bunifuDropdown4.DisplayMember = "Name_Type_Order";
                bunifuDropdown4.ValueMember = "ID_Type_Order";
            }
        }
        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            if (Edit)
            {

                string query = "UPDATE Orders SET ID_Dish=@ID_Dish, " +
                    "ID_Staff=@ID_Staff, Date_Order=@Date_Order, ID_Client=@ID_Client, " +
                    "ID_Type_Order=@ID_Type_Order, Number_Of_Servings=@Number_Of_Servings, Lead_Time=@Lead_Time WHERE ID_Order = " + ID;
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@ID_Dish", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Staff", (int)bunifuDropdown2.SelectedValue);
                            command.Parameters.AddWithValue("@Date_Order", bunifuDatePicker1.Value.ToShortDateString());
                        command.Parameters.AddWithValue("@ID_Client", (int)bunifuDropdown3.SelectedValue);
                        command.Parameters.AddWithValue("@ID_Type_Order", (int)bunifuDropdown4.SelectedValue);
                        command.Parameters.AddWithValue("@Number_Of_Servings", bunifuTextBox1.Text);
                        command.Parameters.AddWithValue("@Lead_Time", bunifuDatePicker2.Value.ToShortTimeString());
                        command.ExecuteNonQuery();
                        Control[] cards = FormMain.SR.flowLayoutPanel4.Controls.Find("OrderCard", true);
                        foreach (Orders c in cards.OfType<Orders>())
                            if (c.ID == ID)
                            {
                                c.bunifuTextBox8.Text = bunifuTextBox1.Text;
                                c.bunifuDatePicker1.Text = Convert.ToDateTime(bunifuDatePicker1.Value).ToShortDateString();
                                c.bunifuDatePicker2.Text = Convert.ToDateTime(bunifuDatePicker2.Value).ToShortTimeString();
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
                    FormMain.SR.RefreshOrder();
                }
            }
            else
            {
                string query = "INSERT INTO Orders (ID_Dish,ID_Staff, Date_Order,ID_Client, ID_Type_Order, Number_Of_Servings, Lead_Time) " +
                            "VALUES (@ID_Dish,@ID_Staff, @Date_Order, @ID_Client, @ID_Type_Order, @Number_Of_Servings, @Lead_Time)";
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@ID_Dish", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Staff", (int)bunifuDropdown2.SelectedValue);
                            command.Parameters.AddWithValue("@Date_Order", bunifuDatePicker1.Value.ToShortDateString());
                            command.Parameters.AddWithValue("@ID_Client", (int)bunifuDropdown3.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Type_Order", (int)bunifuDropdown4.SelectedValue);

                            command.Parameters.AddWithValue("@Number_Of_Servings", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Lead_Time", bunifuDatePicker2.Value.ToShortTimeString());

                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.SR.flowLayoutPanel4.Controls.Find("OrderCard", true);
                            Orders lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Orders;
                                lastCardIndex = FormMain.SR.flowLayoutPanel4.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Orders newCard = new Orders
                            {
                                Name = "OrderCard",
                                Parent = FormMain.SR.flowLayoutPanel4,
                                ID = id
                            };
                            //newCard.bunifuTextBox1.Text = bunifuDropdown3.ValueMember;
                            //newCard.bunifuTextBox2.Text = bunifuDropdown3.ValueMember;
                            //newCard.bunifuTextBox3.Text = bunifuDropdown2.ValueMember;
                            //newCard.bunifuTextBox4.Text = bunifuDropdown2.ValueMember;
                            //newCard.bunifuTextBox5.Text = bunifuDropdown1.ValueMember;

                            //newCard.bunifuDatePicker1.Text = bunifuDatePicker1.Text;

                            //newCard.bunifuTextBox8.Text = bunifuTextBox1.Text;
                            //newCard.bunifuTextBox9.Text = bunifuDropdown4.ValueMember;
                            //newCard.bunifuDatePicker2.Text = bunifuDatePicker2.Text;

                            FormMain.SR.flowLayoutPanel4.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.SR.RefreshOrder();
            }
        }
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);
        }

        private void ByeDish_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query =
                    "SELECT * FROM Orders WHERE ID_Order = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bunifuDropdown1.SelectedValue = dataTable.Rows[0][1].ToString();
                    bunifuDropdown2.SelectedValue = dataTable.Rows[0][2].ToString();
                    bunifuDatePicker1.Text = dataTable.Rows[0][3].ToString();
                    bunifuDropdown3.SelectedValue = dataTable.Rows[0][4].ToString();
                    bunifuDropdown4.SelectedValue = dataTable.Rows[0][5].ToString();
                    bunifuTextBox1.Text = dataTable.Rows[0][6].ToString();
                    bunifuDatePicker2.Text = dataTable.Rows[0][7].ToString();

                }
                Bye.Text = "Редактирование заказа";
                bunifuButton2.ButtonText = "Исправить";

            }
        }

        private void BunifuDatePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);

        }
    }
}
