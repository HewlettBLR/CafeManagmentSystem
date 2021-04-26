using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Delivery : UserControl
    {
        public int ID { get; set; }
        public bool Edit { get; set; }
        public Delivery()
        {
            InitializeComponent();
        }

        private void BunifuButton1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
                string query = "DELETE FROM Delivery WHERE ID_Delivery = " + ID;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                FormMain.SR.RefreshDelivery();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BunifuButton2_Click(object sender, System.EventArgs e)
        {
            DeliveryAdd deliveryAdd = new DeliveryAdd
            {
                ID = ID,
                Edit = true
            };
            deliveryAdd.Show();
        }
    }
}
