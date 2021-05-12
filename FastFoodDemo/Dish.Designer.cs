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
            this.DishCard = new Bunifu.Framework.UI.BunifuCards();
            this.DeleteButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.RecipeField = new Bunifu.Framework.BunifuCustomTextbox();
            this.NameDishField = new Bunifu.Framework.BunifuCustomTextbox();
            this.AddButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.WeightField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PriceField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureDish = new System.Windows.Forms.PictureBox();
            this.DishCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).BeginInit();
            this.SuspendLayout();
            // 
            // DishCard
            // 
            this.DishCard.BackColor = System.Drawing.Color.DarkGray;
            this.DishCard.BorderRadius = 10;
            this.DishCard.BottomSahddow = false;
            this.DishCard.color = System.Drawing.Color.Transparent;
            this.DishCard.Controls.Add(this.DeleteButton);
            this.DishCard.Controls.Add(this.UpdateButton);
            this.DishCard.Controls.Add(this.RecipeField);
            this.DishCard.Controls.Add(this.NameDishField);
            this.DishCard.Controls.Add(this.AddButton);
            this.DishCard.Controls.Add(this.WeightField);
            this.DishCard.Controls.Add(this.PriceField);
            this.DishCard.Controls.Add(this.pictureDish);
            this.DishCard.LeftSahddow = false;
            this.DishCard.Location = new System.Drawing.Point(0, 0);
            this.DishCard.Name = "DishCard";
            this.DishCard.RightSahddow = false;
            this.DishCard.ShadowDepth = 20;
            this.DishCard.Size = new System.Drawing.Size(355, 436);
            this.DishCard.TabIndex = 0;
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
            // UpdateButton
            // 
            this.UpdateButton.AllowAnimations = true;
            this.UpdateButton.AllowMouseEffects = true;
            this.UpdateButton.AllowToggling = false;
            this.UpdateButton.AnimationSpeed = 200;
            this.UpdateButton.AutoGenerateColors = true;
            this.UpdateButton.AutoRoundBorders = false;
            this.UpdateButton.AutoSizeLeftIcon = true;
            this.UpdateButton.AutoSizeRightIcon = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.BackColor1 = System.Drawing.Color.Firebrick;
            this.UpdateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateButton.BackgroundImage")));
            this.UpdateButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.ButtonText = "Редактировать";
            this.UpdateButton.ButtonTextMarginLeft = 0;
            this.UpdateButton.ColorContrastOnClick = 45;
            this.UpdateButton.ColorContrastOnHover = 45;
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.UpdateButton.CustomizableEdges = borderEdges2;
            this.UpdateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.UpdateButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.UpdateButton.DisabledForecolor = System.Drawing.Color.White;
            this.UpdateButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateButton.IconMarginLeft = 11;
            this.UpdateButton.IconPadding = 10;
            this.UpdateButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateButton.IconSize = 25;
            this.UpdateButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.UpdateButton.IdleBorderRadius = 1;
            this.UpdateButton.IdleBorderThickness = 1;
            this.UpdateButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.UpdateButton.IdleIconLeftImage = null;
            this.UpdateButton.IdleIconRightImage = null;
            this.UpdateButton.IndicateFocus = true;
            this.UpdateButton.Location = new System.Drawing.Point(85, 362);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.UpdateButton.OnDisabledState.BorderRadius = 1;
            this.UpdateButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnDisabledState.BorderThickness = 1;
            this.UpdateButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.UpdateButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.OnDisabledState.IconLeftImage = null;
            this.UpdateButton.OnDisabledState.IconRightImage = null;
            this.UpdateButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.UpdateButton.onHoverState.BorderRadius = 1;
            this.UpdateButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.onHoverState.BorderThickness = 1;
            this.UpdateButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UpdateButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.onHoverState.IconLeftImage = null;
            this.UpdateButton.onHoverState.IconRightImage = null;
            this.UpdateButton.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.UpdateButton.OnIdleState.BorderRadius = 1;
            this.UpdateButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnIdleState.BorderThickness = 1;
            this.UpdateButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.UpdateButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.OnIdleState.IconLeftImage = null;
            this.UpdateButton.OnIdleState.IconRightImage = null;
            this.UpdateButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UpdateButton.OnPressedState.BorderRadius = 1;
            this.UpdateButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateButton.OnPressedState.BorderThickness = 1;
            this.UpdateButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UpdateButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.OnPressedState.IconLeftImage = null;
            this.UpdateButton.OnPressedState.IconRightImage = null;
            this.UpdateButton.Size = new System.Drawing.Size(184, 27);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateButton.TextMarginLeft = 0;
            this.UpdateButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateButton.UseDefaultRadiusAndThickness = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // RecipeField
            // 
            this.RecipeField.BackColor = System.Drawing.Color.DarkGray;
            this.RecipeField.BorderColor = System.Drawing.Color.SeaGreen;
            this.RecipeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipeField.Cursor = System.Windows.Forms.Cursors.Default;
            this.RecipeField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipeField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RecipeField.Location = new System.Drawing.Point(3, 271);
            this.RecipeField.MinimumSize = new System.Drawing.Size(220, 25);
            this.RecipeField.Multiline = true;
            this.RecipeField.Name = "RecipeField";
            this.RecipeField.ReadOnly = true;
            this.RecipeField.Size = new System.Drawing.Size(342, 32);
            this.RecipeField.TabIndex = 13;
            this.RecipeField.Text = "Рецепт";
            // 
            // NameDishField
            // 
            this.NameDishField.BackColor = System.Drawing.Color.DarkGray;
            this.NameDishField.BorderColor = System.Drawing.Color.Black;
            this.NameDishField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameDishField.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameDishField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameDishField.Location = new System.Drawing.Point(3, 240);
            this.NameDishField.MinimumSize = new System.Drawing.Size(220, 25);
            this.NameDishField.Multiline = true;
            this.NameDishField.Name = "NameDishField";
            this.NameDishField.ReadOnly = true;
            this.NameDishField.Size = new System.Drawing.Size(339, 25);
            this.NameDishField.TabIndex = 12;
            this.NameDishField.Text = "Название";
            // 
            // AddButton
            // 
            this.AddButton.AllowAnimations = true;
            this.AddButton.AllowMouseEffects = true;
            this.AddButton.AllowToggling = true;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.AddButton.CustomizableEdges = borderEdges3;
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
            this.AddButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.AddButton.IdleBorderRadius = 1;
            this.AddButton.IdleBorderThickness = 1;
            this.AddButton.IdleFillColor = System.Drawing.Color.Firebrick;
            this.AddButton.IdleIconLeftImage = null;
            this.AddButton.IdleIconRightImage = null;
            this.AddButton.IndicateFocus = true;
            this.AddButton.Location = new System.Drawing.Point(85, 329);
            this.AddButton.Name = "AddButton";
            this.AddButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.AddButton.OnDisabledState.BorderRadius = 1;
            this.AddButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnDisabledState.BorderThickness = 1;
            this.AddButton.OnDisabledState.FillColor = System.Drawing.Color.Gray;
            this.AddButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnDisabledState.IconLeftImage = null;
            this.AddButton.OnDisabledState.IconRightImage = null;
            this.AddButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.AddButton.onHoverState.BorderRadius = 1;
            this.AddButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.onHoverState.BorderThickness = 1;
            this.AddButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.AddButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddButton.onHoverState.IconLeftImage = null;
            this.AddButton.onHoverState.IconRightImage = null;
            this.AddButton.OnIdleState.BorderColor = System.Drawing.Color.Empty;
            this.AddButton.OnIdleState.BorderRadius = 1;
            this.AddButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnIdleState.BorderThickness = 1;
            this.AddButton.OnIdleState.FillColor = System.Drawing.Color.Firebrick;
            this.AddButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnIdleState.IconLeftImage = null;
            this.AddButton.OnIdleState.IconRightImage = null;
            this.AddButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddButton.OnPressedState.BorderRadius = 1;
            this.AddButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddButton.OnPressedState.BorderThickness = 1;
            this.AddButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.AddButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddButton.OnPressedState.IconLeftImage = null;
            this.AddButton.OnPressedState.IconRightImage = null;
            this.AddButton.Size = new System.Drawing.Size(184, 27);
            this.AddButton.TabIndex = 7;
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddButton.TextMarginLeft = 0;
            this.AddButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddButton.UseDefaultRadiusAndThickness = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // WeightField
            // 
            this.WeightField.BorderColorFocused = System.Drawing.Color.Empty;
            this.WeightField.BorderColorIdle = System.Drawing.Color.Transparent;
            this.WeightField.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.WeightField.BorderThickness = 3;
            this.WeightField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.WeightField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WeightField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.WeightField.ForeColor = System.Drawing.Color.Black;
            this.WeightField.isPassword = false;
            this.WeightField.Location = new System.Drawing.Point(3, 362);
            this.WeightField.Margin = new System.Windows.Forms.Padding(4);
            this.WeightField.MaxLength = 32767;
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(78, 27);
            this.WeightField.TabIndex = 6;
            this.WeightField.Text = "Вес";
            this.WeightField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PriceField
            // 
            this.PriceField.BorderColorFocused = System.Drawing.Color.Empty;
            this.PriceField.BorderColorIdle = System.Drawing.Color.Transparent;
            this.PriceField.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.PriceField.BorderThickness = 3;
            this.PriceField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PriceField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceField.ForeColor = System.Drawing.Color.Black;
            this.PriceField.isPassword = false;
            this.PriceField.Location = new System.Drawing.Point(3, 329);
            this.PriceField.Margin = new System.Windows.Forms.Padding(4);
            this.PriceField.MaxLength = 32767;
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(78, 27);
            this.PriceField.TabIndex = 4;
            this.PriceField.Text = "Цена";
            this.PriceField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.Controls.Add(this.DishCard);
            this.Name = "Dish";
            this.Size = new System.Drawing.Size(355, 436);
            this.DishCard.ResumeLayout(false);
            this.DishCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards DishCard;
        public System.Windows.Forms.PictureBox pictureDish;
        public Bunifu.Framework.UI.BunifuMetroTextbox WeightField;
        public Bunifu.Framework.UI.BunifuMetroTextbox PriceField;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton AddButton;
        public Bunifu.Framework.BunifuCustomTextbox NameDishField;
        public Bunifu.Framework.BunifuCustomTextbox RecipeField;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateButton;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteButton;
    }
}
