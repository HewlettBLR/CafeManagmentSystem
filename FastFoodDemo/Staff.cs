using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Staff : UserControl
    {
        public int ID { get; set; }

        public Staff()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить сотрудника?", "Подтверждение удаления",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
                string query = "DELETE FROM Staff WHERE ID_Staff = " + ID;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                FormMain.FM.RefreshStaff();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            StaffAdd staffAdd = new StaffAdd
            {
                ID = ID,
                Edit = true
            };
            staffAdd.Show();
        }
    }
}