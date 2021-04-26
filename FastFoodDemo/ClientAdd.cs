using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class ClientAdd : Form
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public ClientAdd()
        {
            InitializeComponent();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Clients SET Surname_Client=@Surname_Client, " +
                    "Name_Client=@Name_Client, Middle_Name_Client=@Middle_Name_Client, Adress_Client=@Adress_Client, " +
                    "Phone_Client=@Phone_Client WHERE ID_Client = " + ID;
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || String.IsNullOrWhiteSpace(bunifuTextBox4.Text) || String.IsNullOrWhiteSpace(bunifuTextBox5.Text)
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
                            command.Parameters.AddWithValue("@Surname_Client", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Name_Client", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Client", bunifuTextBox3.Text);
                            command.Parameters.AddWithValue("@Adress_Client", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Phone_Client", bunifuTextBox5.Text);

                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.SR.flowLayoutPanel1.Controls.Find("ClientCard", true);
                            foreach (Clients c in cards.OfType<Clients>())
                                if (c.ID == ID)
                                {
                                    c.bunifuTextBox1.Text = bunifuTextBox1.Text;
                                    c.bunifuTextBox2.Text = bunifuTextBox2.Text;
                                    c.bunifuTextBox3.Text = bunifuTextBox3.Text;
                                    c.bunifuTextBox4.Text = bunifuTextBox4.Text;
                                    c.bunifuTextBox5.Text = bunifuTextBox5.Text;
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
                    FormMain.SR.RefreshClient();
                }
            }
            else
            {
                string query = "INSERT INTO Clients (Surname_Client, Name_Client, Middle_Name_Client, " +
                    "Adress_Client, Phone_Client) VALUES " +
                    "(@Surname_Client, @Name_Client, @Middle_Name_Client, @Adress_Client, @Phone_Client)";
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || String.IsNullOrWhiteSpace(bunifuTextBox4.Text) || String.IsNullOrWhiteSpace(bunifuTextBox5.Text)
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
                            command.Parameters.AddWithValue("@Surname_Client", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Name_Client", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Client", bunifuTextBox3.Text);
                            command.Parameters.AddWithValue("@Adress_Client", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Phone_Client", bunifuTextBox5.Text);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.SR.flowLayoutPanel1.Controls.Find("ClientCard", true);
                            Clients lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Clients;
                                lastCardIndex = FormMain.SR.flowLayoutPanel1.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Clients newCard = new Clients
                            {
                                Name = "ClientCard",
                                Parent = FormMain.SR.flowLayoutPanel1,
                                ID = id
                            };
                            newCard.bunifuTextBox1.Text = bunifuTextBox1.Text;
                            newCard.bunifuTextBox2.Text = bunifuTextBox2.Text;
                            newCard.bunifuTextBox3.Text = bunifuTextBox3.Text;
                            newCard.bunifuTextBox4.Text = bunifuTextBox4.Text;
                            newCard.bunifuTextBox5.Text = bunifuTextBox5.Text;

                            FormMain.SR.flowLayoutPanel1.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.SR.RefreshClient();
            }
        }

        private void BunifuTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);
        }

        private void ClientAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query =
                    "SELECT * FROM Clients WHERE ID_Client = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bunifuTextBox1.Text = dataTable.Rows[0][1].ToString();
                    bunifuTextBox2.Text = dataTable.Rows[0][2].ToString();
                    bunifuTextBox3.Text = dataTable.Rows[0][3].ToString();
                    bunifuTextBox4.Text = dataTable.Rows[0][4].ToString();
                    bunifuTextBox5.Text = dataTable.Rows[0][5].ToString();
                }
                bunifuCustomLabel3.Text = "Редактирование клиента";
                bunifuButton2.ButtonText = "Исправить";
            }
        }
    }
}