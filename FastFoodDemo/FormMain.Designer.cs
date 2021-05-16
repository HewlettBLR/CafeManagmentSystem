namespace FastFoodDemo
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datePickerGraphic = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.DeliveryShowButton = new System.Windows.Forms.Button();
            this.StaffShowButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ClientsShowButton = new System.Windows.Forms.Button();
            this.OrdersShowButton = new System.Windows.Forms.Button();
            this.ButtonHelp = new System.Windows.Forms.Button();
            this.DishShowButton = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.SearchField = new Bunifu.UI.WinForms.BunifuTextBox();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SearchButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SubHeaderLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pages = new Bunifu.UI.WinForms.BunifuPages();
            this.Clients = new System.Windows.Forms.TabPage();
            this.ClientsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Staff = new System.Windows.Forms.TabPage();
            this.StaffPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Dish = new System.Windows.Forms.TabPage();
            this.DishesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Orders = new System.Windows.Forms.TabPage();
            this.OrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Delivery = new System.Windows.Forms.TabPage();
            this.DeliveryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BeginLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EndLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ChoiceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Report = new Bunifu.Reports.BunifuReports(this.components);
            this.DGView = new System.Windows.Forms.DataGridView();
            this.ReportButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.SearchDateButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.DatePicker2 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.DatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.AddDeliveryButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.AddClientButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.AddDishButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.AddStaffButton = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.DragPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pages.SuspendLayout();
            this.Clients.SuspendLayout();
            this.Staff.SuspendLayout();
            this.Dish.SuspendLayout();
            this.Orders.SuspendLayout();
            this.Delivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.datePickerGraphic);
            this.panel1.Controls.Add(this.DeliveryShowButton);
            this.panel1.Controls.Add(this.StaffShowButton);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.ClientsShowButton);
            this.panel1.Controls.Add(this.OrdersShowButton);
            this.panel1.Controls.Add(this.ButtonHelp);
            this.panel1.Controls.Add(this.DishShowButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 599);
            this.panel1.TabIndex = 0;
            // 
            // datePickerGraphic
            // 
            this.datePickerGraphic.BackColor = System.Drawing.Color.Transparent;
            this.datePickerGraphic.BorderRadius = 0;
            this.datePickerGraphic.CalendarFont = new System.Drawing.Font("Century Gothic", 12F);
            this.datePickerGraphic.Checked = false;
            this.datePickerGraphic.Color = System.Drawing.Color.Transparent;
            this.datePickerGraphic.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.datePickerGraphic.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Center;
            this.datePickerGraphic.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.datePickerGraphic.DisplayWeekNumbers = true;
            this.datePickerGraphic.DPHeight = 0;
            this.datePickerGraphic.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePickerGraphic.FillDatePicker = false;
            this.datePickerGraphic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datePickerGraphic.ForeColor = System.Drawing.Color.White;
            this.datePickerGraphic.Icon = ((System.Drawing.Image)(resources.GetObject("datePickerGraphic.Icon")));
            this.datePickerGraphic.IconColor = System.Drawing.Color.Transparent;
            this.datePickerGraphic.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.None;
            this.datePickerGraphic.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.datePickerGraphic.LeftTextMargin = 50;
            this.datePickerGraphic.Location = new System.Drawing.Point(1, 53);
            this.datePickerGraphic.MinimumSize = new System.Drawing.Size(200, 32);
            this.datePickerGraphic.Name = "datePickerGraphic";
            this.datePickerGraphic.Size = new System.Drawing.Size(200, 32);
            this.datePickerGraphic.TabIndex = 6;
            this.datePickerGraphic.TabStop = false;
            this.datePickerGraphic.Value = new System.DateTime(2021, 4, 17, 4, 40, 0, 0);
            // 
            // DeliveryShowButton
            // 
            this.DeliveryShowButton.FlatAppearance.BorderSize = 0;
            this.DeliveryShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryShowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryShowButton.ForeColor = System.Drawing.Color.White;
            this.DeliveryShowButton.Image = global::FastFoodDemo.Properties.Resources.delivery_25px2;
            this.DeliveryShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryShowButton.Location = new System.Drawing.Point(12, 352);
            this.DeliveryShowButton.Name = "DeliveryShowButton";
            this.DeliveryShowButton.Size = new System.Drawing.Size(197, 54);
            this.DeliveryShowButton.TabIndex = 94;
            this.DeliveryShowButton.Text = "       Доставка";
            this.DeliveryShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeliveryShowButton.UseCompatibleTextRendering = true;
            this.DeliveryShowButton.UseVisualStyleBackColor = true;
            this.DeliveryShowButton.Click += new System.EventHandler(this.DeliveryShowButton_Click);
            // 
            // StaffShowButton
            // 
            this.StaffShowButton.FlatAppearance.BorderSize = 0;
            this.StaffShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffShowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffShowButton.ForeColor = System.Drawing.Color.White;
            this.StaffShowButton.Image = global::FastFoodDemo.Properties.Resources.name_tag_25px;
            this.StaffShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StaffShowButton.Location = new System.Drawing.Point(12, 292);
            this.StaffShowButton.Name = "StaffShowButton";
            this.StaffShowButton.Size = new System.Drawing.Size(197, 54);
            this.StaffShowButton.TabIndex = 93;
            this.StaffShowButton.Text = "       Сотрудники";
            this.StaffShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StaffShowButton.UseCompatibleTextRendering = true;
            this.StaffShowButton.UseVisualStyleBackColor = true;
            this.StaffShowButton.Click += new System.EventHandler(this.StaffShowButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 112);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 4;
            // 
            // ClientsShowButton
            // 
            this.ClientsShowButton.FlatAppearance.BorderSize = 0;
            this.ClientsShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsShowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsShowButton.ForeColor = System.Drawing.Color.White;
            this.ClientsShowButton.Image = ((System.Drawing.Image)(resources.GetObject("ClientsShowButton.Image")));
            this.ClientsShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientsShowButton.Location = new System.Drawing.Point(12, 232);
            this.ClientsShowButton.Name = "ClientsShowButton";
            this.ClientsShowButton.Size = new System.Drawing.Size(197, 54);
            this.ClientsShowButton.TabIndex = 92;
            this.ClientsShowButton.Text = "       Клиенты";
            this.ClientsShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientsShowButton.UseVisualStyleBackColor = true;
            this.ClientsShowButton.Click += new System.EventHandler(this.ClientsShowButton_Click);
            // 
            // OrdersShowButton
            // 
            this.OrdersShowButton.FlatAppearance.BorderSize = 0;
            this.OrdersShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersShowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersShowButton.ForeColor = System.Drawing.Color.White;
            this.OrdersShowButton.Image = global::FastFoodDemo.Properties.Resources.order_25px;
            this.OrdersShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersShowButton.Location = new System.Drawing.Point(12, 172);
            this.OrdersShowButton.Name = "OrdersShowButton";
            this.OrdersShowButton.Size = new System.Drawing.Size(197, 54);
            this.OrdersShowButton.TabIndex = 91;
            this.OrdersShowButton.Text = "       Заказы";
            this.OrdersShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrdersShowButton.UseVisualStyleBackColor = true;
            this.OrdersShowButton.Click += new System.EventHandler(this.OrdersShowButton_Click);
            // 
            // ButtonHelp
            // 
            this.ButtonHelp.FlatAppearance.BorderSize = 0;
            this.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHelp.ForeColor = System.Drawing.Color.White;
            this.ButtonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHelp.Location = new System.Drawing.Point(0, 565);
            this.ButtonHelp.Name = "ButtonHelp";
            this.ButtonHelp.Size = new System.Drawing.Size(36, 34);
            this.ButtonHelp.TabIndex = 4;
            this.ButtonHelp.Text = "?";
            this.ButtonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonHelp.UseVisualStyleBackColor = true;
            this.ButtonHelp.Click += new System.EventHandler(this.ButtonHelp_Click);
            // 
            // DishShowButton
            // 
            this.DishShowButton.FlatAppearance.BorderSize = 0;
            this.DishShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DishShowButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DishShowButton.ForeColor = System.Drawing.Color.White;
            this.DishShowButton.Image = ((System.Drawing.Image)(resources.GetObject("DishShowButton.Image")));
            this.DishShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DishShowButton.Location = new System.Drawing.Point(12, 112);
            this.DishShowButton.Name = "DishShowButton";
            this.DishShowButton.Size = new System.Drawing.Size(197, 54);
            this.DishShowButton.TabIndex = 90;
            this.DishShowButton.Text = "       Что покушать?";
            this.DishShowButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DishShowButton.UseVisualStyleBackColor = true;
            this.DishShowButton.Click += new System.EventHandler(this.DishShowButton_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.DragPanel.Controls.Add(this.SearchField);
            this.DragPanel.Controls.Add(this.ExitButton);
            this.DragPanel.Controls.Add(this.SearchButton);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DragPanel.Location = new System.Drawing.Point(204, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(753, 48);
            this.DragPanel.TabIndex = 1;
            // 
            // SearchField
            // 
            this.SearchField.AcceptsReturn = false;
            this.SearchField.AcceptsTab = false;
            this.SearchField.AnimationSpeed = 200;
            this.SearchField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchField.BackColor = System.Drawing.Color.White;
            this.SearchField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchField.BackgroundImage")));
            this.SearchField.BorderColorActive = System.Drawing.Color.Maroon;
            this.SearchField.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SearchField.BorderColorHover = System.Drawing.Color.IndianRed;
            this.SearchField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SearchField.BorderRadius = 1;
            this.SearchField.BorderThickness = 0;
            this.SearchField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.DefaultText = "";
            this.SearchField.FillColor = System.Drawing.Color.White;
            this.SearchField.HideSelection = true;
            this.SearchField.IconLeft = null;
            this.SearchField.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.IconPadding = 10;
            this.SearchField.IconRight = null;
            this.SearchField.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.Lines = new string[0];
            this.SearchField.Location = new System.Drawing.Point(317, 6);
            this.SearchField.MaxLength = 32767;
            this.SearchField.MinimumSize = new System.Drawing.Size(1, 1);
            this.SearchField.Modified = false;
            this.SearchField.Multiline = false;
            this.SearchField.Name = "SearchField";
            stateProperties5.BorderColor = System.Drawing.Color.Maroon;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchField.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchField.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.IndianRed;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchField.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SearchField.OnIdleState = stateProperties8;
            this.SearchField.Padding = new System.Windows.Forms.Padding(3);
            this.SearchField.PasswordChar = '\0';
            this.SearchField.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.SearchField.PlaceholderText = "Поле поиска";
            this.SearchField.ReadOnly = false;
            this.SearchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchField.SelectedText = "";
            this.SearchField.SelectionLength = 0;
            this.SearchField.SelectionStart = 0;
            this.SearchField.ShortcutsEnabled = true;
            this.SearchField.Size = new System.Drawing.Size(178, 36);
            this.SearchField.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.SearchField.TabIndex = 100;
            this.SearchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchField.TextMarginBottom = 0;
            this.SearchField.TextMarginLeft = 0;
            this.SearchField.TextMarginTop = 0;
            this.SearchField.TextPlaceholder = "Поле поиска";
            this.SearchField.UseSystemPasswordChar = false;
            this.SearchField.WordWrap = true;
            // 
            // ExitButton
            // 
            this.ExitButton.ActiveImage = global::FastFoodDemo.Properties.Resources.icons8_удалить_25;
            this.ExitButton.AllowAnimations = true;
            this.ExitButton.AllowBuffering = false;
            this.ExitButton.AllowToggling = false;
            this.ExitButton.AllowZooming = true;
            this.ExitButton.AllowZoomingOnFocus = false;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.ErrorImage = null;
            this.ExitButton.FadeWhenInactive = false;
            this.ExitButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ExitButton.Image = global::FastFoodDemo.Properties.Resources.icons8_удалить_25;
            this.ExitButton.ImageActive = global::FastFoodDemo.Properties.Resources.icons8_удалить_25;
            this.ExitButton.ImageLocation = null;
            this.ExitButton.ImageMargin = 10;
            this.ExitButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ExitButton.InitialImage = null;
            this.ExitButton.Location = new System.Drawing.Point(709, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Rotation = 0;
            this.ExitButton.ShowActiveImage = true;
            this.ExitButton.ShowCursorChanges = true;
            this.ExitButton.ShowImageBorders = true;
            this.ExitButton.ShowSizeMarkers = false;
            this.ExitButton.Size = new System.Drawing.Size(40, 40);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.ToolTipText = "";
            this.ExitButton.WaitOnLoad = false;
            this.ExitButton.Zoom = 10;
            this.ExitButton.ZoomSpeed = 10;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.ActiveImage = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchButton.AllowAnimations = true;
            this.SearchButton.AllowBuffering = false;
            this.SearchButton.AllowToggling = false;
            this.SearchButton.AllowZooming = true;
            this.SearchButton.AllowZoomingOnFocus = false;
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.ErrorImage")));
            this.SearchButton.FadeWhenInactive = false;
            this.SearchButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.SearchButton.Image = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchButton.ImageActive = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchButton.ImageLocation = null;
            this.SearchButton.ImageMargin = 5;
            this.SearchButton.ImageSize = new System.Drawing.Size(32, 32);
            this.SearchButton.ImageZoomSize = new System.Drawing.Size(37, 37);
            this.SearchButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.InitialImage")));
            this.SearchButton.Location = new System.Drawing.Point(505, 6);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Rotation = 0;
            this.SearchButton.ShowActiveImage = true;
            this.SearchButton.ShowCursorChanges = true;
            this.SearchButton.ShowImageBorders = true;
            this.SearchButton.ShowSizeMarkers = false;
            this.SearchButton.Size = new System.Drawing.Size(37, 37);
            this.SearchButton.TabIndex = 101;
            this.SearchButton.ToolTipText = "Добавление нового блюда";
            this.SearchButton.WaitOnLoad = false;
            this.SearchButton.Zoom = 5;
            this.SearchButton.ZoomSpeed = 10;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.SubHeaderLabel);
            this.panel3.Controls.Add(this.HeaderLabel);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 2;
            // 
            // SubHeaderLabel
            // 
            this.SubHeaderLabel.AutoSize = true;
            this.SubHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.SubHeaderLabel.Location = new System.Drawing.Point(32, 112);
            this.SubHeaderLabel.Name = "SubHeaderLabel";
            this.SubHeaderLabel.Size = new System.Drawing.Size(47, 17);
            this.SubHeaderLabel.TabIndex = 3;
            this.SubHeaderLabel.Text = "Кафе";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(11, 90);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(78, 19);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "BestCoffe";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pages
            // 
            this.Pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Pages.AllowTransitions = false;
            this.Pages.Controls.Add(this.Clients);
            this.Pages.Controls.Add(this.Staff);
            this.Pages.Controls.Add(this.Dish);
            this.Pages.Controls.Add(this.Orders);
            this.Pages.Controls.Add(this.Delivery);
            this.Pages.Location = new System.Drawing.Point(204, 149);
            this.Pages.Multiline = true;
            this.Pages.Name = "Pages";
            this.Pages.Page = this.Delivery;
            this.Pages.PageIndex = 4;
            this.Pages.PageName = "Delivery";
            this.Pages.PageTitle = "Доставка";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(753, 450);
            this.Pages.TabIndex = 8;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Pages.Transition = animation2;
            this.Pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // Clients
            // 
            this.Clients.Controls.Add(this.ClientsPanel);
            this.Clients.Location = new System.Drawing.Point(4, 4);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(745, 424);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // ClientsPanel
            // 
            this.ClientsPanel.AutoScroll = true;
            this.ClientsPanel.BackColor = System.Drawing.Color.Snow;
            this.ClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsPanel.Location = new System.Drawing.Point(3, 3);
            this.ClientsPanel.Name = "ClientsPanel";
            this.ClientsPanel.Size = new System.Drawing.Size(739, 418);
            this.ClientsPanel.TabIndex = 0;
            // 
            // Staff
            // 
            this.Staff.Controls.Add(this.StaffPanel);
            this.Staff.Location = new System.Drawing.Point(4, 4);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(745, 424);
            this.Staff.TabIndex = 2;
            this.Staff.Text = "Сотрудники";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // StaffPanel
            // 
            this.StaffPanel.AutoScroll = true;
            this.StaffPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPanel.Location = new System.Drawing.Point(0, 0);
            this.StaffPanel.Name = "StaffPanel";
            this.StaffPanel.Size = new System.Drawing.Size(745, 424);
            this.StaffPanel.TabIndex = 1;
            // 
            // Dish
            // 
            this.Dish.Controls.Add(this.DishesPanel);
            this.Dish.Location = new System.Drawing.Point(4, 4);
            this.Dish.Name = "Dish";
            this.Dish.Padding = new System.Windows.Forms.Padding(3);
            this.Dish.Size = new System.Drawing.Size(745, 424);
            this.Dish.TabIndex = 0;
            this.Dish.Text = "Еда";
            this.Dish.UseVisualStyleBackColor = true;
            // 
            // DishesPanel
            // 
            this.DishesPanel.AutoScroll = true;
            this.DishesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DishesPanel.Location = new System.Drawing.Point(3, 3);
            this.DishesPanel.Name = "DishesPanel";
            this.DishesPanel.Size = new System.Drawing.Size(739, 418);
            this.DishesPanel.TabIndex = 2;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.OrdersPanel);
            this.Orders.Location = new System.Drawing.Point(4, 4);
            this.Orders.Name = "Orders";
            this.Orders.Size = new System.Drawing.Size(745, 424);
            this.Orders.TabIndex = 3;
            this.Orders.Text = "Заказы";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // OrdersPanel
            // 
            this.OrdersPanel.AutoScroll = true;
            this.OrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersPanel.Location = new System.Drawing.Point(0, 0);
            this.OrdersPanel.Name = "OrdersPanel";
            this.OrdersPanel.Size = new System.Drawing.Size(745, 424);
            this.OrdersPanel.TabIndex = 3;
            // 
            // Delivery
            // 
            this.Delivery.Controls.Add(this.DeliveryPanel);
            this.Delivery.Location = new System.Drawing.Point(4, 4);
            this.Delivery.Name = "Delivery";
            this.Delivery.Size = new System.Drawing.Size(745, 424);
            this.Delivery.TabIndex = 4;
            this.Delivery.Text = "Доставка";
            this.Delivery.UseVisualStyleBackColor = true;
            // 
            // DeliveryPanel
            // 
            this.DeliveryPanel.AutoScroll = true;
            this.DeliveryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeliveryPanel.Location = new System.Drawing.Point(0, 0);
            this.DeliveryPanel.Name = "DeliveryPanel";
            this.DeliveryPanel.Size = new System.Drawing.Size(745, 424);
            this.DeliveryPanel.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BeginLabel
            // 
            this.BeginLabel.AutoSize = true;
            this.BeginLabel.BackColor = System.Drawing.Color.Transparent;
            this.BeginLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginLabel.ForeColor = System.Drawing.Color.Black;
            this.BeginLabel.Location = new System.Drawing.Point(526, 90);
            this.BeginLabel.MaximumSize = new System.Drawing.Size(285, 35);
            this.BeginLabel.MinimumSize = new System.Drawing.Size(20, 20);
            this.BeginLabel.Name = "BeginLabel";
            this.BeginLabel.Size = new System.Drawing.Size(70, 20);
            this.BeginLabel.TabIndex = 105;
            this.BeginLabel.Text = "Начало";
            this.BeginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BeginLabel.Visible = false;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndLabel.ForeColor = System.Drawing.Color.Black;
            this.EndLabel.Location = new System.Drawing.Point(629, 89);
            this.EndLabel.MaximumSize = new System.Drawing.Size(285, 35);
            this.EndLabel.MinimumSize = new System.Drawing.Size(20, 20);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(60, 20);
            this.EndLabel.TabIndex = 106;
            this.EndLabel.Text = "Конец";
            this.EndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EndLabel.Visible = false;
            // 
            // ChoiceLabel
            // 
            this.ChoiceLabel.AutoSize = true;
            this.ChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChoiceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceLabel.ForeColor = System.Drawing.Color.Black;
            this.ChoiceLabel.Location = new System.Drawing.Point(590, 60);
            this.ChoiceLabel.MaximumSize = new System.Drawing.Size(285, 35);
            this.ChoiceLabel.MinimumSize = new System.Drawing.Size(38, 19);
            this.ChoiceLabel.Name = "ChoiceLabel";
            this.ChoiceLabel.Size = new System.Drawing.Size(38, 19);
            this.ChoiceLabel.TabIndex = 104;
            this.ChoiceLabel.Text = "или";
            this.ChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChoiceLabel.Visible = false;
            // 
            // Report
            // 
            this.Report.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Report.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.Report.HeaderBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(183)))), ((int)(((byte)(197)))));
            this.Report.HeaderFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.Report.HeaderGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.Report.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Report.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.Report.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // DGView
            // 
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Location = new System.Drawing.Point(483, 112);
            this.DGView.Name = "DGView";
            this.DGView.Size = new System.Drawing.Size(21, 17);
            this.DGView.TabIndex = 107;
            this.DGView.Visible = false;
            // 
            // ReportButton
            // 
            this.ReportButton.ActiveImage = global::FastFoodDemo.Properties.Resources.delivery_96px;
            this.ReportButton.AllowAnimations = true;
            this.ReportButton.AllowBuffering = false;
            this.ReportButton.AllowToggling = false;
            this.ReportButton.AllowZooming = true;
            this.ReportButton.AllowZoomingOnFocus = false;
            this.ReportButton.BackColor = System.Drawing.Color.Transparent;
            this.ReportButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ReportButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ReportButton.ErrorImage")));
            this.ReportButton.FadeWhenInactive = false;
            this.ReportButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.ReportButton.Image = global::FastFoodDemo.Properties.Resources.icons8_business_report_96px_1;
            this.ReportButton.ImageActive = global::FastFoodDemo.Properties.Resources.delivery_96px;
            this.ReportButton.ImageLocation = null;
            this.ReportButton.ImageMargin = 5;
            this.ReportButton.ImageSize = new System.Drawing.Size(35, 35);
            this.ReportButton.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.ReportButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("ReportButton.InitialImage")));
            this.ReportButton.Location = new System.Drawing.Point(464, 55);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Rotation = 0;
            this.ReportButton.ShowActiveImage = true;
            this.ReportButton.ShowCursorChanges = true;
            this.ReportButton.ShowImageBorders = true;
            this.ReportButton.ShowSizeMarkers = false;
            this.ReportButton.Size = new System.Drawing.Size(40, 40);
            this.ReportButton.TabIndex = 108;
            this.ReportButton.ToolTipText = "Отчет по отображенным данным";
            this.ReportButton.WaitOnLoad = false;
            this.ReportButton.Zoom = 5;
            this.ReportButton.ZoomSpeed = 10;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SearchDateButton
            // 
            this.SearchDateButton.ActiveImage = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchDateButton.AllowAnimations = true;
            this.SearchDateButton.AllowBuffering = false;
            this.SearchDateButton.AllowToggling = false;
            this.SearchDateButton.AllowZooming = true;
            this.SearchDateButton.AllowZoomingOnFocus = false;
            this.SearchDateButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchDateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchDateButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SearchDateButton.ErrorImage")));
            this.SearchDateButton.FadeWhenInactive = false;
            this.SearchDateButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.SearchDateButton.Image = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchDateButton.ImageActive = global::FastFoodDemo.Properties.Resources.search_96px;
            this.SearchDateButton.ImageLocation = null;
            this.SearchDateButton.ImageMargin = 5;
            this.SearchDateButton.ImageSize = new System.Drawing.Size(32, 32);
            this.SearchDateButton.ImageZoomSize = new System.Drawing.Size(37, 37);
            this.SearchDateButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("SearchDateButton.InitialImage")));
            this.SearchDateButton.Location = new System.Drawing.Point(709, 112);
            this.SearchDateButton.Name = "SearchDateButton";
            this.SearchDateButton.Rotation = 0;
            this.SearchDateButton.ShowActiveImage = true;
            this.SearchDateButton.ShowCursorChanges = true;
            this.SearchDateButton.ShowImageBorders = true;
            this.SearchDateButton.ShowSizeMarkers = false;
            this.SearchDateButton.Size = new System.Drawing.Size(37, 37);
            this.SearchDateButton.TabIndex = 102;
            this.SearchDateButton.ToolTipText = "Добавление нового блюда";
            this.SearchDateButton.Visible = false;
            this.SearchDateButton.WaitOnLoad = false;
            this.SearchDateButton.Zoom = 5;
            this.SearchDateButton.ZoomSpeed = 10;
            this.SearchDateButton.Click += new System.EventHandler(this.SearchDateButton_Click);
            // 
            // DatePicker2
            // 
            this.DatePicker2.BackColor = System.Drawing.Color.White;
            this.DatePicker2.BorderRadius = 0;
            this.DatePicker2.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker2.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.DatePicker2.CustomFormat = "M/d/yyyy";
            this.DatePicker2.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker2.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Center;
            this.DatePicker2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker2.DisplayWeekNumbers = false;
            this.DatePicker2.DPHeight = 0;
            this.DatePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker2.FillDatePicker = false;
            this.DatePicker2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker2.ForeColor = System.Drawing.Color.Black;
            this.DatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker2.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker2.Icon")));
            this.DatePicker2.IconColor = System.Drawing.Color.Transparent;
            this.DatePicker2.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.None;
            this.DatePicker2.LeftTextMargin = 5;
            this.DatePicker2.Location = new System.Drawing.Point(620, 112);
            this.DatePicker2.MinimumSize = new System.Drawing.Size(84, 35);
            this.DatePicker2.Name = "DatePicker2";
            this.DatePicker2.Size = new System.Drawing.Size(84, 35);
            this.DatePicker2.TabIndex = 103;
            this.DatePicker2.Visible = false;
            // 
            // DatePicker1
            // 
            this.DatePicker1.BackColor = System.Drawing.Color.White;
            this.DatePicker1.BorderRadius = 0;
            this.DatePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker1.Color = System.Drawing.SystemColors.InactiveCaptionText;
            this.DatePicker1.CustomFormat = "M/d/yyyy";
            this.DatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Center;
            this.DatePicker1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker1.DisplayWeekNumbers = false;
            this.DatePicker1.DPHeight = 0;
            this.DatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker1.FillDatePicker = false;
            this.DatePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker1.ForeColor = System.Drawing.Color.Black;
            this.DatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker1.Icon")));
            this.DatePicker1.IconColor = System.Drawing.Color.Transparent;
            this.DatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.None;
            this.DatePicker1.LeftTextMargin = 5;
            this.DatePicker1.Location = new System.Drawing.Point(521, 112);
            this.DatePicker1.MinimumSize = new System.Drawing.Size(79, 35);
            this.DatePicker1.Name = "DatePicker1";
            this.DatePicker1.Size = new System.Drawing.Size(84, 35);
            this.DatePicker1.TabIndex = 102;
            this.DatePicker1.Visible = false;
            // 
            // AddDeliveryButton
            // 
            this.AddDeliveryButton.ActiveImage = global::FastFoodDemo.Properties.Resources.delivery_96px;
            this.AddDeliveryButton.AllowAnimations = true;
            this.AddDeliveryButton.AllowBuffering = false;
            this.AddDeliveryButton.AllowToggling = false;
            this.AddDeliveryButton.AllowZooming = true;
            this.AddDeliveryButton.AllowZoomingOnFocus = false;
            this.AddDeliveryButton.BackColor = System.Drawing.Color.Transparent;
            this.AddDeliveryButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddDeliveryButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AddDeliveryButton.ErrorImage")));
            this.AddDeliveryButton.FadeWhenInactive = false;
            this.AddDeliveryButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.AddDeliveryButton.Image = global::FastFoodDemo.Properties.Resources.delivery_96px;
            this.AddDeliveryButton.ImageActive = global::FastFoodDemo.Properties.Resources.delivery_96px;
            this.AddDeliveryButton.ImageLocation = null;
            this.AddDeliveryButton.ImageMargin = 5;
            this.AddDeliveryButton.ImageSize = new System.Drawing.Size(43, 43);
            this.AddDeliveryButton.ImageZoomSize = new System.Drawing.Size(48, 48);
            this.AddDeliveryButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddDeliveryButton.InitialImage")));
            this.AddDeliveryButton.Location = new System.Drawing.Point(410, 101);
            this.AddDeliveryButton.Name = "AddDeliveryButton";
            this.AddDeliveryButton.Rotation = 0;
            this.AddDeliveryButton.ShowActiveImage = true;
            this.AddDeliveryButton.ShowCursorChanges = true;
            this.AddDeliveryButton.ShowImageBorders = true;
            this.AddDeliveryButton.ShowSizeMarkers = false;
            this.AddDeliveryButton.Size = new System.Drawing.Size(48, 48);
            this.AddDeliveryButton.TabIndex = 98;
            this.AddDeliveryButton.ToolTipText = "Оформление доставки";
            this.AddDeliveryButton.WaitOnLoad = false;
            this.AddDeliveryButton.Zoom = 5;
            this.AddDeliveryButton.ZoomSpeed = 10;
            this.AddDeliveryButton.Click += new System.EventHandler(this.AddDeliveryButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.ActiveImage = global::FastFoodDemo.Properties.Resources.customer_96px;
            this.AddClientButton.AllowAnimations = true;
            this.AddClientButton.AllowBuffering = false;
            this.AddClientButton.AllowToggling = false;
            this.AddClientButton.AllowZooming = true;
            this.AddClientButton.AllowZoomingOnFocus = false;
            this.AddClientButton.BackColor = System.Drawing.Color.Transparent;
            this.AddClientButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddClientButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AddClientButton.ErrorImage")));
            this.AddClientButton.FadeWhenInactive = false;
            this.AddClientButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.AddClientButton.Image = global::FastFoodDemo.Properties.Resources.customer_96px;
            this.AddClientButton.ImageActive = global::FastFoodDemo.Properties.Resources.customer_96px;
            this.AddClientButton.ImageLocation = null;
            this.AddClientButton.ImageMargin = 5;
            this.AddClientButton.ImageSize = new System.Drawing.Size(43, 43);
            this.AddClientButton.ImageZoomSize = new System.Drawing.Size(48, 48);
            this.AddClientButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddClientButton.InitialImage")));
            this.AddClientButton.Location = new System.Drawing.Point(410, 55);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Rotation = 0;
            this.AddClientButton.ShowActiveImage = true;
            this.AddClientButton.ShowCursorChanges = true;
            this.AddClientButton.ShowImageBorders = true;
            this.AddClientButton.ShowSizeMarkers = false;
            this.AddClientButton.Size = new System.Drawing.Size(48, 48);
            this.AddClientButton.TabIndex = 97;
            this.AddClientButton.ToolTipText = "Добавление нового клиента";
            this.AddClientButton.WaitOnLoad = false;
            this.AddClientButton.Zoom = 5;
            this.AddClientButton.ZoomSpeed = 10;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // AddDishButton
            // 
            this.AddDishButton.ActiveImage = global::FastFoodDemo.Properties.Resources.icons8_настоящая_еда_для_еды_96;
            this.AddDishButton.AllowAnimations = true;
            this.AddDishButton.AllowBuffering = false;
            this.AddDishButton.AllowToggling = false;
            this.AddDishButton.AllowZooming = true;
            this.AddDishButton.AllowZoomingOnFocus = false;
            this.AddDishButton.BackColor = System.Drawing.Color.Transparent;
            this.AddDishButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddDishButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AddDishButton.ErrorImage")));
            this.AddDishButton.FadeWhenInactive = false;
            this.AddDishButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.AddDishButton.Image = global::FastFoodDemo.Properties.Resources.icons8_настоящая_еда_для_еды_96;
            this.AddDishButton.ImageActive = global::FastFoodDemo.Properties.Resources.icons8_настоящая_еда_для_еды_96;
            this.AddDishButton.ImageLocation = null;
            this.AddDishButton.ImageMargin = 5;
            this.AddDishButton.ImageSize = new System.Drawing.Size(43, 43);
            this.AddDishButton.ImageZoomSize = new System.Drawing.Size(48, 48);
            this.AddDishButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddDishButton.InitialImage")));
            this.AddDishButton.Location = new System.Drawing.Point(356, 101);
            this.AddDishButton.Name = "AddDishButton";
            this.AddDishButton.Rotation = 0;
            this.AddDishButton.ShowActiveImage = true;
            this.AddDishButton.ShowCursorChanges = true;
            this.AddDishButton.ShowImageBorders = true;
            this.AddDishButton.ShowSizeMarkers = false;
            this.AddDishButton.Size = new System.Drawing.Size(48, 48);
            this.AddDishButton.TabIndex = 96;
            this.AddDishButton.ToolTipText = "Добавление нового блюда";
            this.AddDishButton.WaitOnLoad = false;
            this.AddDishButton.Zoom = 5;
            this.AddDishButton.ZoomSpeed = 10;
            this.AddDishButton.Click += new System.EventHandler(this.AddDishButton_Click);
            // 
            // AddStaffButton
            // 
            this.AddStaffButton.ActiveImage = global::FastFoodDemo.Properties.Resources.icons8_идентифицированный_пользователь_мужчина_96;
            this.AddStaffButton.AllowAnimations = true;
            this.AddStaffButton.AllowBuffering = false;
            this.AddStaffButton.AllowToggling = false;
            this.AddStaffButton.AllowZooming = true;
            this.AddStaffButton.AllowZoomingOnFocus = true;
            this.AddStaffButton.BackColor = System.Drawing.Color.Transparent;
            this.AddStaffButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddStaffButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AddStaffButton.ErrorImage")));
            this.AddStaffButton.FadeWhenInactive = false;
            this.AddStaffButton.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.AddStaffButton.Image = global::FastFoodDemo.Properties.Resources.icons8_идентифицированный_пользователь_мужчина_96;
            this.AddStaffButton.ImageActive = global::FastFoodDemo.Properties.Resources.icons8_идентифицированный_пользователь_мужчина_96;
            this.AddStaffButton.ImageLocation = null;
            this.AddStaffButton.ImageMargin = 5;
            this.AddStaffButton.ImageSize = new System.Drawing.Size(43, 43);
            this.AddStaffButton.ImageZoomSize = new System.Drawing.Size(48, 48);
            this.AddStaffButton.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddStaffButton.InitialImage")));
            this.AddStaffButton.Location = new System.Drawing.Point(356, 53);
            this.AddStaffButton.Name = "AddStaffButton";
            this.AddStaffButton.Rotation = 0;
            this.AddStaffButton.ShowActiveImage = true;
            this.AddStaffButton.ShowCursorChanges = true;
            this.AddStaffButton.ShowImageBorders = true;
            this.AddStaffButton.ShowSizeMarkers = false;
            this.AddStaffButton.Size = new System.Drawing.Size(48, 48);
            this.AddStaffButton.TabIndex = 95;
            this.AddStaffButton.ToolTipText = "Добавление нового сотрудника";
            this.AddStaffButton.WaitOnLoad = false;
            this.AddStaffButton.Zoom = 5;
            this.AddStaffButton.ZoomSpeed = 10;
            this.AddStaffButton.Click += new System.EventHandler(this.AddStaffButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(957, 599);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.SearchDateButton);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.BeginLabel);
            this.Controls.Add(this.ChoiceLabel);
            this.Controls.Add(this.DatePicker2);
            this.Controls.Add(this.DatePicker1);
            this.Controls.Add(this.AddDeliveryButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.AddDishButton);
            this.Controls.Add(this.AddStaffButton);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.DragPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pages.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            this.Staff.ResumeLayout(false);
            this.Dish.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Delivery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DishShowButton;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label SubHeaderLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button ClientsShowButton;
        private System.Windows.Forms.Button ButtonHelp;
        private System.Windows.Forms.Button StaffShowButton;
        public Bunifu.UI.WinForms.BunifuDatePicker datePickerGraphic;
        private System.Windows.Forms.TabPage Staff;
        public System.Windows.Forms.FlowLayoutPanel ClientsPanel;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.TabPage Dish;
        public System.Windows.Forms.FlowLayoutPanel DishesPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuImageButton ExitButton;
        private System.Windows.Forms.TabPage Orders;
        public System.Windows.Forms.FlowLayoutPanel OrdersPanel;
        public System.Windows.Forms.FlowLayoutPanel StaffPanel;
        private Bunifu.UI.WinForms.BunifuImageButton AddStaffButton;
        private Bunifu.UI.WinForms.BunifuImageButton AddDishButton;
        private System.Windows.Forms.Button DeliveryShowButton;
        private System.Windows.Forms.TabPage Delivery;
        public Bunifu.UI.WinForms.BunifuPages Pages;
        public System.Windows.Forms.FlowLayoutPanel DeliveryPanel;
        private Bunifu.UI.WinForms.BunifuImageButton AddClientButton;
        private Bunifu.UI.WinForms.BunifuImageButton AddDeliveryButton;
        public Bunifu.UI.WinForms.BunifuTextBox SearchField;
        private System.Windows.Forms.Button OrdersShowButton;
        private Bunifu.UI.WinForms.BunifuImageButton SearchButton;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker1;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel BeginLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel EndLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel ChoiceLabel;
        private Bunifu.UI.WinForms.BunifuImageButton SearchDateButton;
        private Bunifu.Reports.BunifuReports Report;
        private Bunifu.UI.WinForms.BunifuImageButton ReportButton;
        public System.Windows.Forms.DataGridView DGView;
    }
}

