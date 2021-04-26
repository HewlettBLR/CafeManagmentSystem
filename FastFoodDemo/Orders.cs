using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Orders : UserControl
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        public Orders()
        {
            InitializeComponent();
        }
       
        private void EditButton_Click(object sender, EventArgs e)
        {
            OrderAdd EdOrders = new OrderAdd
            {
                ID = ID,
                Edit = true
            };
            EdOrders.Show();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
                string query = "DELETE FROM Orders WHERE ID_Order = " + ID;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                FormMain.SR.RefreshOrder();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}