namespace PizzaOrder_Project
{
    partial class PizzaOrder
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
            this.rb_ThinkCrust = new System.Windows.Forms.RadioButton();
            this.rb_TakeOut = new System.Windows.Forms.RadioButton();
            this.lbl_MainTitale = new System.Windows.Forms.Label();
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.rb_SizeMeduim = new System.Windows.Forms.RadioButton();
            this.rb_SizeLarg = new System.Windows.Forms.RadioButton();
            this.rb_SizeSmail = new System.Windows.Forms.RadioButton();
            this.gb_CrustType = new System.Windows.Forms.GroupBox();
            this.rb_ThinCrust = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.chk_GreenPeppers = new System.Windows.Forms.CheckBox();
            this.chk_Olives = new System.Windows.Forms.CheckBox();
            this.chk_Onion = new System.Windows.Forms.CheckBox();
            this.chk_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chk_Mushrooms = new System.Windows.Forms.CheckBox();
            this.chk_ExtraChees = new System.Windows.Forms.CheckBox();
            this.gb_whrToEat = new System.Windows.Forms.GroupBox();
            this.rb_EatIn = new System.Windows.Forms.RadioButton();
            this.btn_OrderPizza = new System.Windows.Forms.Button();
            this.btn_ResetForm = new System.Windows.Forms.Button();
            this.gb_OrderSummary = new System.Windows.Forms.GroupBox();
            this.txt_ToppingsValue = new System.Windows.Forms.TextBox();
            this.lbl_PriceValue = new System.Windows.Forms.Label();
            this.lbl_WhrToEatValue = new System.Windows.Forms.Label();
            this.lbl_CrustTypeValue = new System.Windows.Forms.Label();
            this.lbl_SizeValue = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.lbl_whrToEat = new System.Windows.Forms.Label();
            this.lbl_Crust_Type = new System.Windows.Forms.Label();
            this.lbl_Toppings = new System.Windows.Forms.Label();
            this.lbl_Size = new System.Windows.Forms.Label();
            this.numUDo_CounterOrede = new System.Windows.Forms.NumericUpDown();
            this.gb_Size.SuspendLayout();
            this.gb_CrustType.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_whrToEat.SuspendLayout();
            this.gb_OrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDo_CounterOrede)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_ThinkCrust
            // 
            this.rb_ThinkCrust.AutoSize = true;
            this.rb_ThinkCrust.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ThinkCrust.ForeColor = System.Drawing.Color.Black;
            this.rb_ThinkCrust.Location = new System.Drawing.Point(6, 82);
            this.rb_ThinkCrust.Name = "rb_ThinkCrust";
            this.rb_ThinkCrust.Size = new System.Drawing.Size(129, 24);
            this.rb_ThinkCrust.TabIndex = 3;
            this.rb_ThinkCrust.TabStop = true;
            this.rb_ThinkCrust.Tag = "10";
            this.rb_ThinkCrust.Text = "Think Crust";
            this.rb_ThinkCrust.UseVisualStyleBackColor = true;
            this.rb_ThinkCrust.CheckedChanged += new System.EventHandler(this.rb_ThinkCrust_CheckedChanged);
            // 
            // rb_TakeOut
            // 
            this.rb_TakeOut.AutoSize = true;
            this.rb_TakeOut.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_TakeOut.ForeColor = System.Drawing.Color.Black;
            this.rb_TakeOut.Location = new System.Drawing.Point(6, 82);
            this.rb_TakeOut.Name = "rb_TakeOut";
            this.rb_TakeOut.Size = new System.Drawing.Size(105, 24);
            this.rb_TakeOut.TabIndex = 3;
            this.rb_TakeOut.TabStop = true;
            this.rb_TakeOut.Text = "Take Out";
            this.rb_TakeOut.UseVisualStyleBackColor = true;
            this.rb_TakeOut.CheckedChanged += new System.EventHandler(this.rb_TakeOut_CheckedChanged);
            // 
            // lbl_MainTitale
            // 
            this.lbl_MainTitale.AutoSize = true;
            this.lbl_MainTitale.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MainTitale.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_MainTitale.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MainTitale.ForeColor = System.Drawing.Color.Red;
            this.lbl_MainTitale.Location = new System.Drawing.Point(427, 41);
            this.lbl_MainTitale.Name = "lbl_MainTitale";
            this.lbl_MainTitale.Size = new System.Drawing.Size(396, 48);
            this.lbl_MainTitale.TabIndex = 0;
            this.lbl_MainTitale.Text = "MAKE YOUR PIZZA";
            // 
            // gb_Size
            // 
            this.gb_Size.BackColor = System.Drawing.Color.Transparent;
            this.gb_Size.Controls.Add(this.rb_SizeMeduim);
            this.gb_Size.Controls.Add(this.rb_SizeLarg);
            this.gb_Size.Controls.Add(this.rb_SizeSmail);
            this.gb_Size.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Size.ForeColor = System.Drawing.Color.Red;
            this.gb_Size.Location = new System.Drawing.Point(35, 155);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Size = new System.Drawing.Size(200, 159);
            this.gb_Size.TabIndex = 1;
            this.gb_Size.TabStop = false;
            this.gb_Size.Text = "Size";
            // 
            // rb_SizeMeduim
            // 
            this.rb_SizeMeduim.AutoSize = true;
            this.rb_SizeMeduim.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SizeMeduim.ForeColor = System.Drawing.Color.Black;
            this.rb_SizeMeduim.Location = new System.Drawing.Point(6, 82);
            this.rb_SizeMeduim.Name = "rb_SizeMeduim";
            this.rb_SizeMeduim.Size = new System.Drawing.Size(98, 24);
            this.rb_SizeMeduim.TabIndex = 4;
            this.rb_SizeMeduim.TabStop = true;
            this.rb_SizeMeduim.Tag = "30";
            this.rb_SizeMeduim.Text = "Meduim";
            this.rb_SizeMeduim.UseVisualStyleBackColor = true;
            this.rb_SizeMeduim.CheckedChanged += new System.EventHandler(this.rb_SizeMeduim_CheckedChanged);
            // 
            // rb_SizeLarg
            // 
            this.rb_SizeLarg.AutoSize = true;
            this.rb_SizeLarg.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SizeLarg.ForeColor = System.Drawing.Color.Black;
            this.rb_SizeLarg.Location = new System.Drawing.Point(6, 112);
            this.rb_SizeLarg.Name = "rb_SizeLarg";
            this.rb_SizeLarg.Size = new System.Drawing.Size(67, 24);
            this.rb_SizeLarg.TabIndex = 3;
            this.rb_SizeLarg.TabStop = true;
            this.rb_SizeLarg.Tag = "40";
            this.rb_SizeLarg.Text = "Larg";
            this.rb_SizeLarg.UseVisualStyleBackColor = true;
            this.rb_SizeLarg.CheckedChanged += new System.EventHandler(this.rb_SizeLarg_CheckedChanged);
            // 
            // rb_SizeSmail
            // 
            this.rb_SizeSmail.AutoSize = true;
            this.rb_SizeSmail.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SizeSmail.ForeColor = System.Drawing.Color.Black;
            this.rb_SizeSmail.Location = new System.Drawing.Point(6, 52);
            this.rb_SizeSmail.Name = "rb_SizeSmail";
            this.rb_SizeSmail.Size = new System.Drawing.Size(79, 24);
            this.rb_SizeSmail.TabIndex = 2;
            this.rb_SizeSmail.TabStop = true;
            this.rb_SizeSmail.Tag = "20";
            this.rb_SizeSmail.Text = "Smail";
            this.rb_SizeSmail.UseVisualStyleBackColor = true;
            this.rb_SizeSmail.CheckedChanged += new System.EventHandler(this.rb_SizeSmail_CheckedChanged);
            // 
            // gb_CrustType
            // 
            this.gb_CrustType.BackColor = System.Drawing.Color.Transparent;
            this.gb_CrustType.Controls.Add(this.rb_ThinkCrust);
            this.gb_CrustType.Controls.Add(this.rb_ThinCrust);
            this.gb_CrustType.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CrustType.ForeColor = System.Drawing.Color.Red;
            this.gb_CrustType.Location = new System.Drawing.Point(35, 347);
            this.gb_CrustType.Name = "gb_CrustType";
            this.gb_CrustType.Size = new System.Drawing.Size(200, 159);
            this.gb_CrustType.TabIndex = 4;
            this.gb_CrustType.TabStop = false;
            this.gb_CrustType.Text = "Crust Type";
            // 
            // rb_ThinCrust
            // 
            this.rb_ThinCrust.AutoSize = true;
            this.rb_ThinCrust.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ThinCrust.ForeColor = System.Drawing.Color.Black;
            this.rb_ThinCrust.Location = new System.Drawing.Point(6, 52);
            this.rb_ThinCrust.Name = "rb_ThinCrust";
            this.rb_ThinCrust.Size = new System.Drawing.Size(119, 24);
            this.rb_ThinCrust.TabIndex = 2;
            this.rb_ThinCrust.TabStop = true;
            this.rb_ThinCrust.Tag = "5";
            this.rb_ThinCrust.Text = "Thin Crust";
            this.rb_ThinCrust.UseVisualStyleBackColor = true;
            this.rb_ThinCrust.CheckedChanged += new System.EventHandler(this.rb_ThinCrust_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.gb_Toppings.Controls.Add(this.chk_GreenPeppers);
            this.gb_Toppings.Controls.Add(this.chk_Olives);
            this.gb_Toppings.Controls.Add(this.chk_Onion);
            this.gb_Toppings.Controls.Add(this.chk_Tomatoes);
            this.gb_Toppings.Controls.Add(this.chk_Mushrooms);
            this.gb_Toppings.Controls.Add(this.chk_ExtraChees);
            this.gb_Toppings.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Toppings.ForeColor = System.Drawing.Color.Red;
            this.gb_Toppings.Location = new System.Drawing.Point(318, 155);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Size = new System.Drawing.Size(358, 159);
            this.gb_Toppings.TabIndex = 4;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // chk_GreenPeppers
            // 
            this.chk_GreenPeppers.AutoSize = true;
            this.chk_GreenPeppers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_GreenPeppers.ForeColor = System.Drawing.Color.Black;
            this.chk_GreenPeppers.Location = new System.Drawing.Point(193, 115);
            this.chk_GreenPeppers.Name = "chk_GreenPeppers";
            this.chk_GreenPeppers.Size = new System.Drawing.Size(156, 24);
            this.chk_GreenPeppers.TabIndex = 5;
            this.chk_GreenPeppers.Tag = "5";
            this.chk_GreenPeppers.Text = "Green Peppers";
            this.chk_GreenPeppers.UseVisualStyleBackColor = true;
            this.chk_GreenPeppers.CheckedChanged += new System.EventHandler(this.chk_GreenPeppers_CheckedChanged);
            // 
            // chk_Olives
            // 
            this.chk_Olives.AutoSize = true;
            this.chk_Olives.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Olives.ForeColor = System.Drawing.Color.Black;
            this.chk_Olives.Location = new System.Drawing.Point(193, 85);
            this.chk_Olives.Name = "chk_Olives";
            this.chk_Olives.Size = new System.Drawing.Size(83, 24);
            this.chk_Olives.TabIndex = 4;
            this.chk_Olives.Tag = "5";
            this.chk_Olives.Text = "Olives";
            this.chk_Olives.UseVisualStyleBackColor = true;
            this.chk_Olives.CheckedChanged += new System.EventHandler(this.chk_Olives_CheckedChanged);
            // 
            // chk_Onion
            // 
            this.chk_Onion.AutoSize = true;
            this.chk_Onion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Onion.ForeColor = System.Drawing.Color.Black;
            this.chk_Onion.Location = new System.Drawing.Point(193, 55);
            this.chk_Onion.Name = "chk_Onion";
            this.chk_Onion.Size = new System.Drawing.Size(81, 24);
            this.chk_Onion.TabIndex = 3;
            this.chk_Onion.Tag = "5";
            this.chk_Onion.Text = "Onion";
            this.chk_Onion.UseVisualStyleBackColor = true;
            this.chk_Onion.CheckedChanged += new System.EventHandler(this.chk_Onion_CheckedChanged);
            // 
            // chk_Tomatoes
            // 
            this.chk_Tomatoes.AutoSize = true;
            this.chk_Tomatoes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Tomatoes.ForeColor = System.Drawing.Color.Black;
            this.chk_Tomatoes.Location = new System.Drawing.Point(17, 115);
            this.chk_Tomatoes.Name = "chk_Tomatoes";
            this.chk_Tomatoes.Size = new System.Drawing.Size(112, 24);
            this.chk_Tomatoes.TabIndex = 2;
            this.chk_Tomatoes.Tag = "5";
            this.chk_Tomatoes.Text = "Tomatoes";
            this.chk_Tomatoes.UseVisualStyleBackColor = true;
            this.chk_Tomatoes.CheckedChanged += new System.EventHandler(this.chk_Tomatoes_CheckedChanged);
            // 
            // chk_Mushrooms
            // 
            this.chk_Mushrooms.AutoSize = true;
            this.chk_Mushrooms.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Mushrooms.ForeColor = System.Drawing.Color.Black;
            this.chk_Mushrooms.Location = new System.Drawing.Point(17, 85);
            this.chk_Mushrooms.Name = "chk_Mushrooms";
            this.chk_Mushrooms.Size = new System.Drawing.Size(129, 24);
            this.chk_Mushrooms.TabIndex = 1;
            this.chk_Mushrooms.Tag = "5";
            this.chk_Mushrooms.Text = "Mushrooms";
            this.chk_Mushrooms.UseVisualStyleBackColor = true;
            this.chk_Mushrooms.CheckedChanged += new System.EventHandler(this.chk_Mushrooms_CheckedChanged);
            // 
            // chk_ExtraChees
            // 
            this.chk_ExtraChees.AutoSize = true;
            this.chk_ExtraChees.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ExtraChees.ForeColor = System.Drawing.Color.Black;
            this.chk_ExtraChees.Location = new System.Drawing.Point(17, 55);
            this.chk_ExtraChees.Name = "chk_ExtraChees";
            this.chk_ExtraChees.Size = new System.Drawing.Size(134, 24);
            this.chk_ExtraChees.TabIndex = 0;
            this.chk_ExtraChees.Tag = "5";
            this.chk_ExtraChees.Text = "Extra Chees";
            this.chk_ExtraChees.UseVisualStyleBackColor = true;
            this.chk_ExtraChees.CheckedChanged += new System.EventHandler(this.chk_ExtraChees_CheckedChanged);
            // 
            // gb_whrToEat
            // 
            this.gb_whrToEat.BackColor = System.Drawing.Color.Transparent;
            this.gb_whrToEat.Controls.Add(this.rb_TakeOut);
            this.gb_whrToEat.Controls.Add(this.rb_EatIn);
            this.gb_whrToEat.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_whrToEat.ForeColor = System.Drawing.Color.Red;
            this.gb_whrToEat.Location = new System.Drawing.Point(318, 347);
            this.gb_whrToEat.Name = "gb_whrToEat";
            this.gb_whrToEat.Size = new System.Drawing.Size(358, 159);
            this.gb_whrToEat.TabIndex = 5;
            this.gb_whrToEat.TabStop = false;
            this.gb_whrToEat.Text = "Where To Eat ";
            // 
            // rb_EatIn
            // 
            this.rb_EatIn.AutoSize = true;
            this.rb_EatIn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_EatIn.ForeColor = System.Drawing.Color.Black;
            this.rb_EatIn.Location = new System.Drawing.Point(6, 52);
            this.rb_EatIn.Name = "rb_EatIn";
            this.rb_EatIn.Size = new System.Drawing.Size(83, 24);
            this.rb_EatIn.TabIndex = 2;
            this.rb_EatIn.TabStop = true;
            this.rb_EatIn.Text = "Eat In";
            this.rb_EatIn.UseVisualStyleBackColor = true;
            this.rb_EatIn.CheckedChanged += new System.EventHandler(this.rb_EatIn_CheckedChanged);
            // 
            // btn_OrderPizza
            // 
            this.btn_OrderPizza.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_OrderPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_OrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btn_OrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderPizza.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderPizza.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_OrderPizza.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_OrderPizza.Location = new System.Drawing.Point(786, 540);
            this.btn_OrderPizza.Name = "btn_OrderPizza";
            this.btn_OrderPizza.Size = new System.Drawing.Size(146, 47);
            this.btn_OrderPizza.TabIndex = 6;
            this.btn_OrderPizza.Text = "Order Pizza";
            this.btn_OrderPizza.UseVisualStyleBackColor = false;
            this.btn_OrderPizza.Click += new System.EventHandler(this.btn_OrderPizza_Click);
            // 
            // btn_ResetForm
            // 
            this.btn_ResetForm.BackColor = System.Drawing.Color.Red;
            this.btn_ResetForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_ResetForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetForm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ResetForm.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ResetForm.Location = new System.Drawing.Point(1074, 540);
            this.btn_ResetForm.Name = "btn_ResetForm";
            this.btn_ResetForm.Size = new System.Drawing.Size(146, 47);
            this.btn_ResetForm.TabIndex = 7;
            this.btn_ResetForm.Text = "Reset Form";
            this.btn_ResetForm.UseVisualStyleBackColor = false;
            this.btn_ResetForm.Click += new System.EventHandler(this.btn_ResetForm_Click);
            // 
            // gb_OrderSummary
            // 
            this.gb_OrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gb_OrderSummary.Controls.Add(this.numUDo_CounterOrede);
            this.gb_OrderSummary.Controls.Add(this.txt_ToppingsValue);
            this.gb_OrderSummary.Controls.Add(this.lbl_PriceValue);
            this.gb_OrderSummary.Controls.Add(this.lbl_WhrToEatValue);
            this.gb_OrderSummary.Controls.Add(this.lbl_CrustTypeValue);
            this.gb_OrderSummary.Controls.Add(this.lbl_SizeValue);
            this.gb_OrderSummary.Controls.Add(this.lbl_TotalPrice);
            this.gb_OrderSummary.Controls.Add(this.lbl_whrToEat);
            this.gb_OrderSummary.Controls.Add(this.lbl_Crust_Type);
            this.gb_OrderSummary.Controls.Add(this.lbl_Toppings);
            this.gb_OrderSummary.Controls.Add(this.lbl_Size);
            this.gb_OrderSummary.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_OrderSummary.ForeColor = System.Drawing.Color.Red;
            this.gb_OrderSummary.Location = new System.Drawing.Point(786, 155);
            this.gb_OrderSummary.Name = "gb_OrderSummary";
            this.gb_OrderSummary.Size = new System.Drawing.Size(434, 351);
            this.gb_OrderSummary.TabIndex = 8;
            this.gb_OrderSummary.TabStop = false;
            this.gb_OrderSummary.Text = "Order Summary";
            // 
            // txt_ToppingsValue
            // 
            this.txt_ToppingsValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ToppingsValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ToppingsValue.Location = new System.Drawing.Point(30, 114);
            this.txt_ToppingsValue.Multiline = true;
            this.txt_ToppingsValue.Name = "txt_ToppingsValue";
            this.txt_ToppingsValue.ReadOnly = true;
            this.txt_ToppingsValue.Size = new System.Drawing.Size(354, 45);
            this.txt_ToppingsValue.TabIndex = 10;
            // 
            // lbl_PriceValue
            // 
            this.lbl_PriceValue.AutoSize = true;
            this.lbl_PriceValue.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PriceValue.ForeColor = System.Drawing.Color.Green;
            this.lbl_PriceValue.Location = new System.Drawing.Point(175, 264);
            this.lbl_PriceValue.Name = "lbl_PriceValue";
            this.lbl_PriceValue.Size = new System.Drawing.Size(76, 48);
            this.lbl_PriceValue.TabIndex = 9;
            this.lbl_PriceValue.Text = "$0";
            // 
            // lbl_WhrToEatValue
            // 
            this.lbl_WhrToEatValue.AutoSize = true;
            this.lbl_WhrToEatValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WhrToEatValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_WhrToEatValue.Location = new System.Drawing.Point(165, 202);
            this.lbl_WhrToEatValue.Name = "lbl_WhrToEatValue";
            this.lbl_WhrToEatValue.Size = new System.Drawing.Size(0, 20);
            this.lbl_WhrToEatValue.TabIndex = 8;
            // 
            // lbl_CrustTypeValue
            // 
            this.lbl_CrustTypeValue.AutoSize = true;
            this.lbl_CrustTypeValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CrustTypeValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_CrustTypeValue.Location = new System.Drawing.Point(139, 162);
            this.lbl_CrustTypeValue.Name = "lbl_CrustTypeValue";
            this.lbl_CrustTypeValue.Size = new System.Drawing.Size(0, 20);
            this.lbl_CrustTypeValue.TabIndex = 7;
            // 
            // lbl_SizeValue
            // 
            this.lbl_SizeValue.AutoSize = true;
            this.lbl_SizeValue.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeValue.ForeColor = System.Drawing.Color.Black;
            this.lbl_SizeValue.Location = new System.Drawing.Point(78, 52);
            this.lbl_SizeValue.Name = "lbl_SizeValue";
            this.lbl_SizeValue.Size = new System.Drawing.Size(0, 20);
            this.lbl_SizeValue.TabIndex = 5;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lbl_TotalPrice.Location = new System.Drawing.Point(15, 264);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(118, 20);
            this.lbl_TotalPrice.TabIndex = 4;
            this.lbl_TotalPrice.Text = "Total Price:";
            this.lbl_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_whrToEat
            // 
            this.lbl_whrToEat.AutoSize = true;
            this.lbl_whrToEat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_whrToEat.ForeColor = System.Drawing.Color.Black;
            this.lbl_whrToEat.Location = new System.Drawing.Point(15, 202);
            this.lbl_whrToEat.Name = "lbl_whrToEat";
            this.lbl_whrToEat.Size = new System.Drawing.Size(144, 20);
            this.lbl_whrToEat.TabIndex = 3;
            this.lbl_whrToEat.Text = "Where To Eat:";
            this.lbl_whrToEat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Crust_Type
            // 
            this.lbl_Crust_Type.AutoSize = true;
            this.lbl_Crust_Type.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Crust_Type.ForeColor = System.Drawing.Color.Black;
            this.lbl_Crust_Type.Location = new System.Drawing.Point(15, 162);
            this.lbl_Crust_Type.Name = "lbl_Crust_Type";
            this.lbl_Crust_Type.Size = new System.Drawing.Size(118, 20);
            this.lbl_Crust_Type.TabIndex = 2;
            this.lbl_Crust_Type.Text = "Crust Type:";
            this.lbl_Crust_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Toppings
            // 
            this.lbl_Toppings.AutoSize = true;
            this.lbl_Toppings.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Toppings.ForeColor = System.Drawing.Color.Black;
            this.lbl_Toppings.Location = new System.Drawing.Point(15, 89);
            this.lbl_Toppings.Name = "lbl_Toppings";
            this.lbl_Toppings.Size = new System.Drawing.Size(104, 20);
            this.lbl_Toppings.TabIndex = 1;
            this.lbl_Toppings.Text = "Toppings:";
            this.lbl_Toppings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Size
            // 
            this.lbl_Size.AutoSize = true;
            this.lbl_Size.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Size.ForeColor = System.Drawing.Color.Black;
            this.lbl_Size.Location = new System.Drawing.Point(15, 52);
            this.lbl_Size.Name = "lbl_Size";
            this.lbl_Size.Size = new System.Drawing.Size(55, 20);
            this.lbl_Size.TabIndex = 0;
            this.lbl_Size.Text = "Size:";
            // 
            // numUDo_CounterOrede
            // 
            this.numUDo_CounterOrede.Location = new System.Drawing.Point(314, 305);
            this.numUDo_CounterOrede.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDo_CounterOrede.Name = "numUDo_CounterOrede";
            this.numUDo_CounterOrede.ReadOnly = true;
            this.numUDo_CounterOrede.Size = new System.Drawing.Size(120, 40);
            this.numUDo_CounterOrede.TabIndex = 9;
            this.numUDo_CounterOrede.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDo_CounterOrede.ValueChanged += new System.EventHandler(this.numUDo_CounterOrede_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1361, 667);
            this.Controls.Add(this.gb_OrderSummary);
            this.Controls.Add(this.btn_ResetForm);
            this.Controls.Add(this.btn_OrderPizza);
            this.Controls.Add(this.gb_whrToEat);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_CrustType);
            this.Controls.Add(this.gb_Size);
            this.Controls.Add(this.lbl_MainTitale);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Pizza Oreder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            this.gb_CrustType.ResumeLayout(false);
            this.gb_CrustType.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_whrToEat.ResumeLayout(false);
            this.gb_whrToEat.PerformLayout();
            this.gb_OrderSummary.ResumeLayout(false);
            this.gb_OrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDo_CounterOrede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MainTitale;
        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.RadioButton rb_SizeSmail;
        private System.Windows.Forms.RadioButton rb_SizeLarg;
        private System.Windows.Forms.GroupBox gb_CrustType;
        private System.Windows.Forms.RadioButton rb_ThinCrust;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.CheckBox chk_ExtraChees;
        private System.Windows.Forms.CheckBox chk_Tomatoes;
        private System.Windows.Forms.CheckBox chk_Mushrooms;
        private System.Windows.Forms.CheckBox chk_GreenPeppers;
        private System.Windows.Forms.CheckBox chk_Olives;
        private System.Windows.Forms.CheckBox chk_Onion;
        private System.Windows.Forms.GroupBox gb_whrToEat;
        private System.Windows.Forms.RadioButton rb_EatIn;
        private System.Windows.Forms.Button btn_OrderPizza;
        private System.Windows.Forms.Button btn_ResetForm;
        private System.Windows.Forms.GroupBox gb_OrderSummary;
        private System.Windows.Forms.Label lbl_Size;
        private System.Windows.Forms.Label lbl_Toppings;
        private System.Windows.Forms.Label lbl_Crust_Type;
        private System.Windows.Forms.Label lbl_whrToEat;
        private System.Windows.Forms.Label lbl_WhrToEatValue;
        private System.Windows.Forms.Label lbl_CrustTypeValue;
        private System.Windows.Forms.Label lbl_SizeValue;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label lbl_PriceValue;
        private System.Windows.Forms.RadioButton rb_SizeMeduim;
        private System.Windows.Forms.RadioButton rb_ThinkCrust;
        private System.Windows.Forms.RadioButton rb_TakeOut;
        private System.Windows.Forms.TextBox txt_ToppingsValue;
        private System.Windows.Forms.NumericUpDown numUDo_CounterOrede;
    }
}

