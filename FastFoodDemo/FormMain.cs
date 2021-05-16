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
        public static FormMain FM { get; set; }
        readonly string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = CafeDB.accdb;";
       
        readonly string QueryDish = "SELECT * FROM Dishes, Units_Of_Measurement " +
                                           "WHERE Dishes.ID_Weight = Units_Of_Measurement.ID_Weight ";

        readonly string QueryOrders = "SELECT Dishes.ID_Dish, " +
                                      "Dishes.Name_Dish, " +
                                      "Staff.Surname_Staff, " +
                                      "Staff.Name_Staff, " +
                                      "Staff.Middle_Name_Staff, " +
                                      "Orders.ID_Order, " +
                                      "Orders.Date_Order, " +
                                      "Orders.Number_Of_Servings, " +
                                      "Type_Order.ID_Type_Order, " +
                                      "Type_Order.Name_Type_Order, " +
                                      "Clients.ID_Client, " +
                                      "Clients.Surname_Client, " +
                                      "Clients.Name_Client, " +
                                      "Clients.Middle_Name_Client, " +
                                      "(Orders.Number_Of_Servings*Dishes.Price_Dish) AS [Итоговая цена/бел руб], " +
                                      "Staff.ID_Staff, " +
                                      "Orders.ID_Dish, " +
                                      "Orders.ID_Type_Order, " +
                                      "Orders.ID_Client, " +
                                      "Units_Of_Measurement.Abbreviation_Weight, " +
                                      "Units_Of_Measurement.ID_Weight, " +
                                      "Dishes.Weight_Dish, " +
                                      "Orders.Lead_Time" +
                                      " FROM Staff, Orders, Dishes, Type_Order, Clients, Units_Of_Measurement" +
                                      " WHERE Staff.ID_Staff = Orders.ID_Staff " +
                                      "AND Orders.ID_Dish = Dishes.ID_Dish " +
                                      "AND Orders.ID_Type_Order = Type_Order.ID_Type_Order " +
                                      "AND Orders.ID_Client = Clients.ID_Client " +
                                      "AND Units_Of_Measurement.ID_Weight = Dishes.ID_Weight ";

        readonly string QueryClients = "SELECT * FROM Clients ";

        readonly string QueryStaff = "SELECT ID_Staff, " +
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
                                     "Available " +
                                     " FROM Staff, Hiring_Status, Positions " +
                                     " WHERE Staff.Hiring_Staff = Hiring_Status.ID_Hiring " +
                                     " AND Staff.Position_Staff = Positions.ID_Poss ";

        readonly string QueryDelivery = "SELECT Orders.ID_Order, " +
                                        "Delivery.ID_Order, " +
                                        "Staff.Surname_Staff, " +
                                        "Staff.Name_Staff, " +
                                        "Delivery.Adress_Delivery, " +
                                        "Delivery.Time_Delivery, " +
                                        "Orders.Date_Order, " +
                                        "Delivery.ID_Delivery" +
                                        " FROM Staff, Delivery, Orders" +
                                        " WHERE Orders.ID_Order = Delivery.ID_Order " +
                                        "AND Delivery.ID_Courier = Staff.ID_Staff " +
                                        "AND Orders.ID_Type_Order = 2 ";

        public FormMain()
        {
            InitializeComponent();
            FM = this;
            SidePanel.Height = DishShowButton.Height;
            SidePanel.Top = DishShowButton.Top;
        }
        public void RestartDGV()
        {
            DGView.DataSource = null;
            DGView.Rows.Clear();
            DGView.Columns.Clear();
            DGView.Update();
            DGView.Refresh();
        }

        public void DGDish(DataTable dt)
        {
            DGView.DataSource = dt;
            DGView.Columns[0].Visible = false;
            DGView.Columns[1].HeaderText = "Название\n" + " блюда";
            DGView.Columns[2].HeaderText = "Рецепт";
            DGView.Columns[3].HeaderText = "Вес";
            DGView.Columns[4].HeaderText = "Цена/бел.руб";
            DGView.Columns[5].Visible = false;
            DGView.Columns[6].Visible = false;
            DGView.Columns[7].Visible = false;
            DGView.Columns[8].Visible = false;
            DGView.Columns[9].Visible = false;
            DGView.Columns[10].HeaderText = "Ед.измерения";
        }

        public void DGOrders(DataTable dt)
        {
            DGView.DataSource = dt;
            DGView.Columns[0].Visible = false;
            DGView.Columns[1].HeaderText = "Название\n" + "блюда";
            DGView.Columns[2].HeaderText = "Фам.\n" + "сотрудника";
            DGView.Columns[3].HeaderText = "Имя\n" + "сотрудника";
            DGView.Columns[4].Visible = false;
            DGView.Columns[5].Visible = false;
            DGView.Columns[6].HeaderText = "Дата\n" + "заказа";
            DGView.Columns[6].DefaultCellStyle.Format = @"MM/dd/yyyy";
            DGView.Columns[7].HeaderText = "Кол-во";
            DGView.Columns[8].Visible = false;
            DGView.Columns[9].HeaderText = "Тип\n" + "заказа";
            DGView.Columns[10].Visible = false;
            DGView.Columns[11].HeaderText = "Фам.\n" + "клиента";
            DGView.Columns[12].HeaderText = "Имя\n" + "клиента";
            DGView.Columns[13].Visible = false;
            DGView.Columns[14].HeaderText = "Итогова цена\n" + "/бел.руб";
            DGView.Columns[15].Visible = false;
            DGView.Columns[16].Visible = false;
            DGView.Columns[17].Visible = false;
            DGView.Columns[18].Visible = false;
            DGView.Columns[19].HeaderText = "Ед.измерения";
            DGView.Columns[20].Visible = false;
            DGView.Columns[21].HeaderText = "Вес";
            DGView.Columns[22].Visible = false;
            DGView.Columns[22].HeaderText = "Время\n" + "выполнения";
            DGView.Columns[22].DefaultCellStyle.Format = @"mm\:ss";
        }

        public void DGClients(DataTable dt)
        {
            DGView.DataSource = dt;
            DGView.Columns[0].Visible = false;
            DGView.Columns[1].HeaderText = "Фам.\n" + "клиента";
            DGView.Columns[2].HeaderText = "Имя\n" + "клиента";
            DGView.Columns[3].Visible = false;
            DGView.Columns[4].HeaderText = "Адрес\n" + "клиента";
            DGView.Columns[5].HeaderText = "Тел.\n" + "клиента";
        }

        public void DGStaff(DataTable dt)
        {
            DGView.DataSource = dt;
            DGView.Columns[0].Visible = false;
            DGView.Columns[1].HeaderText = "Фам.\n" + "сотрудника";
            DGView.Columns[2].HeaderText = "Имя\n" + "сотрудника";
            DGView.Columns[3].Visible = false;
            DGView.Columns[4].HeaderText = "Дата\n" + "найма";
            DGView.Columns[5].HeaderText = "Адрес";
            DGView.Columns[6].HeaderText = "Тел.";
            DGView.Columns[7].HeaderText = "Паспорт";
            DGView.Columns[8].HeaderText = "Почта\n";
            DGView.Columns[10].HeaderText = "Должность";
            DGView.Columns[9].HeaderText = "Статус\n" + "найма";
            DGView.Columns[11].Visible = false;
        }

        public void DGDelivery(DataTable dt)
        {
            DGView.DataSource = dt;
            DGView.Columns[0].Visible = false;
            DGView.Columns[1].Visible = false;
            DGView.Columns[2].HeaderText = "Фам.\n" + "сотрудника";
            DGView.Columns[3].HeaderText = "Имя\n" + "сотрудника";
            DGView.Columns[4].HeaderText = "Адрес\n" + "доставки";
            DGView.Columns[5].Visible = false;
            DGView.Columns[6].Visible = false;
        }
        public void ShowHideDatePicker(bool visible)
        {
            DatePicker1.Visible = visible;
            DatePicker2.Visible = visible;
            BeginLabel.Visible = visible;
            EndLabel.Visible = visible;
            ChoiceLabel.Visible = visible;
            SearchDateButton.Visible = visible;
        }

        //Checking for entering number
        public void IsDigit(KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if (!Char.IsDigit(num) && num != 8)
                e.Handled = true;
        }

        //Filling UserControls with data and diplaying it
        public void LoadDish(string query)
        {
            RestartDGV();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGDish(dataTable);
                Dish[] cards = new Dish[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Dish
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].NameDishField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].RecipeField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].WeightField.Text = dataTable.Rows[i][3].ToString() + dataTable.Rows[i][10].ToString();
                    cards[i].PriceField.Text = dataTable.Rows[i][4].ToString() + " BYN";
                    cards[i].pictureDish.Image = Image.FromFile(dataTable.Rows[i][5].ToString());
                    cards[i].Parent = DishesPanel;
                    cards[i].Name = "DishCard";
                }
            }
        }

        public void LoadOrders(string query)
        {
            RestartDGV();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGOrders(dataTable);
                Orders[] cards = new Orders[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Orders
                    {
                        ID = (int)dataTable.Rows[i][5]
                    };
                    cards[i].HeaderLabel.Text = "Заказ " + dataTable.Rows[i][5].ToString();
                    //Клиент
                    cards[i].SurnameClientField.Text = dataTable.Rows[i][11].ToString();
                    cards[i].NameClientField.Text = dataTable.Rows[i][12].ToString();
                    //Сотрудник
                    cards[i].SurnameStaffField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].NameStaffField.Text = dataTable.Rows[i][3].ToString();
                    //Заказ
                    cards[i].DatePicker.Text = dataTable.Rows[i][6].ToString();
                    cards[i].NameDishField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].PriceField.Text = dataTable.Rows[i][14].ToString() + "BYN";
                    cards[i].WeightField.Text = dataTable.Rows[i][21].ToString() + dataTable.Rows[i][19].ToString();
                    cards[i].CountField.Text = dataTable.Rows[i][7].ToString();
                    cards[i].WayOfReceptionField.Text = dataTable.Rows[i][9].ToString();
                    cards[i].LeadTimeField.Text = dataTable.Rows[i][22].ToString();
                    cards[i].Parent = OrdersPanel;
                    cards[i].Name = "OrderCard";
                }
            }
        }

        public void LoadClients(string query)
        {
            RestartDGV();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGClients(dataTable);
                Clients[] cards = new Clients[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Clients
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].HeaderLabel.Text = "Клиент " + dataTable.Rows[i][0].ToString();
                    cards[i].SurnameField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].MiddlenameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].MobPhoneField.Text = dataTable.Rows[i][5].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][4].ToString();
                    cards[i].Parent = ClientsPanel;
                    cards[i].Name = "ClientCard";
                }
            }
        }

        public void LoadStaff(string query)
        {
            RestartDGV();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGStaff(dataTable);
                Staff[] cards = new Staff[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Staff
                    {
                        ID = (int)dataTable.Rows[i][0]
                    };
                    cards[i].SurnameField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].MiddlenameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].DatePicker.Text = dataTable.Rows[i][4].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][5].ToString();
                    cards[i].MobPhoneField.Text = dataTable.Rows[i][6].ToString();
                    cards[i].PassportField.Text = dataTable.Rows[i][7].ToString();
                    cards[i].EmailField.Text = dataTable.Rows[i][8].ToString();
                    cards[i].HiringStatusField.Text = dataTable.Rows[i][9].ToString();
                    cards[i].PositionField.Text = dataTable.Rows[i][10].ToString();
                    cards[i].Parent = StaffPanel;
                    cards[i].Name = "SotrudCard";
                }
            }
        }

        public void LoadDelivery(string query)
        {
            RestartDGV();
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                DGDelivery(dataTable);
                Delivery[] cards = new Delivery[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = new Delivery()
                    {
                        ID = (int)dataTable.Rows[i][7]
                    };
                    cards[i].HeaderLabel.Text = "Доставка " + dataTable.Rows[i][7].ToString();
                    cards[i].SurnameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][4].ToString();
                    cards[i].DateField.Text = dataTable.Rows[i][6].ToString();
                    cards[i].LeadTimeField.Text = dataTable.Rows[i][5].ToString();
                    cards[i].Parent = DeliveryPanel;
                    cards[i].Name = "DeliveryCard";
                }
            }
        }

        //Updating the displaying data in UserControls
        public void RefreshDish()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryDish, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = DishesPanel.Controls.Find("DishCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Dish newCard = new Dish
                        {
                            Name = "DishCard",
                            Parent = DishesPanel
                        };
                        DishesPanel.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        DishesPanel.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Dish[] cards = new Dish[cc.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Dish;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].NameDishField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].RecipeField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].WeightField.Text = dataTable.Rows[i][3].ToString() + dataTable.Rows[i][10].ToString();
                    cards[i].PriceField.Text = dataTable.Rows[i][4].ToString() + " BYN";
                    cards[i].pictureDish.Image = Image.FromFile(dataTable.Rows[i][5].ToString());
                }
            }
        }

        public void RefreshOrder()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryOrders, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = OrdersPanel.Controls.Find("OrderCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Orders newCard = new Orders
                        {
                            Name = "OrderCard",
                            Parent = OrdersPanel
                        };
                        OrdersPanel.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        OrdersPanel.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Orders[] cards = new Orders[dataTable.Rows.Count];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Orders;
                    cards[i].ID = (int)dataTable.Rows[i][5];
                    cards[i].HeaderLabel.Text = "Заказ " + dataTable.Rows[i][5].ToString();
                    //Клиент
                    cards[i].SurnameClientField.Text = dataTable.Rows[i][11].ToString();
                    cards[i].NameClientField.Text = dataTable.Rows[i][12].ToString();
                    //Сотрудник
                    cards[i].SurnameStaffField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].NameStaffField.Text = dataTable.Rows[i][3].ToString();
                    //Заказ
                    cards[i].DatePicker.Text = dataTable.Rows[i][6].ToString();
                    cards[i].NameDishField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].PriceField.Text = dataTable.Rows[i][14].ToString() + "BYN";
                    cards[i].WeightField.Text = dataTable.Rows[i][21].ToString() + dataTable.Rows[i][19].ToString();
                    cards[i].CountField.Text = dataTable.Rows[i][7].ToString();
                    cards[i].WayOfReceptionField.Text = dataTable.Rows[i][9].ToString();
                    cards[i].LeadTimeField.Text = dataTable.Rows[i][22].ToString();
                    cards[i].Parent = OrdersPanel;
                    cards[i].Name = "OrderCard";
                }
            }
        }

        public void RefreshClient()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryClients, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] cc;
                do
                {
                    cc = ClientsPanel.Controls.Find("ClientCard", true);
                    if (cc.Length < dataTable.Rows.Count)
                    {
                        Clients newCard = new Clients
                        {
                            Name = "ClientCard",
                            Parent = ClientsPanel
                        };
                        ClientsPanel.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (cc.Length > dataTable.Rows.Count)
                        ClientsPanel.Controls.RemoveAt(0);
                } while (cc.Length != dataTable.Rows.Count);
                Clients[] cards = new Clients[cc.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = cc[i] as Clients;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].HeaderLabel.Text = "Клиент " + dataTable.Rows[i][0].ToString();
                    cards[i].SurnameField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].MiddlenameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].MobPhoneField.Text = dataTable.Rows[i][4].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][5].ToString();
                }
            }
        }

        public void RefreshStaff()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryStaff, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] сс;
                do
                {
                    сс = StaffPanel.Controls.Find("SotrudCard", true);
                    if (сс.Length < dataTable.Rows.Count)
                    {
                        Staff newCard = new Staff
                        {
                            Name = "SotrudCard",
                            Parent = StaffPanel
                        };
                        StaffPanel.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (сс.Length > dataTable.Rows.Count)
                        StaffPanel.Controls.RemoveAt(0);
                } while (сс.Length != dataTable.Rows.Count);
                Staff[] cards = new Staff[сс.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = сс[i] as Staff;
                    cards[i].ID = (int)dataTable.Rows[i][0];
                    cards[i].SurnameField.Text = dataTable.Rows[i][1].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].MiddlenameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].DatePicker.Text = dataTable.Rows[i][4].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][5].ToString();
                    cards[i].MobPhoneField.Text = dataTable.Rows[i][6].ToString();
                    cards[i].PassportField.Text = dataTable.Rows[i][7].ToString();
                    cards[i].EmailField.Text = dataTable.Rows[i][8].ToString();
                    cards[i].HiringStatusField.Text = dataTable.Rows[i][9].ToString();
                    cards[i].PositionField.Text = dataTable.Rows[i][10].ToString();
                }
            }
        }

        public void RefreshDelivery()
        {
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryDelivery, connectionString))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Control[] сс;
                do
                {
                    сс = DeliveryPanel.Controls.Find("DeliveryCard", true);
                    if (сс.Length < dataTable.Rows.Count)
                    {
                        Delivery newCard = new Delivery
                        {
                            Name = "DeliveryCard",
                            Parent = DeliveryPanel
                        };
                        DeliveryPanel.Controls.SetChildIndex(newCard, 0);
                    }
                    else if (сс.Length > dataTable.Rows.Count)
                        DeliveryPanel.Controls.RemoveAt(0);
                } while (сс.Length != dataTable.Rows.Count);
                Delivery[] cards = new Delivery[сс.Length];
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = сс[i] as Delivery;
                    cards[i].ID = (int)dataTable.Rows[i][7];
                    cards[i].HeaderLabel.Text = "Доставка " + dataTable.Rows[i][7].ToString();
                    cards[i].SurnameField.Text = dataTable.Rows[i][2].ToString();
                    cards[i].NameField.Text = dataTable.Rows[i][3].ToString();
                    cards[i].AdressField.Text = dataTable.Rows[i][4].ToString();
                    cards[i].DateField.Text = dataTable.Rows[i][6].ToString();
                    cards[i].LeadTimeField.Text = dataTable.Rows[i][5].ToString();
                }
            }
        }

        private void DishShowButton_Click(object sender, EventArgs e)
        {
            ShowHideDatePicker(false);
            DishesPanel.Controls.Clear();
            SidePanel.Height = DishShowButton.Height;
            SidePanel.Top = DishShowButton.Top;
            LoadDish(QueryDish);
            Pages.SelectedTab = Dish;
        }

        private void OrdersShowButton_Click(object sender, EventArgs e)
        {
            ShowHideDatePicker(true);
            OrdersPanel.Controls.Clear();
            SidePanel.Height = OrdersShowButton.Height;
            SidePanel.Top = OrdersShowButton.Top;
            LoadOrders(QueryOrders);
            Pages.SelectedTab = Orders;
        }

        private void ClientsShowButton_Click(object sender, EventArgs e)
        {
            ShowHideDatePicker(false);
            ClientsPanel.Controls.Clear();
            SidePanel.Height = ClientsShowButton.Height;
            SidePanel.Top = ClientsShowButton.Top;
            LoadClients(QueryClients);
            Pages.SelectedTab = Clients;
        }

        private void StaffShowButton_Click(object sender, EventArgs e)
        {
            ShowHideDatePicker(true);
            StaffPanel.Controls.Clear();
            SidePanel.Height = StaffShowButton.Height;
            SidePanel.Top = StaffShowButton.Top;
            LoadStaff(QueryStaff);
            Pages.SelectedTab = Staff;
        }

        private void DeliveryShowButton_Click(object sender, EventArgs e)
        {
            ShowHideDatePicker(true);
            DeliveryPanel.Controls.Clear();
            SidePanel.Height = DeliveryShowButton.Height;
            SidePanel.Top = DeliveryShowButton.Top;
            LoadDelivery(QueryDelivery);
            Pages.SelectedTab = Delivery;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справки еще нет(");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pages.SelectedTab = Dish;
            LoadDish(QueryDish);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddDishButton_Click(object sender, EventArgs e)
        {
            DishAdd dishAdd = new DishAdd();
            dishAdd.Show();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            ClientAdd clientAdd = new ClientAdd();
            clientAdd.Show();
        }

        private void AddStaffButton_Click(object sender, EventArgs e)
        {
            StaffAdd staffAdd = new StaffAdd();
            staffAdd.Show();
        }

        private void AddDeliveryButton_Click(object sender, EventArgs e)
        {
            DeliveryAdd deliveryAdd = new DeliveryAdd();
            deliveryAdd.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SearchField.Text))
                MessageBox.Show("Заполните поле поиска!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (Pages.SelectedTab == Dish)
                {
                    DishesPanel.Controls.Clear();
                    LoadDish(QueryDish + "AND Name_Dish LIKE '%" + SearchField.Text + "'");
                }

                if (Pages.SelectedTab == Orders)
                {
                    OrdersPanel.Controls.Clear();
                    LoadOrders(QueryOrders + "AND (Orders.ID_Order Like '%" + SearchField.Text + "' " +
                                             "OR Staff.Surname_Staff LIKE '%" + SearchField.Text + "') ");
                }

                if (Pages.SelectedTab == Clients)
                {
                    ClientsPanel.Controls.Clear();
                    LoadClients(QueryClients + "WHERE Surname_Client LIKE '%" + SearchField.Text + "'");
                }

                if (Pages.SelectedTab == Staff)
                {
                    StaffPanel.Controls.Clear();
                    LoadStaff(QueryStaff + "AND Surname_Staff LIKE '%" + SearchField.Text + "'");
                }

                if (Pages.SelectedTab == Delivery)
                {
                    DeliveryPanel.Controls.Clear();
                    LoadDelivery(QueryDelivery + " AND (Delivery.ID_Delivery LIKE '%" + SearchField.Text + "' " +
                                                 " OR Staff.Surname_Staff LIKE '%" + SearchField.Text + "')");
                }
            }
        }

        private void SearchDateButton_Click(object sender, EventArgs e)
        {
            if (Pages.SelectedTab == Orders)
            {
                OrdersPanel.Controls.Clear();
                LoadOrders(QueryOrders + "AND " + "Orders.Date_Order BETWEEN " + "#" + DatePicker1.Text + "#" + " AND " + "#" + DatePicker2.Text + "#" + "OR " +
                                         "Orders.Date_Order BETWEEN " + "#" + DatePicker2.Text + "#" + " AND " + "#" + DatePicker1.Text + "#" + ") " );
            }

            if (Pages.SelectedTab == Staff)
            {
                StaffPanel.Controls.Clear();
                LoadStaff(QueryStaff + "AND " + "Staff.Date_Of_Employment_Staff BETWEEN " + "#" + DatePicker1.Text + "#" + " AND " + "#" + DatePicker2.Text + "#" + "OR " + 
                                       "Staff.Date_Of_Employment_Staff BETWEEN " + "#" + DatePicker2.Text + "#" + " AND " + "#" + DatePicker1.Text + "#" + ") " );
            }

            if (Pages.SelectedTab == Delivery)
            {
                DeliveryPanel.Controls.Clear();
                LoadDelivery(QueryDelivery + "AND " + "Orders.Date_Order BETWEEN " + "#" + DatePicker1.Text + "#" + " AND " + "#" + DatePicker2.Text + "#" + "OR " +
                                             "Orders.Date_Order BETWEEN " + "#" + DatePicker2.Text + "#" + " AND " + "#" + DatePicker1.Text + "#" + ") " );
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Report.Clear();
            RestartDGV();

            if (Pages.SelectedTab == Dish)
            {
                Report.AddString("<Center>Отчет по имеющимся блюдам</Center>");
                Report.AddHorizontalRule();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryDish, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGDish(dataTable);
                }
            }

            if (Pages.SelectedTab == Orders)
            {
                Report.AddString("<Center>Отчет по имеющимся заказам</Center>");
                Report.AddHorizontalRule();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryOrders, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGOrders(dataTable);
                }
            }

            if (Pages.SelectedTab == Clients)
            {
                Report.AddString("<Center>Отчет по имеющимся клиентам</Center>");
                Report.AddHorizontalRule();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryClients, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGClients(dataTable);
                }
            }

            if (Pages.SelectedTab == Staff)
            {
                Report.AddString("<Center>Отчет по имеющимся сотрудникам</Center>");
                Report.AddHorizontalRule();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryStaff, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGStaff(dataTable);
                }
            }

            if (Pages.SelectedTab == Delivery)
            {
                Report.AddString("<Center>Отчет по имеющимся доставкам</Center>");
                Report.AddHorizontalRule();
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(QueryDelivery, connectionString))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    DGDelivery(dataTable);
                }
            }

            Report.AddDatagridView(DGView);
            Report.ShowPrintPreviewDialog();
        }
    }
}