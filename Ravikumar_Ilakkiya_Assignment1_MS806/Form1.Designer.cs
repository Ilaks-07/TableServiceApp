namespace Ilaks_Assignment_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Welcome_panel = new System.Windows.Forms.Panel();
            this.startbtn = new System.Windows.Forms.Button();
            this.Table_no = new System.Windows.Forms.Label();
            this.Table_txtbox = new System.Windows.Forms.TextBox();
            this.Name_txtbox = new System.Windows.Forms.TextBox();
            this.server_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ham_txtbox = new System.Windows.Forms.Label();
            this.Pepparoni_price = new System.Windows.Forms.Label();
            this.Margherita_price = new System.Windows.Forms.Label();
            this.Ham_pineapple_txtbox = new System.Windows.Forms.TextBox();
            this.Pepparoni_pizza_txtbox = new System.Windows.Forms.TextBox();
            this.Margherita_pizza_txtbox = new System.Windows.Forms.TextBox();
            this.Ham_pineapple = new System.Windows.Forms.Label();
            this.Pepparoni_pizza = new System.Windows.Forms.Label();
            this.Margherita_pizza = new System.Windows.Forms.Label();
            this.pizza_menu = new System.Windows.Forms.Label();
            this.Button_panel = new System.Windows.Forms.Panel();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Summarybtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Orderbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pizzamenu_panel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.total_receipt_txtbox = new System.Windows.Forms.TextBox();
            this.total_pizza_txtbox = new System.Windows.Forms.TextBox();
            this.Server_txtbox = new System.Windows.Forms.TextBox();
            this.Total_receipt = new System.Windows.Forms.Label();
            this.Total_pizza = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Label();
            this.Order_panel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Avg_transaction_txtBox = new System.Windows.Forms.TextBox();
            this.Total_company_receipt_txtBox = new System.Windows.Forms.TextBox();
            this.Total_company_pizza_txtBox = new System.Windows.Forms.TextBox();
            this.Company_transaction_txtBox = new System.Windows.Forms.TextBox();
            this.Avg_transaction = new System.Windows.Forms.Label();
            this.Total_company_receipt = new System.Windows.Forms.Label();
            this.Total_company_pizza = new System.Windows.Forms.Label();
            this.Company_transactions = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Summary_panel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Welcome_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Button_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pizzamenu_panel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Order_panel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Summary_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome_panel
            // 
            this.Welcome_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Welcome_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Welcome_panel.Controls.Add(this.startbtn);
            this.Welcome_panel.Controls.Add(this.Table_no);
            this.Welcome_panel.Controls.Add(this.Table_txtbox);
            this.Welcome_panel.Controls.Add(this.Name_txtbox);
            this.Welcome_panel.Controls.Add(this.server_name);
            this.Welcome_panel.Location = new System.Drawing.Point(35, 29);
            this.Welcome_panel.Name = "Welcome_panel";
            this.Welcome_panel.Size = new System.Drawing.Size(727, 83);
            this.Welcome_panel.TabIndex = 0;
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(555, 22);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(133, 34);
            this.startbtn.TabIndex = 4;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // Table_no
            // 
            this.Table_no.AutoSize = true;
            this.Table_no.Location = new System.Drawing.Point(339, 28);
            this.Table_no.Name = "Table_no";
            this.Table_no.Size = new System.Drawing.Size(76, 20);
            this.Table_no.TabIndex = 3;
            this.Table_no.Text = "Table No:";
            // 
            // Table_txtbox
            // 
            this.Table_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Table_txtbox.Location = new System.Drawing.Point(421, 25);
            this.Table_txtbox.MaxLength = 1;
            this.Table_txtbox.Name = "Table_txtbox";
            this.Table_txtbox.Size = new System.Drawing.Size(61, 26);
            this.Table_txtbox.TabIndex = 2;
            this.Table_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Table_txtbox.TextChanged += new System.EventHandler(this.Table_txtbox_TextChanged);
            this.Table_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Table_txtbox_KeyPress);
            // 
            // Name_txtbox
            // 
            this.Name_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_txtbox.Location = new System.Drawing.Point(128, 26);
            this.Name_txtbox.MaxLength = 35;
            this.Name_txtbox.Name = "Name_txtbox";
            this.Name_txtbox.Size = new System.Drawing.Size(177, 26);
            this.Name_txtbox.TabIndex = 1;
            this.Name_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_txtbox_KeyPress);
            // 
            // server_name
            // 
            this.server_name.AutoSize = true;
            this.server_name.Location = new System.Drawing.Point(17, 28);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(105, 20);
            this.server_name.TabIndex = 0;
            this.server_name.Text = "Server Name:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Ham_txtbox);
            this.panel2.Controls.Add(this.Pepparoni_price);
            this.panel2.Controls.Add(this.Margherita_price);
            this.panel2.Controls.Add(this.Ham_pineapple_txtbox);
            this.panel2.Controls.Add(this.Pepparoni_pizza_txtbox);
            this.panel2.Controls.Add(this.Margherita_pizza_txtbox);
            this.panel2.Controls.Add(this.Ham_pineapple);
            this.panel2.Controls.Add(this.Pepparoni_pizza);
            this.panel2.Controls.Add(this.Margherita_pizza);
            this.panel2.Location = new System.Drawing.Point(55, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 200);
            this.panel2.TabIndex = 1;
            // 
            // Ham_txtbox
            // 
            this.Ham_txtbox.AutoSize = true;
            this.Ham_txtbox.Location = new System.Drawing.Point(350, 136);
            this.Ham_txtbox.Name = "Ham_txtbox";
            this.Ham_txtbox.Size = new System.Drawing.Size(78, 20);
            this.Ham_txtbox.TabIndex = 8;
            this.Ham_txtbox.Text = "@ €12.79";
            // 
            // Pepparoni_price
            // 
            this.Pepparoni_price.AutoSize = true;
            this.Pepparoni_price.Location = new System.Drawing.Point(350, 88);
            this.Pepparoni_price.Name = "Pepparoni_price";
            this.Pepparoni_price.Size = new System.Drawing.Size(78, 20);
            this.Pepparoni_price.TabIndex = 7;
            this.Pepparoni_price.Text = "@ €11.50";
            // 
            // Margherita_price
            // 
            this.Margherita_price.AutoSize = true;
            this.Margherita_price.Location = new System.Drawing.Point(350, 38);
            this.Margherita_price.Name = "Margherita_price";
            this.Margherita_price.Size = new System.Drawing.Size(47, 20);
            this.Margherita_price.TabIndex = 6;
            this.Margherita_price.Text = "@ €9";
            // 
            // Ham_pineapple_txtbox
            // 
            this.Ham_pineapple_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ham_pineapple_txtbox.Location = new System.Drawing.Point(230, 133);
            this.Ham_pineapple_txtbox.Name = "Ham_pineapple_txtbox";
            this.Ham_pineapple_txtbox.Size = new System.Drawing.Size(60, 26);
            this.Ham_pineapple_txtbox.TabIndex = 5;
            this.Ham_pineapple_txtbox.Text = "0";
            this.Ham_pineapple_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pepparoni_pizza_txtbox
            // 
            this.Pepparoni_pizza_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pepparoni_pizza_txtbox.Location = new System.Drawing.Point(230, 88);
            this.Pepparoni_pizza_txtbox.Name = "Pepparoni_pizza_txtbox";
            this.Pepparoni_pizza_txtbox.Size = new System.Drawing.Size(60, 26);
            this.Pepparoni_pizza_txtbox.TabIndex = 4;
            this.Pepparoni_pizza_txtbox.Text = "0";
            this.Pepparoni_pizza_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Margherita_pizza_txtbox
            // 
            this.Margherita_pizza_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margherita_pizza_txtbox.Location = new System.Drawing.Point(230, 38);
            this.Margherita_pizza_txtbox.Name = "Margherita_pizza_txtbox";
            this.Margherita_pizza_txtbox.Size = new System.Drawing.Size(60, 26);
            this.Margherita_pizza_txtbox.TabIndex = 3;
            this.Margherita_pizza_txtbox.Text = "0";
            this.Margherita_pizza_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ham_pineapple
            // 
            this.Ham_pineapple.AutoSize = true;
            this.Ham_pineapple.Location = new System.Drawing.Point(68, 133);
            this.Ham_pineapple.Name = "Ham_pineapple";
            this.Ham_pineapple.Size = new System.Drawing.Size(117, 20);
            this.Ham_pineapple.TabIndex = 2;
            this.Ham_pineapple.Text = "Ham Pineapple";
            // 
            // Pepparoni_pizza
            // 
            this.Pepparoni_pizza.AutoSize = true;
            this.Pepparoni_pizza.Location = new System.Drawing.Point(68, 88);
            this.Pepparoni_pizza.Name = "Pepparoni_pizza";
            this.Pepparoni_pizza.Size = new System.Drawing.Size(123, 20);
            this.Pepparoni_pizza.TabIndex = 1;
            this.Pepparoni_pizza.Text = "Pepparoni Pizza";
            // 
            // Margherita_pizza
            // 
            this.Margherita_pizza.AutoSize = true;
            this.Margherita_pizza.Location = new System.Drawing.Point(68, 38);
            this.Margherita_pizza.Name = "Margherita_pizza";
            this.Margherita_pizza.Size = new System.Drawing.Size(127, 20);
            this.Margherita_pizza.TabIndex = 0;
            this.Margherita_pizza.Text = "Margherita Pizza";
            // 
            // pizza_menu
            // 
            this.pizza_menu.AutoSize = true;
            this.pizza_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizza_menu.Location = new System.Drawing.Point(85, 8);
            this.pizza_menu.Name = "pizza_menu";
            this.pizza_menu.Size = new System.Drawing.Size(101, 20);
            this.pizza_menu.TabIndex = 0;
            this.pizza_menu.Text = "Pizza Menu";
            // 
            // Button_panel
            // 
            this.Button_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button_panel.Controls.Add(this.Exitbtn);
            this.Button_panel.Controls.Add(this.Summarybtn);
            this.Button_panel.Controls.Add(this.Clearbtn);
            this.Button_panel.Controls.Add(this.Orderbtn);
            this.Button_panel.Location = new System.Drawing.Point(90, 274);
            this.Button_panel.Name = "Button_panel";
            this.Button_panel.Size = new System.Drawing.Size(535, 80);
            this.Button_panel.TabIndex = 2;
            this.Button_panel.Visible = false;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exitbtn.Location = new System.Drawing.Point(406, 23);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(111, 34);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "E&xit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Summarybtn
            // 
            this.Summarybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Summarybtn.Location = new System.Drawing.Point(278, 23);
            this.Summarybtn.Name = "Summarybtn";
            this.Summarybtn.Size = new System.Drawing.Size(111, 34);
            this.Summarybtn.TabIndex = 2;
            this.Summarybtn.Text = "&Summary";
            this.Summarybtn.UseVisualStyleBackColor = false;
            this.Summarybtn.Click += new System.EventHandler(this.Summarybtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Clearbtn.Location = new System.Drawing.Point(149, 23);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(111, 34);
            this.Clearbtn.TabIndex = 1;
            this.Clearbtn.Text = "&Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Orderbtn
            // 
            this.Orderbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orderbtn.Location = new System.Drawing.Point(20, 23);
            this.Orderbtn.Name = "Orderbtn";
            this.Orderbtn.Size = new System.Drawing.Size(111, 34);
            this.Orderbtn.TabIndex = 0;
            this.Orderbtn.Text = "&Order";
            this.Orderbtn.UseVisualStyleBackColor = false;
            this.Orderbtn.Click += new System.EventHandler(this.Orderbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 681);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pizzamenu_panel
            // 
            this.pizzamenu_panel.Controls.Add(this.pizza_menu);
            this.pizzamenu_panel.Controls.Add(this.panel2);
            this.pizzamenu_panel.Location = new System.Drawing.Point(39, 19);
            this.pizzamenu_panel.Name = "pizzamenu_panel";
            this.pizzamenu_panel.Size = new System.Drawing.Size(642, 249);
            this.pizzamenu_panel.TabIndex = 4;
            this.pizzamenu_panel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.total_receipt_txtbox);
            this.panel5.Controls.Add(this.total_pizza_txtbox);
            this.panel5.Controls.Add(this.Server_txtbox);
            this.panel5.Controls.Add(this.Total_receipt);
            this.panel5.Controls.Add(this.Total_pizza);
            this.panel5.Controls.Add(this.Server);
            this.panel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel5.Location = new System.Drawing.Point(12, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 248);
            this.panel5.TabIndex = 5;
            // 
            // total_receipt_txtbox
            // 
            this.total_receipt_txtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_receipt_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_receipt_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_receipt_txtbox.Location = new System.Drawing.Point(285, 146);
            this.total_receipt_txtbox.Multiline = true;
            this.total_receipt_txtbox.Name = "total_receipt_txtbox";
            this.total_receipt_txtbox.Size = new System.Drawing.Size(183, 28);
            this.total_receipt_txtbox.TabIndex = 5;
            this.total_receipt_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_pizza_txtbox
            // 
            this.total_pizza_txtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_pizza_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_pizza_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_pizza_txtbox.Location = new System.Drawing.Point(285, 89);
            this.total_pizza_txtbox.Multiline = true;
            this.total_pizza_txtbox.Name = "total_pizza_txtbox";
            this.total_pizza_txtbox.ReadOnly = true;
            this.total_pizza_txtbox.Size = new System.Drawing.Size(183, 28);
            this.total_pizza_txtbox.TabIndex = 4;
            this.total_pizza_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Server_txtbox
            // 
            this.Server_txtbox.BackColor = System.Drawing.SystemColors.Menu;
            this.Server_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Server_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Server_txtbox.Location = new System.Drawing.Point(285, 34);
            this.Server_txtbox.Multiline = true;
            this.Server_txtbox.Name = "Server_txtbox";
            this.Server_txtbox.ReadOnly = true;
            this.Server_txtbox.Size = new System.Drawing.Size(183, 30);
            this.Server_txtbox.TabIndex = 3;
            this.Server_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total_receipt
            // 
            this.Total_receipt.AutoSize = true;
            this.Total_receipt.Location = new System.Drawing.Point(46, 154);
            this.Total_receipt.Name = "Total_receipt";
            this.Total_receipt.Size = new System.Drawing.Size(154, 20);
            this.Total_receipt.TabIndex = 2;
            this.Total_receipt.Text = "Total Table Receipts";
            // 
            // Total_pizza
            // 
            this.Total_pizza.AutoSize = true;
            this.Total_pizza.Location = new System.Drawing.Point(46, 97);
            this.Total_pizza.Name = "Total_pizza";
            this.Total_pizza.Size = new System.Drawing.Size(157, 20);
            this.Total_pizza.TabIndex = 1;
            this.Total_pizza.Text = "Total Number Pizza\'s";
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(46, 36);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(101, 20);
            this.Server.TabIndex = 0;
            this.Server.Text = "Server Name";
            // 
            // Order
            // 
            this.Order.AutoSize = true;
            this.Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Location = new System.Drawing.Point(37, 7);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(226, 20);
            this.Order.TabIndex = 0;
            this.Order.Text = "Table Order Summary Data";
            // 
            // Order_panel
            // 
            this.Order_panel.Controls.Add(this.Order);
            this.Order_panel.Controls.Add(this.panel5);
            this.Order_panel.Location = new System.Drawing.Point(71, 390);
            this.Order_panel.Name = "Order_panel";
            this.Order_panel.Size = new System.Drawing.Size(563, 280);
            this.Order_panel.TabIndex = 6;
            this.Order_panel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.Avg_transaction_txtBox);
            this.panel7.Controls.Add(this.Total_company_receipt_txtBox);
            this.panel7.Controls.Add(this.Total_company_pizza_txtBox);
            this.panel7.Controls.Add(this.Company_transaction_txtBox);
            this.panel7.Controls.Add(this.Avg_transaction);
            this.panel7.Controls.Add(this.Total_company_receipt);
            this.panel7.Controls.Add(this.Total_company_pizza);
            this.panel7.Controls.Add(this.Company_transactions);
            this.panel7.Location = new System.Drawing.Point(6, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(559, 255);
            this.panel7.TabIndex = 7;
            // 
            // Avg_transaction_txtBox
            // 
            this.Avg_transaction_txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Avg_transaction_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avg_transaction_txtBox.Location = new System.Drawing.Point(282, 196);
            this.Avg_transaction_txtBox.Multiline = true;
            this.Avg_transaction_txtBox.Name = "Avg_transaction_txtBox";
            this.Avg_transaction_txtBox.ReadOnly = true;
            this.Avg_transaction_txtBox.Size = new System.Drawing.Size(208, 28);
            this.Avg_transaction_txtBox.TabIndex = 7;
            this.Avg_transaction_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total_company_receipt_txtBox
            // 
            this.Total_company_receipt_txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Total_company_receipt_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_company_receipt_txtBox.Location = new System.Drawing.Point(282, 146);
            this.Total_company_receipt_txtBox.Multiline = true;
            this.Total_company_receipt_txtBox.Name = "Total_company_receipt_txtBox";
            this.Total_company_receipt_txtBox.ReadOnly = true;
            this.Total_company_receipt_txtBox.Size = new System.Drawing.Size(208, 28);
            this.Total_company_receipt_txtBox.TabIndex = 6;
            this.Total_company_receipt_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Total_company_pizza_txtBox
            // 
            this.Total_company_pizza_txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Total_company_pizza_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_company_pizza_txtBox.Location = new System.Drawing.Point(282, 91);
            this.Total_company_pizza_txtBox.Multiline = true;
            this.Total_company_pizza_txtBox.Name = "Total_company_pizza_txtBox";
            this.Total_company_pizza_txtBox.ReadOnly = true;
            this.Total_company_pizza_txtBox.Size = new System.Drawing.Size(208, 29);
            this.Total_company_pizza_txtBox.TabIndex = 5;
            this.Total_company_pizza_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Company_transaction_txtBox
            // 
            this.Company_transaction_txtBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Company_transaction_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_transaction_txtBox.Location = new System.Drawing.Point(282, 33);
            this.Company_transaction_txtBox.Multiline = true;
            this.Company_transaction_txtBox.Name = "Company_transaction_txtBox";
            this.Company_transaction_txtBox.ReadOnly = true;
            this.Company_transaction_txtBox.Size = new System.Drawing.Size(208, 29);
            this.Company_transaction_txtBox.TabIndex = 4;
            this.Company_transaction_txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Avg_transaction
            // 
            this.Avg_transaction.AutoSize = true;
            this.Avg_transaction.Location = new System.Drawing.Point(55, 199);
            this.Avg_transaction.Name = "Avg_transaction";
            this.Avg_transaction.Size = new System.Drawing.Size(168, 20);
            this.Avg_transaction.TabIndex = 3;
            this.Avg_transaction.Text = "Avg Transaction Value";
            // 
            // Total_company_receipt
            // 
            this.Total_company_receipt.AutoSize = true;
            this.Total_company_receipt.Location = new System.Drawing.Point(55, 149);
            this.Total_company_receipt.Name = "Total_company_receipt";
            this.Total_company_receipt.Size = new System.Drawing.Size(182, 20);
            this.Total_company_receipt.TabIndex = 2;
            this.Total_company_receipt.Text = "Total Company Receipts";
            // 
            // Total_company_pizza
            // 
            this.Total_company_pizza.AutoSize = true;
            this.Total_company_pizza.Location = new System.Drawing.Point(55, 94);
            this.Total_company_pizza.Name = "Total_company_pizza";
            this.Total_company_pizza.Size = new System.Drawing.Size(157, 20);
            this.Total_company_pizza.TabIndex = 1;
            this.Total_company_pizza.Text = "Total Number Pizza\'s";
            // 
            // Company_transactions
            // 
            this.Company_transactions.AutoSize = true;
            this.Company_transactions.Location = new System.Drawing.Point(55, 36);
            this.Company_transactions.Name = "Company_transactions";
            this.Company_transactions.Size = new System.Drawing.Size(210, 20);
            this.Company_transactions.TabIndex = 0;
            this.Company_transactions.Text = "Total Company Transactions";
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summary.Location = new System.Drawing.Point(39, 4);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(206, 20);
            this.Summary.TabIndex = 8;
            this.Summary.Text = "Company Summary Data";
            // 
            // Summary_panel
            // 
            this.Summary_panel.Controls.Add(this.Summary);
            this.Summary_panel.Controls.Add(this.panel7);
            this.Summary_panel.Location = new System.Drawing.Point(71, 369);
            this.Summary_panel.Name = "Summary_panel";
            this.Summary_panel.Size = new System.Drawing.Size(576, 282);
            this.Summary_panel.TabIndex = 9;
            this.Summary_panel.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(767, 818);
            this.Controls.Add(this.Button_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Summary_panel);
            this.Controls.Add(this.Order_panel);
            this.Controls.Add(this.pizzamenu_panel);
            this.Controls.Add(this.Welcome_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Sult";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Welcome_panel.ResumeLayout(false);
            this.Welcome_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Button_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pizzamenu_panel.ResumeLayout(false);
            this.pizzamenu_panel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Order_panel.ResumeLayout(false);
            this.Order_panel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Summary_panel.ResumeLayout(false);
            this.Summary_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Welcome_panel;
        private System.Windows.Forms.Label server_name;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label Table_no;
        private System.Windows.Forms.TextBox Table_txtbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pizza_menu;
        private System.Windows.Forms.Label Ham_txtbox;
        private System.Windows.Forms.Label Pepparoni_price;
        private System.Windows.Forms.Label Margherita_price;
        private System.Windows.Forms.TextBox Ham_pineapple_txtbox;
        private System.Windows.Forms.TextBox Pepparoni_pizza_txtbox;
        private System.Windows.Forms.TextBox Margherita_pizza_txtbox;
        private System.Windows.Forms.Label Ham_pineapple;
        private System.Windows.Forms.Label Pepparoni_pizza;
        private System.Windows.Forms.Label Margherita_pizza;
        private System.Windows.Forms.Panel Button_panel;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Summarybtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Orderbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pizzamenu_panel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Order;
        private System.Windows.Forms.Label Total_receipt;
        private System.Windows.Forms.Label Total_pizza;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Panel Order_panel;
        private System.Windows.Forms.TextBox total_receipt_txtbox;
        private System.Windows.Forms.TextBox total_pizza_txtbox;
        private System.Windows.Forms.TextBox Server_txtbox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Avg_transaction_txtBox;
        private System.Windows.Forms.TextBox Total_company_receipt_txtBox;
        private System.Windows.Forms.TextBox Total_company_pizza_txtBox;
        private System.Windows.Forms.TextBox Company_transaction_txtBox;
        private System.Windows.Forms.Label Avg_transaction;
        private System.Windows.Forms.Label Total_company_receipt;
        private System.Windows.Forms.Label Total_company_pizza;
        private System.Windows.Forms.Label Company_transactions;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Panel Summary_panel;
        public System.Windows.Forms.TextBox Name_txtbox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

