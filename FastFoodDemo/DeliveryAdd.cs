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
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
        public DeliveryAdd()
        {
            InitializeComponent();
        }

        private void BunifuDatePicker2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            if (Edit)
            {

                string query = "UPDATE Delivery SET Time_Delivery=@Time_Delivery, " +
                    "ID_Courier=@ID_Courier, Adress_Delivery=@Adress_Delivery, ID_Order=@ID_Order " +
                    " WHERE ID_Delivery = " + ID;
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(bunifuDatePicker1.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Time_Delivery", bunifuDatePicker1.Value.ToShortTimeString());
                            command.Parameters.AddWithValue("@ID_Courier", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@Adress_Delivery", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@ID_Order", (int)bunifuDropdown2.SelectedValue);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.SR.flowLayoutPanel5.Controls.Find("DeliveryCard", true);
                            foreach (Delivery c in cards.OfType<Delivery>())
                                if (c.ID == ID)
                                {
                                    c.bunifuTextBox3.Text = bunifuTextBox1.Text;
                                    c.bunifuDatePicker2.Text = Convert.ToDateTime(bunifuDatePicker1.Value).ToShortTimeString();
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
                    FormMain.SR.RefreshDelivery();
                }
            }
            else
            {
                string query = "INSERT INTO Delivery (Time_Delivery, ID_Courier, Adress_Delivery, ID_Order) " +
                    " VALUES (@Time_Delivery, @ID_Courier, @Adress_Delivery, @ID_Order)";
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать")
                     || String.IsNullOrWhiteSpace(bunifuDatePicker1.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        //try
                        //{
                            connection.Open();
                            command.Parameters.AddWithValue("@Time_Delivery", bunifuDatePicker1.Value.ToShortTimeString());
                            command.Parameters.AddWithValue("@ID_Courier", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@Adress_Delivery", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@ID_Order", (int)bunifuDropdown2.SelectedValue);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.SR.flowLayoutPanel5.Controls.Find("DeliveryCard", true);
                            Delivery lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Delivery;
                                lastCardIndex = FormMain.SR.flowLayoutPanel5.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Delivery newCard = new Delivery
                            {
                                Name = "DeliveryCard",
                                Parent = FormMain.SR.flowLayoutPanel5,
                                ID = id
                            };
                            newCard.bunifuTextBox3.Text = bunifuTextBox1.Text;
                            newCard.bunifuDatePicker2.Text = Convert.ToDateTime(bunifuDatePicker1.Value).ToShortTimeString();
                            FormMain.SR.flowLayoutPanel5.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        //}
                        //catch (Exception)
                        //{
                        //    MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //}
                    }
                }
                FormMain.SR.RefreshDelivery();
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
                    bunifuDropdown2.DataSource = dataTable;
                bunifuDropdown2.DisplayMember = "Name_Type_Order";
                bunifuDropdown2.ValueMember = "ID_Order";
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
                    bunifuDropdown1.DataSource = dataTable;
                bunifuDropdown1.DisplayMember = "Surname_Staff";
                bunifuDropdown1.ValueMember = "ID_Staff";
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
                    bunifuDropdown1.SelectedValue = dataTable.Rows[0][2].ToString();
                    bunifuDropdown2.SelectedValue = dataTable.Rows[0][4].ToString();
                    bunifuTextBox1.Text = dataTable.Rows[0][3].ToString();
                    bunifuDatePicker1.Text = dataTable.Rows[0][1].ToString();
                }
                dd.Text = "Редактирование заказа";
                bunifuButton2.ButtonText = "Исправить";
            }
        }
    }
}
