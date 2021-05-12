using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Clients : UserControl
    {
        public int ID { get; set; }
        public bool Edit { get; set; }

        public Clients()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
                string query = "DELETE FROM Clients WHERE ID_Client = " + ID;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                FormMain.FM.RefreshClient();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            ClientAdd clientAdd = new ClientAdd
            {
                ID = ID,
                Edit = true
            };
            clientAdd.Show();
        }

        private void MobPhoneField_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMain.FM.IsDigit(e);
        }
    }
}