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
        private string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public OrderAdd()
        {
            InitializeComponent();
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            LoadDropDownTypeOrder();
            LoadDropDownSotrud();
            LoadDropDownClients();
            LoadDropDownDish();
        }

        public void LoadDropDownSotrud()
        {
            string query = "SELECT ID_Staff, Surname_Staff, Name_Staff, Position_Staff " +
                           "FROM Staff WHERE Position_Staff <> 4";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    dataTable.Rows[i][1] = dataTable.Rows[i][1] + " " + dataTable.Rows[i][2].ToString();
                StaffDropdown.DataSource = dataTable;
                StaffDropdown.DisplayMember = "Surname_Staff";
                StaffDropdown.ValueMember = "ID_Staff";
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
                ClientsDropdown.DataSource = dataTable;
                ClientsDropdown.DisplayMember = "Surname_Client";
                ClientsDropdown.ValueMember = "ID_Client";
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
                    DishDropdown.DataSource = dataTable;
                DishDropdown.DisplayMember = "Name_Dish";
                DishDropdown.ValueMember = "ID_Dish";
                DishDropdown.SelectedValue = ID;
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
                    TypeOrderDropdown.DataSource = dataTable;
                TypeOrderDropdown.DisplayMember = "Name_Type_Order";
                TypeOrderDropdown.ValueMember = "ID_Type_Order";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Orders SET " +
                               "ID_Dish=@ID_Dish, " +
                               "ID_Staff=@ID_Staff, " +
                               "Date_Order=@Date_Order, " +
                               "ID_Client=@ID_Client, " +
                               "ID_Type_Order=@ID_Type_Order, " +
                               "Number_Of_Servings=@Number_Of_Servings, " +
                               "Lead_Time=@Lead_Time " +
                               "WHERE ID_Order = " + ID;
                if (String.IsNullOrWhiteSpace(CountField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@ID_Dish", (int)DishDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Staff", (int)StaffDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Date_Order", DatePicker.Value.ToShortDateString());
                            command.Parameters.AddWithValue("@ID_Client", (int)ClientsDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Type_Order", (int)TypeOrderDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Number_Of_Servings", CountField.Text);
                            command.Parameters.AddWithValue("@Lead_Time", LeadTimePicker.Value.ToShortTimeString());
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.FM.OrdersPanel.Controls.Find("OrderCard", true);
                            foreach (Orders c in cards.OfType<Orders>())
                                if (c.ID == ID)
                                {
                                    c.CountField.Text = CountField.Text;
                                    c.DatePicker.Text = Convert.ToDateTime(DatePicker.Value).ToShortDateString();
                                    c.LeadTimeField.Text = Convert.ToDateTime(LeadTimePicker.Value).ToShortTimeString();
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
                    FormMain.FM.RefreshOrder();
                }
            }
            else
            {
                string query = "INSERT INTO Orders (ID_Dish,ID_Staff, " +
                               "Date_Order,ID_Client, ID_Type_Order, " +
                               "Number_Of_Servings, Lead_Time) " +
                               "VALUES (@ID_Dish,@ID_Staff, @Date_Order, @ID_Client, " +
                               "@ID_Type_Order, @Number_Of_Servings, @Lead_Time)";
                if (String.IsNullOrWhiteSpace(CountField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@ID_Dish", (int)DishDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Staff", (int)StaffDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Date_Order", DatePicker.Value.ToShortDateString());
                            command.Parameters.AddWithValue("@ID_Client", (int)ClientsDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@ID_Type_Order", (int)TypeOrderDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Number_Of_Servings", CountField.Text);
                            command.Parameters.AddWithValue("@Lead_Time", LeadTimePicker.Value.ToShortTimeString());
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.FM.OrdersPanel.Controls.Find("OrderCard", true);
                            Orders lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Orders;
                                lastCardIndex = FormMain.FM.OrdersPanel.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Orders newCard = new Orders
                            {
                                Name = "OrderCard",
                                Parent = FormMain.FM.OrdersPanel,
                                ID = id
                            };
                            FormMain.FM.OrdersPanel.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "Добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.FM.RefreshOrder();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CountField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }

        private void OrderAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query =
                    "SELECT * FROM Orders WHERE ID_Order = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DishDropdown.SelectedValue = dataTable.Rows[0][1].ToString();
                    StaffDropdown.SelectedValue = dataTable.Rows[0][2].ToString();
                    DatePicker.Text = dataTable.Rows[0][3].ToString();
                    ClientsDropdown.SelectedValue = dataTable.Rows[0][4].ToString();
                    TypeOrderDropdown.SelectedValue = dataTable.Rows[0][5].ToString();
                    CountField.Text = dataTable.Rows[0][6].ToString();
                    LeadTimePicker.Text = dataTable.Rows[0][7].ToString();
                }
                HeaderLabel.Text = "Редактирование заказа";
                AddButton.ButtonText = "Исправить";
            }
        }

        private void DatePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }
    }
}