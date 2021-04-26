using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Dish : UserControl
    {
        public int ID { get; set; }
        public int Edit { get; set; }


        public Dish()
        {
            InitializeComponent();
        }


        private void ByeButton_Click(object sender, EventArgs e)
        {
            OrderAdd byedish = new OrderAdd
            {
                ID = ID
            };
            byedish.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DishAdd dishadd = new DishAdd
            {
                ID = ID,
                Edit = true
            };
            dishadd.Show();            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
         string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
        string query = "DELETE FROM Dishes WHERE ID_Dish = "+ID;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            using (OleDbCommand command = new OleDbCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
                FormMain.SR.RefreshDish();
                MessageBox.Show("Запись успешно удалена!", "Запись удалена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
