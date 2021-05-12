namespace FastFoodDemo
{
    partial class OrderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAdd));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.HeaderLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DishLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StaffLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StaffDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ButtonCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.DishDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ClientsDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ClientLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LeadTimeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TypeOrderDropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.TypeOrderLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CountLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CountField = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.LeadTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.MaximumSize = new System.Drawing.Size(285, 35);
            this.HeaderLabel.MinimumSize = new System.Drawing.Size(375, 35);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(375, 35);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Оформление заказа";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(4, 247);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(51, 19);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Дата";
            // 
            // DishLabel
            // 
            this.DishLabel.AutoSize = true;
            this.DishLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DishLabel.Location = new System.Drawing.Point(2, 51);
            this.DishLabel.Name = "DishLabel";
            this.DishLabel.Size = new System.Drawing.Size(61, 19);
            this.DishLabel.TabIndex = 16;
            this.DishLabel.Text = "Блюдо";
            // 
            // StaffLabel
            // 
            this.StaffLabel.AutoSize = true;
            this.StaffLabel.Enabled = false;
            this.StaffLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffLabel.Location = new System.Drawing.Point(2, 88);
            this.StaffLabel.Name = "StaffLabel";
            this.StaffLabel.Size = new System.Drawing.Size(98, 19);
            this.StaffLabel.TabIndex = 18;
            this.StaffLabel.Text = "Сотрудник";
            // 
            // StaffDropdown
            // 
            this.StaffDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.StaffDropdown.BackgroundColor = System.Drawing.Color.White;
            this.StaffDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.StaffDropdown.BorderRadius = 5;
            this.StaffDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.StaffDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.StaffDropdown.DisabledBackColor = System.Drawing.Color.GreenYellow;
            this.StaffDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.StaffDropdown.DisabledColor = System.Drawing.Color.GreenYellow;
            this.StaffDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.StaffDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.StaffDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StaffDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.StaffDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.StaffDropdown.FillDropDown = false;
            this.StaffDropdown.FillIndicator = false;
            this.StaffDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffDropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StaffDropdown.ForeColor = System.Drawing.Color.Black;
            this.StaffDropdown.FormattingEnabled = true;
            this.StaffDropdown.Icon = null;
            this.StaffDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.StaffDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.StaffDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.StaffDropdown.ItemBackColor = System.Drawing.Color.White;
            this.StaffDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.StaffDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.StaffDropdown.ItemHeight = 35;
            this.StaffDropdown.ItemHighLightColor = System.Drawing.Color.MistyRose;
            this.StaffDropdown.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.StaffDropdown.ItemTopMargin = 3;
            this.StaffDropdown.Location = new System.Drawing.Point(112, 78);
            this.StaffDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.StaffDropdown.MaxLength = 3255;
            this.StaffDropdown.MinimumSize = new System.Drawing.Size(200, 0);
            this.StaffDropdown.Name = "StaffDropdown";
            this.StaffDropdown.Size = new System.Drawing.Size(260, 41);
            this.StaffDropdown.TabIndex = 74;
            this.StaffDropdown.Text = "Сотрудник";
            this.StaffDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.StaffDropdown.TextLeftMargin = 5;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.AllowAnimations = true;
            this.ButtonCancel.AllowMouseEffects = true;
            this.ButtonCancel.AllowToggling = false;
            this.ButtonCancel.AnimationSpeed = 200;
            this.ButtonCancel.AutoGenerateColors = false;
            this.ButtonCancel.AutoRoundBorders = false;
            this.ButtonCancel.AutoSizeLeftIcon = true;
            this.ButtonCancel.AutoSizeRightIcon = true;
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.BackColor1 = System.Drawing.Color.Black;
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonCancel.ButtonText = "Отмена";
            this.ButtonCancel.ButtonTextMarginLeft = 0;
            this.ButtonCancel.ColorContrastOnClick = 45;
            this.ButtonCancel.ColorContrastOnHover = 45;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ButtonCancel.CustomizableEdges = borderEdges3;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ButtonCancel.DisabledFillColor = System.Drawing.Color.Gray;
            this.ButtonCancel.DisabledForecolor = System.Drawing.Color.White;
            this.ButtonCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCancel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonCancel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ButtonCancel.IconMarginLeft = 11;
            this.ButtonCancel.IconPadding = 10;
            this.ButtonCancel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCancel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ButtonCancel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ButtonCancel.IconSize = 25;
            this.ButtonCancel.IdleBorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.IdleBorderRadius = 1;
            this.ButtonCancel.IdleBorderThickness = 1;
            this.ButtonCancel.IdleFillColor = System.Drawing.Color.Black;
            this.ButtonCancel.IdleIconLeftImage = null;
            this.ButtonCancel.IdleIconRightImage = null;
            this.ButtonCancel.IndicateFocus = false;
            this.ButtonCancel.Location = new System.Drawing.Point(115, 317);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ButtonCancel.OnDisabledState.BorderRadius = 1;
            this.ButtonCancel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonCancel.OnDisabledState.BorderThickness = 1;
            this.ButtonCancel.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.ButtonCancel.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.OnDisabledState.IconLeftImage = null;
            this.ButtonCancel.OnDisabledState.IconRightImage = null;
            this.ButtonCancel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.onHoverState.BorderRadius = 1;
            this.ButtonCancel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonCancel.onHoverState.BorderThickness = 1;
            this.ButtonCancel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.ButtonCancel.onHoverState.IconLeftImage = null;
            this.ButtonCancel.onHoverState.IconRightImage = null;
            this.ButtonCancel.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.ButtonCancel.OnIdleState.BorderRadius = 1;
            this.ButtonCancel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonCancel.OnIdleState.BorderThickness = 1;
            this.ButtonCancel.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.ButtonCancel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.OnIdleState.IconLeftImage = null;
            this.ButtonCancel.OnIdleState.IconRightImage = null;
            this.ButtonCancel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonCancel.OnPressedState.BorderRadius = 1;
            this.ButtonCancel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonCancel.OnPressedState.BorderThickness = 1;
            this.ButtonCancel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ButtonCancel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ButtonCancel.OnPressedState.IconLeftImage = null;
            this.ButtonCancel.OnPressedState.IconRightImage = null;
            this.ButtonCancel.Size = new System.Drawing.Size(128, 45);
            this.ButtonCancel.TabIndex = 80;
            this.ButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCancel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonCancel.TextMarginLeft = 0;
            this.ButtonCancel.TextPadding = new System.Windows.Forms.Padding(0);
            this.ButtonCancel.UseDefaultRadiusAndThickness = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.BackColor = System.Drawing.Color.White;
            this.DatePicker.BorderRadius = 1;
            this.DatePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.DatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DatePicker.DisplayWeekNumbers = false;
            this.DatePicker.DPHeight = 0;
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.FillDatePicker = false;
            this.DatePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DatePicker.ForeColor = System.Drawing.Color.Black;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker.Icon")));
            this.DatePicker.IconColor = System.Drawing.Color.Transparent;
            this.DatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker.LeftTextMargin = 5;
            this.DatePicker.Location = new System.Drawing.Point(114, 240);
            this.DatePicker.MinimumSize = new System.Drawing.Size(257, 35);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(257, 35);
            this.DatePicker.TabIndex = 75;
            // 
            // DishDropdown
            // 
            this.DishDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.DishDropdown.BackgroundColor = System.Drawing.Color.White;
            this.DishDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DishDropdown.BorderRadius = 5;
            this.DishDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.DishDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DishDropdown.DisabledBackColor = System.Drawing.Color.GreenYellow;
            this.DishDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DishDropdown.DisabledColor = System.Drawing.Color.GreenYellow;
            this.DishDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DishDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DishDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DishDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.DishDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DishDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DishDropdown.FillDropDown = false;
            this.DishDropdown.FillIndicator = false;
            this.DishDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DishDropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DishDropdown.ForeColor = System.Drawing.Color.Black;
            this.DishDropdown.FormattingEnabled = true;
            this.DishDropdown.Icon = null;
            this.DishDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DishDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.DishDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DishDropdown.ItemBackColor = System.Drawing.Color.White;
            this.DishDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.DishDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.DishDropdown.ItemHeight = 35;
            this.DishDropdown.ItemHighLightColor = System.Drawing.Color.MistyRose;
            this.DishDropdown.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.DishDropdown.ItemTopMargin = 3;
            this.DishDropdown.Location = new System.Drawing.Point(113, 37);
            this.DishDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.DishDropdown.MaxLength = 3255;
            this.DishDropdown.MinimumSize = new System.Drawing.Size(200, 0);
            this.DishDropdown.Name = "DishDropdown";
            this.DishDropdown.Size = new System.Drawing.Size(260, 41);
            this.DishDropdown.TabIndex = 73;
            this.DishDropdown.Text = "Блюдо";
            this.DishDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DishDropdown.TextLeftMargin = 5;
            // 
            // ClientsDropdown
            // 
            this.ClientsDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.ClientsDropdown.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.ClientsDropdown.BorderRadius = 5;
            this.ClientsDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.ClientsDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ClientsDropdown.DisabledBackColor = System.Drawing.Color.GreenYellow;
            this.ClientsDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientsDropdown.DisabledColor = System.Drawing.Color.GreenYellow;
            this.ClientsDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ClientsDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ClientsDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientsDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ClientsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientsDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ClientsDropdown.FillDropDown = false;
            this.ClientsDropdown.FillIndicator = false;
            this.ClientsDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsDropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsDropdown.ForeColor = System.Drawing.Color.Black;
            this.ClientsDropdown.FormattingEnabled = true;
            this.ClientsDropdown.Icon = null;
            this.ClientsDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ClientsDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ClientsDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ClientsDropdown.ItemBackColor = System.Drawing.Color.White;
            this.ClientsDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.ClientsDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.ClientsDropdown.ItemHeight = 35;
            this.ClientsDropdown.ItemHighLightColor = System.Drawing.Color.MistyRose;
            this.ClientsDropdown.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.ClientsDropdown.ItemTopMargin = 3;
            this.ClientsDropdown.Location = new System.Drawing.Point(113, 119);
            this.ClientsDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.ClientsDropdown.MaxLength = 3255;
            this.ClientsDropdown.MinimumSize = new System.Drawing.Size(200, 0);
            this.ClientsDropdown.Name = "ClientsDropdown";
            this.ClientsDropdown.Size = new System.Drawing.Size(260, 41);
            this.ClientsDropdown.TabIndex = 76;
            this.ClientsDropdown.Text = "Клиент";
            this.ClientsDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ClientsDropdown.TextLeftMargin = 5;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLabel.Location = new System.Drawing.Point(2, 119);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(111, 38);
            this.ClientLabel.TabIndex = 74;
            this.ClientLabel.Text = "Имеющийся\r\nклиент";
            // 
            // LeadTimeLabel
            // 
            this.LeadTimeLabel.AutoSize = true;
            this.LeadTimeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeadTimeLabel.Location = new System.Drawing.Point(2, 273);
            this.LeadTimeLabel.Name = "LeadTimeLabel";
            this.LeadTimeLabel.Size = new System.Drawing.Size(107, 38);
            this.LeadTimeLabel.TabIndex = 76;
            this.LeadTimeLabel.Text = "Время\r\nвыполнения";
            // 
            // TypeOrderDropdown
            // 
            this.TypeOrderDropdown.BackColor = System.Drawing.SystemColors.Control;
            this.TypeOrderDropdown.BackgroundColor = System.Drawing.Color.White;
            this.TypeOrderDropdown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.TypeOrderDropdown.BorderRadius = 5;
            this.TypeOrderDropdown.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.TypeOrderDropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.TypeOrderDropdown.DisabledBackColor = System.Drawing.Color.GreenYellow;
            this.TypeOrderDropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TypeOrderDropdown.DisabledColor = System.Drawing.Color.GreenYellow;
            this.TypeOrderDropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TypeOrderDropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.TypeOrderDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeOrderDropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.TypeOrderDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOrderDropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TypeOrderDropdown.FillDropDown = false;
            this.TypeOrderDropdown.FillIndicator = false;
            this.TypeOrderDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeOrderDropdown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOrderDropdown.ForeColor = System.Drawing.Color.Black;
            this.TypeOrderDropdown.FormattingEnabled = true;
            this.TypeOrderDropdown.Icon = null;
            this.TypeOrderDropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TypeOrderDropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.TypeOrderDropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.TypeOrderDropdown.ItemBackColor = System.Drawing.Color.White;
            this.TypeOrderDropdown.ItemBorderColor = System.Drawing.Color.White;
            this.TypeOrderDropdown.ItemForeColor = System.Drawing.Color.Black;
            this.TypeOrderDropdown.ItemHeight = 35;
            this.TypeOrderDropdown.ItemHighLightColor = System.Drawing.Color.MistyRose;
            this.TypeOrderDropdown.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.TypeOrderDropdown.ItemTopMargin = 3;
            this.TypeOrderDropdown.Location = new System.Drawing.Point(112, 159);
            this.TypeOrderDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.TypeOrderDropdown.MaxLength = 3255;
            this.TypeOrderDropdown.MinimumSize = new System.Drawing.Size(200, 0);
            this.TypeOrderDropdown.Name = "TypeOrderDropdown";
            this.TypeOrderDropdown.Size = new System.Drawing.Size(260, 41);
            this.TypeOrderDropdown.TabIndex = 77;
            this.TypeOrderDropdown.Text = "Тип заказа";
            this.TypeOrderDropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.TypeOrderDropdown.TextLeftMargin = 5;
            // 
            // TypeOrderLabel
            // 
            this.TypeOrderLabel.AutoSize = true;
            this.TypeOrderLabel.Enabled = false;
            this.TypeOrderLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOrderLabel.Location = new System.Drawing.Point(2, 168);
            this.TypeOrderLabel.Name = "TypeOrderLabel";
            this.TypeOrderLabel.Size = new System.Drawing.Size(96, 19);
            this.TypeOrderLabel.TabIndex = 78;
            this.TypeOrderLabel.Text = "Тип заказа";
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLabel.Location = new System.Drawing.Point(2, 212);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(104, 19);
            this.CountLabel.TabIndex = 3;
            this.CountLabel.Text = "Количество";
            // 
            // CountField
            // 
            this.CountField.AcceptsReturn = false;
            this.CountField.AcceptsTab = false;
            this.CountField.AnimationSpeed = 200;
            this.CountField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CountField.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CountField.BackColor = System.Drawing.Color.Transparent;
            this.CountField.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CountField.BackgroundImage")));
            this.CountField.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CountField.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CountField.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CountField.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.CountField.BorderRadius = 1;
            this.CountField.BorderThickness = 2;
            this.CountField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CountField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CountField.DefaultFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountField.DefaultText = "";
            this.CountField.FillColor = System.Drawing.Color.White;
            this.CountField.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CountField.HideSelection = true;
            this.CountField.IconLeft = null;
            this.CountField.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.CountField.IconPadding = 10;
            this.CountField.IconRight = null;
            this.CountField.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.CountField.Lines = new string[0];
            this.CountField.Location = new System.Drawing.Point(112, 199);
            this.CountField.MaxLength = 32767;
            this.CountField.MinimumSize = new System.Drawing.Size(100, 35);
            this.CountField.Modified = false;
            this.CountField.Multiline = false;
            this.CountField.Name = "CountField";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CountField.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CountField.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CountField.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CountField.OnIdleState = stateProperties8;
            this.CountField.PasswordChar = '\0';
            this.CountField.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CountField.PlaceholderText = "";
            this.CountField.ReadOnly = false;
            this.CountField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CountField.SelectedText = "";
            this.CountField.SelectionLength = 0;
            this.CountField.SelectionStart = 0;
            this.CountField.ShortcutsEnabled = true;
            this.CountField.Size = new System.Drawing.Size(260, 41);
            this.CountField.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.CountField.TabIndex = 78;
            this.CountField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CountField.TextMarginBottom = 0;
            this.CountField.TextMarginLeft = 5;
            this.CountField.TextMarginTop = 0;
            this.CountField.TextPlaceholder = "";
            this.CountField.UseSystemPasswordChar = false;
            this.CountField.WordWrap = false;
            this.CountField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountField_KeyPress);
            // 
            // LeadTimePicker
            // 
            this.LeadTimePicker.CustomFormat = "H:mm";
            this.LeadTimePicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeadTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LeadTimePicker.Location = new System.Drawing.Point(115, 276);
            this.LeadTimePicker.MinimumSize = new System.Drawing.Size(256, 35);
            this.LeadTimePicker.Name = "LeadTimePicker";
            this.LeadTimePicker.ShowUpDown = true;
            this.LeadTimePicker.Size = new System.Drawing.Size(256, 35);
            this.LeadTimePicker.TabIndex = 79;
            this.LeadTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DatePicker_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.AllowAnimations = true;
            this.AddButton.AllowMouseEffects = true;
            this.AddButton.AllowToggling = false;
            this.AddButton.AnimationSpeed = 200;
            this.AddButton.AutoGenerateColors = true;
            this.AddButton.AutoRoundBorders = false;
            this.AddButton.AutoSizeLeftIcon = true;
            this.AddButton.AutoSizeRightIcon = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BackColor1 = System.Drawing.Color.Firebrick;
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.ButtonText = "Заказать";
            this.AddButton.ButtonTextMarginLeft = 0;
            this.AddButton.ColorContrastOnClick = 45;
            this.AddButton.ColorContrastOnHover = 45;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.AddButton.CustomizableEdges = borderEdges4;
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.AddButton.DisabledForecolor = System.Drawing.Color.White;
            this.AddButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddButton.IconMarginLeft = 11;
            this.AddButton.IconPadding = 10;
            this.AddButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddButton.IconSize = 25;
            this.AddButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.AddButton.IdleBorderRadius = 1;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.AddButton.IdleIconLeftImage = null;
            this.AddButton.IdleIconRightImage = null;
            this.AddButton.IndicateFocus = true;
            this.AddButton.Location = new System.Drawing.Point(243, 317);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddButton.OnDisabledState.BorderRadius = 1;
            this.AddButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnDisabledState.BorderThickness = 1;
            this.AddButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.AddButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnDisabledState.IconLeftImage = null;
            this.AddButton.OnDisabledState.IconRightImage = null;
            this.AddButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.AddButton.onHoverState.BorderRadius = 1;
            this.AddButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.onHoverState.BorderThickness = 1;
            this.AddButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.AddButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddButton.onHoverState.IconLeftImage = null;
            this.AddButton.onHoverState.IconRightImage = null;
            this.AddButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.AddButton.OnIdleState.BorderRadius = 1;
            this.AddButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnIdleState.BorderThickness = 1;
            this.AddButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.AddButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnIdleState.IconLeftImage = null;
            this.AddButton.OnIdleState.IconRightImage = null;
            this.AddButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.AddButton.OnPressedState.BorderRadius = 1;
            this.AddButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnPressedState.BorderThickness = 1;
            this.AddButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.AddButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnPressedState.IconLeftImage = null;
            this.AddButton.OnPressedState.IconRightImage = null;
            this.AddButton.Size = new System.Drawing.Size(128, 45);
            this.AddButton.TabIndex = 81;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.TextMarginLeft = 0;
            this.AddButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddButton.UseDefaultRadiusAndThickness = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 366);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CountField);
            this.Controls.Add(this.LeadTimePicker);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.DishDropdown);
            this.Controls.Add(this.TypeOrderDropdown);
            this.Controls.Add(this.TypeOrderLabel);
            this.Controls.Add(this.LeadTimeLabel);
            this.Controls.Add(this.ClientsDropdown);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.StaffDropdown);
            this.Controls.Add(this.StaffLabel);
            this.Controls.Add(this.DishLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CountLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByeDish";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            this.Shown += new System.EventHandler(this.OrderAdd_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel HeaderLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel DateLabel;
        public Bunifu.UI.WinForms.BunifuDatePicker DatePicker;
        public Bunifu.Framework.UI.BunifuCustomLabel DishLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel StaffLabel;
        public Bunifu.UI.WinForms.BunifuDropdown StaffDropdown;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonCancel;
        public Bunifu.UI.WinForms.BunifuDropdown DishDropdown;
        public Bunifu.UI.WinForms.BunifuDropdown ClientsDropdown;
        public Bunifu.Framework.UI.BunifuCustomLabel ClientLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel LeadTimeLabel;
        public Bunifu.UI.WinForms.BunifuDropdown TypeOrderDropdown;
        public Bunifu.Framework.UI.BunifuCustomLabel TypeOrderLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel CountLabel;
        public Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox CountField;
        public System.Windows.Forms.DateTimePicker LeadTimePicker;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton AddButton;
    }
}