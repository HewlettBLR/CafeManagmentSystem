using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Linq;

namespace FastFoodDemo
{
    public partial class StaffAdd : Form
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";

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
                    bunifuDropdown1.DataSource = dataTable;
                bunifuDropdown1.DisplayMember = "Name_Hiring";
                bunifuDropdown1.ValueMember = "ID_Hiring";
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
                    bunifuDropdown2.DataSource = dataTable;
                bunifuDropdown2.DisplayMember = "Name_Poss";
                bunifuDropdown2.ValueMember = "ID_Poss";
            }
        }

        private void SotrudAdd_Load(object sender, EventArgs e)
        {
            LoadDropDownCategoryHiring();
            LoadDropDownCategoryPosition();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSot_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "UPDATE Staff SET Surname_Staff=@Surname_Staff, Name_Staff=@Name_Staff, " +
                    "Middle_Name_Staff=@Middle_Name_Staff, Date_Of_Employment_Staff=@Date_Of_Employment_Staff, " +
                    "Adress_Staff=@Adress_Staff, Mob_Phone_Staff=@Mob_Phone_Staff, Passport_№_Staff=@Passport_№_Staff, " +
                    "Mail_Staff = @Mail_Staff, Hiring_Staff=@Hiring_Staff, Position_Staff=@Position_Staff" +
                    " WHERE ID_Staff = " + ID;
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || String.IsNullOrWhiteSpace(bunifuTextBox2.Text)
                     || String.IsNullOrWhiteSpace(bunifuTextBox3.Text) || String.IsNullOrWhiteSpace(bunifuTextBox4.Text)
                     || String.IsNullOrWhiteSpace(bunifuTextBox5.Text) || String.IsNullOrWhiteSpace(bunifuTextBox6.Text)
                     || String.IsNullOrWhiteSpace(bunifuTextBox7.Text)
                     || bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать"))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Staff", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Name_Staff", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Staff", bunifuTextBox3.Text);
                            command.Parameters.AddWithValue("@Date_Of_Employment_Staff", Convert.ToDateTime(bunifuDatePicker1.Value).ToShortDateString());
                            command.Parameters.AddWithValue("@Adress_Staff", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Mob_Phone_Staff", bunifuTextBox5.Text);
                            command.Parameters.AddWithValue("@Passport_№_Staff", bunifuTextBox6.Text);
                            command.Parameters.AddWithValue("@Mail_Staff", bunifuTextBox7.Text);

                            command.Parameters.AddWithValue("@Hiring_Staff", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@Position_Staff", (int)bunifuDropdown2.SelectedValue);

                            command.ExecuteNonQuery();
                            Control[] cards = FormMain.SR.flowLayoutPanel2.Controls.Find("SotrudCard", true);
                            foreach (Staff g in cards.OfType<Staff>())
                                if (g.ID == ID)
                                {
                                    g.bunifuTextBox1.Text = bunifuTextBox1.Text;
                                    g.bunifuTextBox2.Text = bunifuTextBox2.Text;
                                    g.bunifuTextBox3.Text = bunifuTextBox3.Text;
                                    g.bunifuDatePicker1.Text = Convert.ToDateTime(bunifuDatePicker1.Value).ToShortDateString();
                                    g.bunifuTextBox4.Text = bunifuTextBox4.Text;
                                    g.bunifuTextBox5.Text = bunifuTextBox5.Text;
                                    g.bunifuTextBox6.Text = bunifuTextBox6.Text;
                                    g.bunifuTextBox7.Text = bunifuTextBox7.Text;
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
                    FormMain.SR.RefreshStaff();
                }
            }
            else
            {
                string query = "INSERT INTO Staff (Surname_Staff, Name_Staff, Middle_Name_Staff, Date_Of_Employment_Staff, " +
                    "Adress_Staff,Mob_Phone_Staff, Passport_№_Staff, Mail_Staff, Hiring_Staff, Position_Staff ) VALUES(@Surname_Staff, @Name_Staff, @Middle_Name_Staff, @Date_Of_Employment_Staff, " +
                    "@Adress_Staff, @Mob_Phone_Staff, @Passport_№_Staff, @Mail_Staff, @Hiring_Staff, @Position_Staff)";
                if (String.IsNullOrWhiteSpace(bunifuTextBox1.Text) || String.IsNullOrWhiteSpace(bunifuTextBox2.Text)
                     || String.IsNullOrWhiteSpace(bunifuTextBox3.Text) || String.IsNullOrWhiteSpace(bunifuTextBox4.Text)
|| bunifuDropdown1.Text.Equals("Выбрать") || bunifuDropdown2.Text.Equals("Выбрать"))
                    MessageBox.Show("Заполните все поля!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        try
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Surname_Staff", bunifuTextBox1.Text);
                            command.Parameters.AddWithValue("@Name_Staff", bunifuTextBox2.Text);
                            command.Parameters.AddWithValue("@Middle_Name_Staff", bunifuTextBox3.Text);
                            command.Parameters.AddWithValue("@Date_Of_Employment_Staff", Convert.ToDateTime(bunifuDatePicker1.Value).ToShortDateString());
                            command.Parameters.AddWithValue("@Adress_Staff", bunifuTextBox4.Text);
                            command.Parameters.AddWithValue("@Mob_Phone_Staff", bunifuTextBox5.Text);
                            command.Parameters.AddWithValue("@Passport_№_Staff", bunifuTextBox6.Text);
                            command.Parameters.AddWithValue("@Mail_Staff", bunifuTextBox7.Text);
                            command.Parameters.AddWithValue("@Hiring_Staff", (int)bunifuDropdown1.SelectedValue);
                            command.Parameters.AddWithValue("@Position_Staff", (int)bunifuDropdown2.SelectedValue);

                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT @@IDENTITY";
                            int id = (int)(command.ExecuteScalar());
                            Control[] c = FormMain.SR.flowLayoutPanel2.Controls.Find("SotrudCard", true);
                            Staff lastCard;
                            int lastCardIndex;
                            if (c.Length != 0)
                            {
                                lastCard = c[c.Length - 1] as Staff;
                                lastCardIndex = FormMain.SR.flowLayoutPanel2.Controls.GetChildIndex(lastCard);
                            }
                            else
                                lastCardIndex = -1;
                            Staff newCard = new Staff
                            {
                                Name = "SotrudCard",
                                Parent = FormMain.SR.flowLayoutPanel2,
                                ID = id
                            };
                            newCard.bunifuTextBox1.Text = bunifuTextBox1.Text;
                            newCard.bunifuTextBox2.Text = bunifuTextBox2.Text;
                            newCard.bunifuTextBox3.Text = bunifuTextBox3.Text;
                            newCard.bunifuDatePicker1.Text = bunifuDatePicker1.Text;
                            newCard.bunifuTextBox4.Text = bunifuTextBox4.Text;
                            newCard.bunifuTextBox5.Text = bunifuTextBox5.Text;
                            newCard.bunifuTextBox6.Text = bunifuTextBox6.Text;
                            newCard.bunifuTextBox7.Text = bunifuTextBox7.Text;
                            newCard.bunifuTextBox8.Text = bunifuDropdown1.DisplayMember;
                            newCard.bunifuTextBox9.Text = bunifuDropdown2.DisplayMember;

                            FormMain.SR.flowLayoutPanel2.Controls.SetChildIndex(newCard, lastCardIndex + 1);
                            MessageBox.Show("Запись успешно добавлена!", "добавление записи", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Не удалось добавить запись!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                FormMain.SR.RefreshStaff();
            }
        }

        private void SotrudAdd_Shown(object sender, EventArgs e)
        {
            if (Edit)
            {
                string query = "SELECT ID_Staff, Surname_Staff, Name_Staff, Middle_Name_Staff, " +
                    "Date_Of_Employment_Staff, Adress_Staff, Mob_Phone_Staff, " +
                "Passport_№_Staff, Mail_Staff, Hiring_Status.Name_Hiring, Positions.Name_Poss, Available," +
                "Hiring_Status.ID_Hiring, Positions.ID_Poss " +
                "FROM Staff, Hiring_Status, Positions " +
                "WHERE Staff.Hiring_Staff = Hiring_Status.ID_Hiring And " +
                "Staff.Position_Staff = Positions.ID_Poss And ID_Staff = " + ID;
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    bunifuTextBox1.Text = dataTable.Rows[0][1].ToString();
                    bunifuTextBox2.Text = dataTable.Rows[0][2].ToString();
                    bunifuTextBox3.Text = dataTable.Rows[0][3].ToString();
                    bunifuDatePicker1.Text = dataTable.Rows[0][4].ToString();
                    bunifuTextBox4.Text = dataTable.Rows[0][5].ToString();
                    bunifuTextBox5.Text = dataTable.Rows[0][6].ToString();
                    bunifuTextBox6.Text = dataTable.Rows[0][7].ToString();
                    bunifuTextBox7.Text = dataTable.Rows[0][8].ToString();
                    bunifuDropdown1.SelectedValue = dataTable.Rows[0][12].ToString();
                    bunifuDropdown2.SelectedValue = dataTable.Rows[0][13].ToString();
                }
                dd.Text = "Редактирование";
                AddSot.ButtonText = "Редактировать";
            }
        }

        private void BunifuTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);

        }

        private void BunifuTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.SR.Digit(e);

        }
    }
}