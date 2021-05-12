using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class DeliveryAdd : Form
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        private string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public DeliveryAdd()
        {
            InitializeComponent();
        }

        private void LeadTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Delivery SET " +
                               "Time_Delivery=@Time_Delivery, " +
                               "ID_Courier=@ID_Courier, " +
                               "Adress_Delivery=@Adress_Delivery, " +
                               "ID_Order=@ID_Order " +
                               " WHERE ID_Delivery = " + ID;
                if (String.IsNullOrWhiteSpace(AdressField.Text) || CouriersDropdown.Text.Equals("Выбрать") || OrdersDropdown.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(LeadTimePicker.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Time_Delivery", LeadTimePicker.Value.ToShortTimeString());
                            command.Parameters.AddWithValue("@ID_Courier", (int)CouriersDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Adress_Delivery", AdressField.Text);
                            command.Parameters.AddWithValue("@ID_Order", (int)OrdersDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.FM.DeliveryPanel.Controls.Find("DeliveryCard", true);
                            foreach (Delivery c in cards.OfType<Delivery>())
                                if (c.ID == ID)
                                {
                                    c.AdressField.Text = AdressField.Text;
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
                    FormMain.FM.RefreshDelivery();
                }
            }
            else
            {
                string query = "INSERT INTO Delivery " +
                    "(Time_Delivery, ID_Courier, Adress_Delivery, ID_Order) " +
                    " VALUES (@Time_Delivery, @ID_Courier, @Adress_Delivery, @ID_Order)";
                if (String.IsNullOrWhiteSpace(AdressField.Text) || CouriersDropdown.Text.Equals("Выбрать") || OrdersDropdown.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(LeadTimePicker.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Time_Delivery", LeadTimePicker.Value.ToShortTimeString());
                            command.Parameters.AddWithValue("@ID_Courier", (int)CouriersDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Adress_Delivery", AdressField.Text);
                            command.Parameters.AddWithValue("@ID_Order", (int)OrdersDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.FM.DeliveryPanel.Controls.Find("DeliveryCard", true);
                            Delivery lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Delivery;
                                lastCardIndex = FormMain.FM.DeliveryPanel.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Delivery newCard = new Delivery
                            {
                                Name = "DeliveryCard",
                                Parent = FormMain.FM.DeliveryPanel,
                                ID = id
                            };
                            newCard.AdressField.Text = AdressField.Text;
                            newCard.LeadTimeField.Text = Convert.ToDateTime(LeadTimePicker.Value).ToShortTimeString();
                            FormMain.FM.DeliveryPanel.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.FM.RefreshDelivery();
            }
        }

        private void DeliveryAdd_Load(object sender, EventArgs e)
        {
            LoadDropDownOrder();
            LoadDropDownCourier();
        }

        public void LoadDropDownOrder()
        {
            string query = "SELECT * FROM Orders where ID_Type_Order = 2";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    OrdersDropdown.DataSource = dataTable;
                OrdersDropdown.DisplayMember = "Name_Type_Order";
                OrdersDropdown.ValueMember = "ID_Order";
            }
        }

        public void LoadDropDownCourier()
        {
            string query = "SELECT * FROM Staff where Position_Staff = 4";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    CouriersDropdown.DataSource = dataTable;
                CouriersDropdown.DisplayMember = "Surname_Staff";
                CouriersDropdown.ValueMember = "ID_Staff";
            }
        }

        private void DeliveryAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query =
                "SELECT * FROM Delivery where ID_Delivery = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CouriersDropdown.SelectedValue = dataTable.Rows[0][2].ToString();
                    OrdersDropdown.SelectedValue = dataTable.Rows[0][4].ToString();
                    AdressField.Text = dataTable.Rows[0][3].ToString();
                    LeadTimePicker.Text = dataTable.Rows[0][1].ToString();
                }
                HeadeLabel.Text = "Редактирование заказа";
                AddButton.ButtonText = "Исправить";
            }
        }
    }
}