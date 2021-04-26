using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo

{
    public partial class FormMain : Form
    {
        public int ID { get; set; }
        public static FormMain SR { get; set; }

        string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
        public FormMain()
        {
            InitializeComponent();
            SR = this;
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }
        public void Digit(KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num !=8)
                e.Handled = true;
        }
        public void LoadDish()
        {
            string query = "SELECT * FROM Dishes, Units_Of_Measurement where Dishes.ID_Weight =" +
                " Units_Of_Measurement.ID_Weight ";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Dish[] cards = new Dish[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Dish
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].Nazv.Text = dataTable.Rows[i][1].ToString();
                    cards[i].Opisanie.Text = dataTable.Rows[i][2].ToString();
                    cards[i].weight.Text = dataTable.Rows[i][3].ToString() + dataTable.Rows[i][10].ToString();
                    cards[i].Price.Text = dataTable.Rows[i][4].ToString() + " BYN";
                    cards[i].pictureDish.Image = Image.FromFile(dataTable.Rows[i][5].ToString());
                    cards[i].Parent = flowLayoutPanel3;
                    cards[i].Name = "DishCard";
                }
            }
        }
        public void RefreshOrder()
        {
            string query =
                "SELECT Dishes.ID_Dish, Dishes.Name_Dish, Staff.Surname_Staff, Staff.Name_Staff, " +
                "Staff.Middle_Name_Staff, Orders.ID_Order, Orders.Date_Order, Orders.Number_Of_Servings, " +
                "Type_Order.ID_Type_Order, Type_Order.Name_Type_Order, Clients.ID_Client, " +
                "Clients.Surname_Client, Clients.Name_Client, Clients.Middle_Name_Client, " +
                "(Orders.Number_Of_Servings*Dishes.Price_Dish) AS [Итоговая цена/бел руб], " +
                "Staff.ID_Staff, Orders.ID_Dish, Orders.ID_Type_Order, Orders.ID_Client, " +
                "Units_Of_Measurement.Abbreviation_Weight, Units_Of_Measurement.ID_Weight, " +
                "Dishes.Weight_Dish, Orders.Lead_Time" +
                " FROM Staff, Orders, Dishes, Type_Order, Clients, Units_Of_Measurement" +
                " WHERE Staff.ID_Staff = Orders.ID_Staff And Orders.ID_Dish = Dishes.ID_Dish AND " +
                "Orders.ID_Type_Order = Type_Order.ID_Type_Order AND Orders.ID_Client = Clients.ID_Client and " +
                "Units_Of_Measurement.ID_Weight = Dishes.ID_Weight";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = flowLayoutPanel4.Controls.Find("OrderCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Orders newCard = new Orders
                        {
                            Name = "OrderCard",
                            Parent = flowLayoutPanel4
                        };
                        flowLayoutPanel4.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        flowLayoutPanel4.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Orders[] cards = new Orders[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Orders;
                    cards[i].ID = (int)dataTable.Rows[i][5];

                    cards[i].bunifuCustomLabel1.Text = "Заказ " + dataTable.Rows[i][5].ToString();
                    //Клиент
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][11].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][12].ToString();
                    //Сотрудник
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][3].ToString();
                    //Заказ
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox6.Text = dataTable.Rows[i][14].ToString() + "BYN";
                    cards[i].bunifuTextBox7.Text = dataTable.Rows[i][21].ToString() + dataTable.Rows[i][19].ToString();
                    cards[i].bunifuTextBox8.Text = dataTable.Rows[i][7].ToString();
                    cards[i].bunifuTextBox9.Text = dataTable.Rows[i][9].ToString();
                    cards[i].bunifuDatePicker2.Text = dataTable.Rows[i][22].ToString();

                    cards[i].Parent = flowLayoutPanel4;
                    cards[i].Name = "OrderCard";
                }
            }
        }
        public void RefreshDish()
        {
            string query = "SELECT * FROM Dishes, Units_Of_Measurement where Dishes.ID_Weight =" +
                " Units_Of_Measurement.ID_Weight";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = flowLayoutPanel3.Controls.Find("DishCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Dish newCard = new Dish
                        {
                            Name = "DishCard",
                            Parent = flowLayoutPanel3
                        };
                        flowLayoutPanel3.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        flowLayoutPanel3.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Dish[] cards = new Dish[cc.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Dish;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].Nazv.Text = dataTable.Rows[i][1].ToString();
                    cards[i].Opisanie.Text = dataTable.Rows[i][2].ToString();
                    cards[i].weight.Text = dataTable.Rows[i][3].ToString() + dataTable.Rows[i][10].ToString();
                    cards[i].Price.Text = dataTable.Rows[i][4].ToString() + " BYN";
                    cards[i].pictureDish.Image = Image.FromFile(dataTable.Rows[i][5].ToString());
                }
            }
        }
        public void RefreshClient()
        {
            string query = "SELECT * FROM Clients";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = flowLayoutPanel1.Controls.Find("ClientCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Dish newCard = new Dish
                        {
                            Name = "ClientCard",
                            Parent = flowLayoutPanel1
                        };
                        flowLayoutPanel1.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        flowLayoutPanel1.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Clients[] cards = new Clients[cc.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Clients;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].bunifuCustomLabel1.Text ="Клиент "+ dataTable.Rows[i][0].ToString();
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][4].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][5].ToString();
                }
            }
        }
        public void RefreshStaff()
        {
            string query = "SELECT ID_Staff, Surname_Staff, Name_Staff, Middle_Name_Staff, " +
                "Date_Of_Employment_Staff, Adress_Staff, Mob_Phone_Staff, " +
                "Passport_№_Staff, Mail_Staff, Hiring_Status.Name_Hiring, Positions.Name_Poss, " +
                "Available FROM Staff, Hiring_Status, Positions " +
                "WHERE Staff.Hiring_Staff = Hiring_Status.ID_Hiring And" +
                " Staff.Position_Staff = Positions.ID_Poss";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] st;
                do
                {
                    st = flowLayoutPanel2.Controls.Find("SotrudCard", true);
                    if (st.Length < dataTable.Rows.Count)
                    {
                        Staff newCard = new Staff
                        {
                            Name = "SotrudCard",
                            Parent = flowLayoutPanel2
                        };
                        flowLayoutPanel2.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (st.Length > dataTable.Rows.Count)
                        flowLayoutPanel2.Controls.RemoveAt(0);
                } while (st.Length != dataTable.Rows.Count);
                Staff[] cards = new Staff[st.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = st[i] as Staff;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][4].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][5].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuTextBox6.Text = dataTable.Rows[i][7].ToString();
                    cards[i].bunifuTextBox7.Text = dataTable.Rows[i][8].ToString();
                    cards[i].bunifuTextBox8.Text = dataTable.Rows[i][9].ToString();
                    cards[i].bunifuTextBox9.Text = dataTable.Rows[i][10].ToString();
                }
            }
        }
        public void RefreshDelivery()
        {
            string query =
             "SELECT Orders.ID_Order, Delivery.ID_Order, Staff.Surname_Staff, Staff.Name_Staff, Delivery.Adress_Delivery, " +
             "Delivery.Time_Delivery, Orders.Date_Order, Delivery.ID_Delivery"
            + " FROM Staff, Delivery, Orders" +
            " WHERE Orders.ID_Order = Delivery.ID_Order AND Delivery.ID_Courier = Staff.ID_Staff AND" +
            " Orders.ID_Type_Order = 2";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] st;
                do
                {
                    st = flowLayoutPanel5.Controls.Find("DeliveryCard", true);
                    if (st.Length < dataTable.Rows.Count)
                    {
                        Delivery newCard = new Delivery
                        {
                            Name = "DeliveryCard",
                            Parent = flowLayoutPanel5
                        };
                        flowLayoutPanel5.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (st.Length > dataTable.Rows.Count)
                        flowLayoutPanel5.Controls.RemoveAt(0);
                } while (st.Length != dataTable.Rows.Count);
                Delivery[] cards = new Delivery[st.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = st[i] as Delivery;
                    cards[i].ID = (int)dataTable.Rows[i][7];
                    cards[i].bunifuCustomLabel1.Text ="Доставка "+ dataTable.Rows[i][7].ToString();
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][4].ToString();
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuDatePicker2.Text = dataTable.Rows[i][5].ToString();

                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            Pages.SelectedTab = Dish;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справки еще нет(");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelDatePicker.Tag = $" = \"{datePickerGraphic.Value.ToShortDateString()}\"";
            LoadDish();
            LoadStaff();
            LoadClients();
            Pages.SelectedTab = Dish;
            LoadOrders();
            LoadDelivery();
        }

        

        public void LoadClients()
        {
            string query = "SELECT * FROM Clients";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Clients[] cards = new Clients[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Clients
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].bunifuCustomLabel1.Text = "Клиент " + dataTable.Rows[i][0].ToString();
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][5].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][4].ToString();
                    cards[i].Parent = flowLayoutPanel1;
                    cards[i].Name = "ClientCard";
                }
            }
        }

        public void LoadStaff()
        {
            string query = "SELECT ID_Staff, Surname_Staff, Name_Staff, Middle_Name_Staff, Date_Of_Employment_Staff, Adress_Staff, Mob_Phone_Staff, " +
                "Passport_№_Staff, Mail_Staff, Hiring_Status.Name_Hiring, Positions.Name_Poss, Available FROM Staff, Hiring_Status, Positions " +
                "WHERE Staff.Hiring_Staff = Hiring_Status.ID_Hiring And Staff.Position_Staff = Positions.ID_Poss";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Staff[] cards = new Staff[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Staff
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][4].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][5].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuTextBox6.Text = dataTable.Rows[i][7].ToString();
                    cards[i].bunifuTextBox7.Text = dataTable.Rows[i][8].ToString();
                    cards[i].bunifuTextBox8.Text = dataTable.Rows[i][9].ToString();
                    cards[i].bunifuTextBox9.Text = dataTable.Rows[i][10].ToString();

                    cards[i].Parent = flowLayoutPanel2;
                    cards[i].Name = "SotrudCard";
                }
            }
        }

        public void LoadOrders()
        {
            string query =
                "SELECT Dishes.ID_Dish, Dishes.Name_Dish, Staff.Surname_Staff, Staff.Name_Staff, " +
                "Staff.Middle_Name_Staff, Orders.ID_Order, Orders.Date_Order, Orders.Number_Of_Servings, " +
                "Type_Order.ID_Type_Order, Type_Order.Name_Type_Order, Clients.ID_Client, " +
                "Clients.Surname_Client, Clients.Name_Client, Clients.Middle_Name_Client, " +
                "(Orders.Number_Of_Servings*Dishes.Price_Dish) AS [Итоговая цена/бел руб], " +
                "Staff.ID_Staff, Orders.ID_Dish, Orders.ID_Type_Order, Orders.ID_Client, " +
                "Units_Of_Measurement.Abbreviation_Weight, Units_Of_Measurement.ID_Weight, " +
                "Dishes.Weight_Dish, Orders.Lead_Time" +
                " FROM Staff, Orders, Dishes, Type_Order, Clients, Units_Of_Measurement" +
                " WHERE Staff.ID_Staff = Orders.ID_Staff And Orders.ID_Dish = Dishes.ID_Dish AND " +
                "Orders.ID_Type_Order = Type_Order.ID_Type_Order AND Orders.ID_Client = Clients.ID_Client " +
                "and Units_Of_Measurement.ID_Weight = Dishes.ID_Weight";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Orders[] cards = new Orders[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Orders
                    {
                        ID = (int)dataTable.Rows[i][5]
                    };
                    cards[i].bunifuCustomLabel1.Text = "Заказ " + dataTable.Rows[i][5].ToString();
                    //Клиент
                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][11].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][12].ToString();
                    //Сотрудник
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox4.Text = dataTable.Rows[i][3].ToString();
                    //Заказ
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuTextBox5.Text = dataTable.Rows[i][1].ToString();
                    cards[i].bunifuTextBox6.Text = dataTable.Rows[i][14].ToString() + "BYN";
                    cards[i].bunifuTextBox7.Text = dataTable.Rows[i][21].ToString() + dataTable.Rows[i][19].ToString();
                    cards[i].bunifuTextBox8.Text = dataTable.Rows[i][7].ToString();
                    cards[i].bunifuTextBox9.Text = dataTable.Rows[i][9].ToString();
                    cards[i].bunifuDatePicker2.Text = dataTable.Rows[i][22].ToString();

                    cards[i].Parent = flowLayoutPanel4;
                    cards[i].Name = "OrderCard";
                }
            }
        }
        
        public void LoadDelivery()
        {
            string query =
             "SELECT Orders.ID_Order, " +
             "Delivery.ID_Order, " +
             "Staff.Surname_Staff, " +
             "Staff.Name_Staff, " +
             "Delivery.Adress_Delivery, " +
             "Delivery.Time_Delivery, " +
             "Orders.Date_Order, " +
             "Delivery.ID_Delivery"+ 
             " FROM Staff, Delivery, Orders" +
            " WHERE " +
            "Orders.ID_Order = Delivery.ID_Order AND Delivery.ID_Courier = Staff.ID_Staff AND" +
            " Orders.ID_Type_Order = 2";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Delivery[] cards = new Delivery[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Delivery()
                    {
                        ID = (int)dataTable.Rows[i][7]
                    };
                    cards[i].bunifuCustomLabel1.Text = "Доставка " + dataTable.Rows[i][7].ToString();

                    cards[i].bunifuTextBox1.Text = dataTable.Rows[i][2].ToString();
                    cards[i].bunifuTextBox2.Text = dataTable.Rows[i][3].ToString();
                    cards[i].bunifuTextBox3.Text = dataTable.Rows[i][4].ToString();
                    cards[i].bunifuDatePicker1.Text = dataTable.Rows[i][6].ToString();
                    cards[i].bunifuDatePicker2.Text = dataTable.Rows[i][5].ToString();

                    cards[i].Parent = flowLayoutPanel5;
                    cards[i].Name = "DeliveryCard";
                }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            Pages.SelectedTab = Sotrud;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            Pages.SelectedTab = Clients;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            Pages.SelectedTab = Orders;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://instagram.com/shaurmol");
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/shaur_mol");
        }

        private void BunifuImageButton4_Click(object sender, EventArgs e)
        {
            StaffAdd ads = new StaffAdd();
            ads.Show();
        }

        private void BunifuImageButton5_Click(object sender, EventArgs e)
        {
            DishAdd ds = new DishAdd();
            ds.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            Pages.SelectedTab = Delivery;
        }

        private void BunifuImageButton6_Click(object sender, EventArgs e)
        {
            ClientAdd cl = new ClientAdd();
            cl.Show();
        }

        private void BunifuImageButton7_Click(object sender, EventArgs e)
        {
            DeliveryAdd da = new DeliveryAdd();
            da.Show();

        }
    }
}