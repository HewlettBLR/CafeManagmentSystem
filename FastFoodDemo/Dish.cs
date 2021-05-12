using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Dish : UserControl
    {
        public int ID { get; set; }
        public bool Edit { get; set; }

        public Dish()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OrderAdd orderAdd = new OrderAdd
            {
                ID = ID
            };
            orderAdd.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DishAdd dishAdd = new DishAdd
            {
                ID = ID,
                Edit = true
            };
            dishAdd.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
                string query = "DELETE FROM Dishes WHERE ID_Dish = " + ID;
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                FormMain.FM.RefreshDish();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}