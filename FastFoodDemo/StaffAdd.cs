using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class StaffAdd : Form
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        private string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

        public StaffAdd()
        {
            InitializeComponent();
        }

        public void LoadDropDownCategoryHiring()
        {
            string query = "Select * From Hiring_Status ";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    HiringStatusDropdown.DataSource = dataTable;
                HiringStatusDropdown.DisplayMember = "Name_Hiring";
                HiringStatusDropdown.ValueMember = "ID_Hiring";
            }
        }

        public void LoadDropDownCategoryPosition()
        {
            string query = "Select * From Positions";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                    PositionDropdown.DataSource = dataTable;
                PositionDropdown.DisplayMember = "Name_Poss";
                PositionDropdown.ValueMember = "ID_Poss";
            }
        }

        private void StaffAdd_Load(object sender, EventArgs e)
        {
            LoadDropDownCategoryHiring();
            LoadDropDownCategoryPosition();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Staff SET Surname_Staff=@Surname_Staff, " +
                               "Name_Staff=@Name_Staff, " +
                               "Middle_Name_Staff=@Middle_Name_Staff, " +
                               "Date_Of_Employment_Staff=@Date_Of_Employment_Staff, " +
                               "Adress_Staff=@Adress_Staff, " +
                               "Mob_Phone_Staff=@Mob_Phone_Staff, " +
                               "Passport_№_Staff=@Passport_№_Staff, " +
                               "Mail_Staff = @Mail_Staff, " +
                               "Hiring_Staff=@Hiring_Staff, " +
                               "Position_Staff=@Position_Staff" +
                               " WHERE ID_Staff = " + ID;
                if (String.IsNullOrWhiteSpace(SurnameField.Text) || String.IsNullOrWhiteSpace(NameField.Text)
                     || String.IsNullOrWhiteSpace(MiddlenameField.Text) || String.IsNullOrWhiteSpace(AdressField.Text)
                     || String.IsNullOrWhiteSpace(MobPhoneField.Text) || String.IsNullOrWhiteSpace(PassportField.Text)
                     || String.IsNullOrWhiteSpace(EmailField.Text)
                     || HiringStatusDropdown.Text.Equals("Выбрать") || PositionDropdown.Text.Equals("Выбрать"))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Staff", SurnameField.Text);
                            command.Parameters.AddWithValue("@Name_Staff", NameField.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Staff", MiddlenameField.Text);
                            command.Parameters.AddWithValue("@Date_Of_Employment_Staff", Convert.ToDateTime(DatePicker.Value).ToShortDateString());
                            command.Parameters.AddWithValue("@Adress_Staff", AdressField.Text);
                            command.Parameters.AddWithValue("@Mob_Phone_Staff", MobPhoneField.Text);
                            command.Parameters.AddWithValue("@Passport_№_Staff", PassportField.Text);
                            command.Parameters.AddWithValue("@Mail_Staff", EmailField.Text);
                            command.Parameters.AddWithValue("@Hiring_Staff", (int)HiringStatusDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Position_Staff", (int)PositionDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.FM.StaffPanel.Controls.Find("SotrudCard", true);
                            foreach (Staff c in cards.OfType<Staff>())
                                if (c.ID == ID)
                                {
                                    c.SurnameField.Text = SurnameField.Text;
                                    c.NameField.Text = NameField.Text;
                                    c.MiddlenameField.Text = MiddlenameField.Text;
                                    c.DatePicker.Text = Convert.ToDateTime(DatePicker.Value).ToShortDateString();
                                    c.AdressField.Text = AdressField.Text;
                                    c.MobPhoneField.Text = MobPhoneField.Text;
                                    c.PassportField.Text = PassportField.Text;
                                    c.EmailField.Text = EmailField.Text;
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
                    FormMain.FM.RefreshStaff();
                }
            }
            else
            {
                string query = "INSERT INTO Staff " +
                               "(Surname_Staff, Name_Staff, Middle_Name_Staff, Date_Of_Employment_Staff, " +
                               "Adress_Staff,Mob_Phone_Staff, Passport_№_Staff, Mail_Staff, Hiring_Staff, " +
                               "Position_Staff ) " +
                               "VALUES " +
                               "(@Surname_Staff, @Name_Staff, @Middle_Name_Staff, @Date_Of_Employment_Staff, " +
                               "@Adress_Staff, @Mob_Phone_Staff, @Passport_№_Staff, @Mail_Staff, @Hiring_Staff," +
                               " @Position_Staff)";
                if (String.IsNullOrWhiteSpace(SurnameField.Text) || String.IsNullOrWhiteSpace(NameField.Text)
                     || String.IsNullOrWhiteSpace(MiddlenameField.Text) || String.IsNullOrWhiteSpace(AdressField.Text)
                     || HiringStatusDropdown.Text.Equals("Выбрать") || PositionDropdown.Text.Equals("Выбрать"))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Staff", SurnameField.Text);
                            command.Parameters.AddWithValue("@Name_Staff", NameField.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Staff", MiddlenameField.Text);
                            command.Parameters.AddWithValue("@Date_Of_Employment_Staff", Convert.ToDateTime(DatePicker.Value).ToShortDateString());
                            command.Parameters.AddWithValue("@Adress_Staff", AdressField.Text);
                            command.Parameters.AddWithValue("@Mob_Phone_Staff", MobPhoneField.Text);
                            command.Parameters.AddWithValue("@Passport_№_Staff", PassportField.Text);
                            command.Parameters.AddWithValue("@Mail_Staff", EmailField.Text);
                            command.Parameters.AddWithValue("@Hiring_Staff", (int)HiringStatusDropdown.SelectedValue);
                            command.Parameters.AddWithValue("@Position_Staff", (int)PositionDropdown.SelectedValue);
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.FM.StaffPanel.Controls.Find("SotrudCard", true);
                            Staff lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Staff;
                                lastCardIndex = FormMain.FM.StaffPanel.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Staff newCard = new Staff
                            {
                                Name = "SotrudCard",
                                Parent = FormMain.FM.StaffPanel,
                                ID = id
                            };
                            newCard.SurnameField.Text = SurnameField.Text;
                            newCard.NameField.Text = NameField.Text;
                            newCard.MiddlenameField.Text = MiddlenameField.Text;
                            newCard.DatePicker.Text = DatePicker.Text;
                            newCard.AdressField.Text = AdressField.Text;
                            newCard.MobPhoneField.Text = MobPhoneField.Text;
                            newCard.PassportField.Text = PassportField.Text;
                            newCard.EmailField.Text = EmailField.Text;
                            newCard.HiringStatusField.Text = HiringStatusDropdown.DisplayMember;
                            newCard.PositionField.Text = PositionDropdown.DisplayMember;
                            FormMain.FM.StaffPanel.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.FM.RefreshStaff();
            }
        }

        private void StaffAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "SELECT ID_Staff, " +
                               "Surname_Staff, " +
                               "Name_Staff, " +
                               "Middle_Name_Staff, " +
                               "Date_Of_Employment_Staff, " +
                               "Adress_Staff, " +
                               "Mob_Phone_Staff, " +
                               "Passport_№_Staff, " +
                               "Mail_Staff, " +
                               "Hiring_Status.Name_Hiring, " +
                               "Positions.Name_Poss, " +
                               "Available," +
                               "Hiring_Status.ID_Hiring, " +
                               "Positions.ID_Poss " +
                               "FROM Staff, Hiring_Status, Positions " +
                               "WHERE Staff.Hiring_Staff = Hiring_Status.ID_Hiring And " +
                               "Staff.Position_Staff = Positions.ID_Poss And ID_Staff = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    SurnameField.Text = dataTable.Rows[0][1].ToString();
                    NameField.Text = dataTable.Rows[0][2].ToString();
                    MiddlenameField.Text = dataTable.Rows[0][3].ToString();
                    DatePicker.Text = dataTable.Rows[0][4].ToString();
                    AdressField.Text = dataTable.Rows[0][5].ToString();
                    MobPhoneField.Text = dataTable.Rows[0][6].ToString();
                    PassportField.Text = dataTable.Rows[0][7].ToString();
                    EmailField.Text = dataTable.Rows[0][8].ToString();
                    HiringStatusDropdown.SelectedValue = dataTable.Rows[0][12].ToString();
                    PositionDropdown.SelectedValue = dataTable.Rows[0][13].ToString();
                }
                HeaderLabel.Text = "Редактирование";
                AddButton.ButtonText = "Редактировать";
            }
        }

        private void BunifuTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }

        private void BunifuTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }
    }
}