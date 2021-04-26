namespace FastFoodDemo
{
    partial class Dish
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dish));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuCard = new Bunifu.Framework.UI.BunifuCards();
            this.DeleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.EditButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Opisanie = new Bunifu.Framework.BunifuCustomTextbox();
            this.Nazv = new Bunifu.Framework.BunifuCustomTextbox();
            this.ByeButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.weight = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureDish = new System.Windows.Forms.PictureBox();
            this.bunifuCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCard
            // 
            this.bunifuCard.BackColor = System.Drawing.Color.DarkGray;
            this.bunifuCard.BorderRadius = 10;
            this.bunifuCard.BottomSahddow = false;
            this.bunifuCard.color = System.Drawing.Color.Transparent;
            this.bunifuCard.Controls.Add(this.DeleteButton);
            this.bunifuCard.Controls.Add(this.EditButton);
            this.bunifuCard.Controls.Add(this.Opisanie);
            this.bunifuCard.Controls.Add(this.Nazv);
            this.bunifuCard.Controls.Add(this.ByeButton);
            this.bunifuCard.Controls.Add(this.weight);
            this.bunifuCard.Controls.Add(this.Price);
            this.bunifuCard.Controls.Add(this.pictureDish);
            this.bunifuCard.LeftSahddow = false;
            this.bunifuCard.Location = new System.Drawing.Point(0, 0);
            this.bunifuCard.Name = "bunifuCard";
            this.bunifuCard.RightSahddow = false;
            this.bunifuCard.ShadowDepth = 20;
            this.bunifuCard.Size = new System.Drawing.Size(355, 436);
            this.bunifuCard.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AllowAnimations = true;
            this.DeleteButton.AllowMouseEffects = true;
            this.DeleteButton.AllowToggling = true;
            this.DeleteButton.AnimationSpeed = 200;
            this.DeleteButton.AutoGenerateColors = true;
            this.DeleteButton.AutoRoundBorders = false;
            this.DeleteButton.AutoSizeLeftIcon = true;
            this.DeleteButton.AutoSizeRightIcon = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackColor1 = System.Drawing.Color.Firebrick;
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteButton.ButtonText = "Удалить";
            this.DeleteButton.ButtonTextMarginLeft = 0;
            this.DeleteButton.ColorContrastOnClick = 45;
            this.DeleteButton.ColorContrastOnHover = 45;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.DeleteButton.CustomizableEdges = borderEdges1;
            this.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.DeleteButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.DeleteButton.DisabledForecolor = System.Drawing.Color.White;
            this.DeleteButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteButton.IconMarginLeft = 11;
            this.DeleteButton.IconPadding = 10;
            this.DeleteButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteButton.IconSize = 25;
            this.DeleteButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.DeleteButton.IdleBorderRadius = 1;
            this.DeleteButton.IdleBorderThickness = 1;
            this.DeleteButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.DeleteButton.IdleIconLeftImage = null;
            this.DeleteButton.IdleIconRightImage = null;
            this.DeleteButton.IndicateFocus = true;
            this.DeleteButton.Location = new System.Drawing.Point(85, 393);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.DeleteButton.OnDisabledState.BorderRadius = 1;
            this.DeleteButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteButton.OnDisabledState.BorderThickness = 1;
            this.DeleteButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.DeleteButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.OnDisabledState.IconLeftImage = null;
            this.DeleteButton.OnDisabledState.IconRightImage = null;
            this.DeleteButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.DeleteButton.onHoverState.BorderRadius = 1;
            this.DeleteButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteButton.onHoverState.BorderThickness = 1;
            this.DeleteButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.DeleteButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.onHoverState.IconLeftImage = null;
            this.DeleteButton.onHoverState.IconRightImage = null;
            this.DeleteButton.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.DeleteButton.OnIdleState.BorderRadius = 1;
            this.DeleteButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteButton.OnIdleState.BorderThickness = 1;
            this.DeleteButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.DeleteButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.OnIdleState.IconLeftImage = null;
            this.DeleteButton.OnIdleState.IconRightImage = null;
            this.DeleteButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteButton.OnPressedState.BorderRadius = 1;
            this.DeleteButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteButton.OnPressedState.BorderThickness = 1;
            this.DeleteButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DeleteButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.OnPressedState.IconLeftImage = null;
            this.DeleteButton.OnPressedState.IconRightImage = null;
            this.DeleteButton.Size = new System.Drawing.Size(184, 27);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteButton.TextMarginLeft = 0;
            this.DeleteButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteButton.UseDefaultRadiusAndThickness = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AllowAnimations = true;
            this.EditButton.AllowMouseEffects = true;
            this.EditButton.AllowToggling = false;
            this.EditButton.AnimationSpeed = 200;
            this.EditButton.AutoGenerateColors = true;
            this.EditButton.AutoRoundBorders = false;
            this.EditButton.AutoSizeLeftIcon = true;
            this.EditButton.AutoSizeRightIcon = true;
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.BackColor1 = System.Drawing.Color.Firebrick;
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditButton.ButtonText = "Редактировать";
            this.EditButton.ButtonTextMarginLeft = 0;
            this.EditButton.ColorContrastOnClick = 45;
            this.EditButton.ColorContrastOnHover = 45;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.EditButton.CustomizableEdges = borderEdges2;
            this.EditButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EditButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EditButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.EditButton.DisabledForecolor = System.Drawing.Color.White;
            this.EditButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.EditButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.EditButton.IconMarginLeft = 11;
            this.EditButton.IconPadding = 10;
            this.EditButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.EditButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.EditButton.IconSize = 25;
            this.EditButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.EditButton.IdleBorderRadius = 1;
            this.EditButton.IdleBorderThickness = 1;
            this.EditButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.EditButton.IdleIconLeftImage = null;
            this.EditButton.IdleIconRightImage = null;
            this.EditButton.IndicateFocus = true;
            this.EditButton.Location = new System.Drawing.Point(85, 362);
            this.EditButton.Name = "EditButton";
            this.EditButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EditButton.OnDisabledState.BorderRadius = 1;
            this.EditButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditButton.OnDisabledState.BorderThickness = 1;
            this.EditButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.EditButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.EditButton.OnDisabledState.IconLeftImage = null;
            this.EditButton.OnDisabledState.IconRightImage = null;
            this.EditButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.EditButton.onHoverState.BorderRadius = 1;
            this.EditButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditButton.onHoverState.BorderThickness = 1;
            this.EditButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.EditButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.EditButton.onHoverState.IconLeftImage = null;
            this.EditButton.onHoverState.IconRightImage = null;
            this.EditButton.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.EditButton.OnIdleState.BorderRadius = 1;
            this.EditButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditButton.OnIdleState.BorderThickness = 1;
            this.EditButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.EditButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.EditButton.OnIdleState.IconLeftImage = null;
            this.EditButton.OnIdleState.IconRightImage = null;
            this.EditButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EditButton.OnPressedState.BorderRadius = 1;
            this.EditButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.EditButton.OnPressedState.BorderThickness = 1;
            this.EditButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.EditButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.EditButton.OnPressedState.IconLeftImage = null;
            this.EditButton.OnPressedState.IconRightImage = null;
            this.EditButton.Size = new System.Drawing.Size(184, 27);
            this.EditButton.TabIndex = 8;
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.EditButton.TextMarginLeft = 0;
            this.EditButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.EditButton.UseDefaultRadiusAndThickness = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Opisanie
            // 
            this.Opisanie.BackColor = System.Drawing.Color.DarkGray;
            this.Opisanie.BorderColor = System.Drawing.Color.SeaGreen;
            this.Opisanie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Opisanie.Cursor = System.Windows.Forms.Cursors.Default;
            this.Opisanie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Opisanie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Opisanie.Location = new System.Drawing.Point(0, 271);
            this.Opisanie.MinimumSize = new System.Drawing.Size(220, 25);
            this.Opisanie.Multiline = true;
            this.Opisanie.Name = "Opisanie";
            this.Opisanie.ReadOnly = true;
            this.Opisanie.Size = new System.Drawing.Size(342, 32);
            this.Opisanie.TabIndex = 13;
            this.Opisanie.Text = "Рецепт";
            // 
            // Nazv
            // 
            this.Nazv.BackColor = System.Drawing.Color.DarkGray;
            this.Nazv.BorderColor = System.Drawing.Color.Black;
            this.Nazv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nazv.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nazv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nazv.Location = new System.Drawing.Point(3, 240);
            this.Nazv.MinimumSize = new System.Drawing.Size(220, 25);
            this.Nazv.Multiline = true;
            this.Nazv.Name = "Nazv";
            this.Nazv.ReadOnly = true;
            this.Nazv.Size = new System.Drawing.Size(339, 25);
            this.Nazv.TabIndex = 12;
            this.Nazv.Text = "Название";
            // 
            // ByeButton
            // 
            this.ByeButton.AllowAnimations = true;
            this.ByeButton.AllowMouseEffects = true;
            this.ByeButton.AllowToggling = true;
            this.ByeButton.AnimationSpeed = 200;
            this.ByeButton.AutoGenerateColors = true;
            this.ByeButton.AutoRoundBorders = false;
            this.ByeButton.AutoSizeLeftIcon = true;
            this.ByeButton.AutoSizeRightIcon = true;
            this.ByeButton.BackColor = System.Drawing.Color.Transparent;
            this.ByeButton.BackColor1 = System.Drawing.Color.Firebrick;
            this.ByeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ByeButton.BackgroundImage")));
            this.ByeButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ByeButton.ButtonText = "Заказать";
            this.ByeButton.ButtonTextMarginLeft = 0;
            this.ByeButton.ColorContrastOnClick = 45;
            this.ByeButton.ColorContrastOnHover = 45;
            this.ByeButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.ByeButton.CustomizableEdges = borderEdges3;
            this.ByeButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ByeButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ByeButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.ByeButton.DisabledForecolor = System.Drawing.Color.White;
            this.ByeButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ByeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ByeButton.ForeColor = System.Drawing.Color.White;
            this.ByeButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ByeButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ByeButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ByeButton.IconMarginLeft = 11;
            this.ByeButton.IconPadding = 10;
            this.ByeButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ByeButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ByeButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ByeButton.IconSize = 25;
            this.ByeButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.ByeButton.IdleBorderRadius = 1;
            this.ByeButton.IdleBorderThickness = 1;
            this.ByeButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.ByeButton.IdleIconLeftImage = null;
            this.ByeButton.IdleIconRightImage = null;
            this.ByeButton.IndicateFocus = true;
            this.ByeButton.Location = new System.Drawing.Point(85, 329);
            this.ByeButton.Name = "ByeButton";
            this.ByeButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ByeButton.OnDisabledState.BorderRadius = 1;
            this.ByeButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ByeButton.OnDisabledState.BorderThickness = 1;
            this.ByeButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.ByeButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.ByeButton.OnDisabledState.IconLeftImage = null;
            this.ByeButton.OnDisabledState.IconRightImage = null;
            this.ByeButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.ByeButton.onHoverState.BorderRadius = 1;
            this.ByeButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ByeButton.onHoverState.BorderThickness = 1;
            this.ByeButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ByeButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ByeButton.onHoverState.IconLeftImage = null;
            this.ByeButton.onHoverState.IconRightImage = null;
            this.ByeButton.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.ByeButton.OnIdleState.BorderRadius = 1;
            this.ByeButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ByeButton.OnIdleState.BorderThickness = 1;
            this.ByeButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.ByeButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ByeButton.OnIdleState.IconLeftImage = null;
            this.ByeButton.OnIdleState.IconRightImage = null;
            this.ByeButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ByeButton.OnPressedState.BorderRadius = 1;
            this.ByeButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ByeButton.OnPressedState.BorderThickness = 1;
            this.ByeButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ByeButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ByeButton.OnPressedState.IconLeftImage = null;
            this.ByeButton.OnPressedState.IconRightImage = null;
            this.ByeButton.Size = new System.Drawing.Size(184, 27);
            this.ByeButton.TabIndex = 7;
            this.ByeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ByeButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ByeButton.TextMarginLeft = 0;
            this.ByeButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.ByeButton.UseDefaultRadiusAndThickness = true;
            this.ByeButton.Click += new System.EventHandler(this.ByeButton_Click);
            // 
            // weight
            // 
            this.weight.BorderColorFocused = System.Drawing.Color.Empty;
            this.weight.BorderColorIdle = System.Drawing.Color.Transparent;
            this.weight.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.weight.BorderThickness = 3;
            this.weight.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.weight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.weight.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.weight.ForeColor = System.Drawing.Color.Black;
            this.weight.isPassword = false;
            this.weight.Location = new System.Drawing.Point(0, 362);
            this.weight.Margin = new System.Windows.Forms.Padding(4);
            this.weight.MaxLength = 32767;
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(78, 27);
            this.weight.TabIndex = 6;
            this.weight.Text = "Вес";
            this.weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Price
            // 
            this.Price.BorderColorFocused = System.Drawing.Color.Empty;
            this.Price.BorderColorIdle = System.Drawing.Color.Transparent;
            this.Price.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.Price.BorderThickness = 3;
            this.Price.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Price.ForeColor = System.Drawing.Color.Black;
            this.Price.isPassword = false;
            this.Price.Location = new System.Drawing.Point(0, 329);
            this.Price.Margin = new System.Windows.Forms.Padding(4);
            this.Price.MaxLength = 32767;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(78, 27);
            this.Price.TabIndex = 4;
            this.Price.Text = "Цена";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureDish
            // 
            this.pictureDish.BackColor = System.Drawing.Color.Transparent;
            this.pictureDish.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureDish.Location = new System.Drawing.Point(0, 0);
            this.pictureDish.Name = "pictureDish";
            this.pictureDish.Size = new System.Drawing.Size(355, 237);
            this.pictureDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDish.TabIndex = 1;
            this.pictureDish.TabStop = false;
            // 
            // Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuCard);
            this.Name = "Dish";
            this.Size = new System.Drawing.Size(355, 436);
            this.bunifuCard.ResumeLayout(false);
            this.bunifuCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCard;
        public System.Windows.Forms.PictureBox pictureDish;
        public Bunifu.Framework.UI.BunifuMetroTextbox weight;
        public Bunifu.Framework.UI.BunifuMetroTextbox Price;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton ByeButton;
        public Bunifu.Framework.BunifuCustomTextbox Nazv;
        public Bunifu.Framework.BunifuCustomTextbox Opisanie;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton EditButton;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteButton;
    }
}
