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
        private string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public ClientAdd()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Clients SET " +
                    "Surname_Client=@Surname_Client, " +
                    "Name_Client=@Name_Client, " +
                    "Middle_Name_Client=@Middle_Name_Client, " +
                    "Adress_Client=@Adress_Client, " +
                    "Phone_Client=@Phone_Client " +
                    "WHERE ID_Client = " + ID;
                if (String.IsNullOrWhiteSpace(SurnameField.Text) || String.IsNullOrWhiteSpace(MobPhoneField.Text)
                     || String.IsNullOrWhiteSpace(AdressField.Text)
                     || String.IsNullOrWhiteSpace(NameField.Text) || String.IsNullOrWhiteSpace(MiddlenameField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Client", SurnameField.Text);
                            command.Parameters.AddWithValue("@Name_Client", NameField.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Client", MiddlenameField.Text);
                            command.Parameters.AddWithValue("@Adress_Client", MobPhoneField.Text);
                            command.Parameters.AddWithValue("@Phone_Client", AdressField.Text);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.FM.ClientsPanel.Controls.Find("ClientCard", true);
                            foreach (Clients c in cards.OfType<Clients>())
                                if (c.ID == ID)
                                {
                                    c.SurnameField.Text = SurnameField.Text;
                                    c.NameField.Text = NameField.Text;
                                    c.MiddlenameField.Text = MiddlenameField.Text;
                                    c.MobPhoneField.Text = MobPhoneField.Text;
                                    c.AdressField.Text = AdressField.Text;
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
                    FormMain.FM.RefreshClient();
                }
            }
            else
            {
                string query = "INSERT INTO Clients " +
                    "(Surname_Client, Name_Client, Middle_Name_Client, " +
                    "Adress_Client, Phone_Client) " +
                    "VALUES (@Surname_Client, @Name_Client, " +
                    "@Middle_Name_Client, @Adress_Client, @Phone_Client)";
                if (String.IsNullOrWhiteSpace(SurnameField.Text) || String.IsNullOrWhiteSpace(MobPhoneField.Text)
                    || String.IsNullOrWhiteSpace(AdressField.Text)
                     || String.IsNullOrWhiteSpace(NameField.Text) || String.IsNullOrWhiteSpace(MiddlenameField.Text))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Client", SurnameField.Text);
                            command.Parameters.AddWithValue("@Name_Client", NameField.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Client", MiddlenameField.Text);
                            command.Parameters.AddWithValue("@Adress_Client", MobPhoneField.Text);
                            command.Parameters.AddWithValue("@Phone_Client", AdressField.Text);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.FM.ClientsPanel.Controls.Find("ClientCard", true);
                            Clients lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Clients;
                                lastCardIndex = FormMain.FM.ClientsPanel.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Clients newCard = new Clients
                            {
                                Name = "ClientCard",
                                Parent = FormMain.FM.ClientsPanel,
                                ID = id
                            };
                            newCard.SurnameField.Text = SurnameField.Text;
                            newCard.NameField.Text = NameField.Text;
                            newCard.MiddlenameField.Text = MiddlenameField.Text;
                            newCard.MobPhoneField.Text = MobPhoneField.Text;
                            newCard.AdressField.Text = AdressField.Text;
                            FormMain.FM.ClientsPanel.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.FM.RefreshClient();
            }
        }

        private void MobPhoneField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }

        private void ClientAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "SELECT * FROM Clients WHERE ID_Client = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    SurnameField.Text = dataTable.Rows[0][1].ToString();
                    NameField.Text = dataTable.Rows[0][2].ToString();
                    MiddlenameField.Text = dataTable.Rows[0][3].ToString();
                    MobPhoneField.Text = dataTable.Rows[0][5].ToString();
                    AdressField.Text = dataTable.Rows[0][4].ToString();
                }
                HaderLabel.Text = "Редактирование клиента";
                AddButton.ButtonText = "Исправить";
            }
        }
    }
}