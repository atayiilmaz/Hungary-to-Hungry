namespace From_Hungary_for_hungry
{
    partial class RestaurantForm
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
            menuPnl = new Panel();
            logoutBtn = new Button();
            psettingsBtn = new Button();
            viewMenuBtn = new Button();
            viewOrdersBtn = new Button();
            welcomePnl = new Panel();
            label1 = new Label();
            viewOrdersPnl = new Panel();
            panel1 = new Panel();
            deleteBtn = new Button();
            doneBtn = new Button();
            cancelledBtn = new Button();
            setActiveBtn = new Button();
            orderDgv = new DataGridView();
            label2 = new Label();
            psettingsPnl = new Panel();
            locationTxtB = new TextBox();
            label8 = new Label();
            busNameTxtB = new TextBox();
            label10 = new Label();
            saveBtn = new Button();
            addressTxtB = new RichTextBox();
            label7 = new Label();
            mailTxtB = new TextBox();
            label6 = new Label();
            usernameTxtB = new TextBox();
            label5 = new Label();
            label3 = new Label();
            viewMenuPnl = new Panel();
            panel3 = new Panel();
            businessNameTxt = new TextBox();
            categoryCb = new ComboBox();
            label12 = new Label();
            priceTxt = new TextBox();
            label11 = new Label();
            pnameTxt = new TextBox();
            label9 = new Label();
            panel2 = new Panel();
            delBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            menuDgv = new DataGridView();
            label4 = new Label();
            menuPnl.SuspendLayout();
            welcomePnl.SuspendLayout();
            viewOrdersPnl.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderDgv).BeginInit();
            psettingsPnl.SuspendLayout();
            viewMenuPnl.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuDgv).BeginInit();
            SuspendLayout();
            // 
            // menuPnl
            // 
            menuPnl.BackColor = SystemColors.ControlDark;
            menuPnl.Controls.Add(logoutBtn);
            menuPnl.Controls.Add(psettingsBtn);
            menuPnl.Controls.Add(viewMenuBtn);
            menuPnl.Controls.Add(viewOrdersBtn);
            menuPnl.Dock = DockStyle.Left;
            menuPnl.Location = new Point(0, 0);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(324, 673);
            menuPnl.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(10, 396);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(297, 69);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // psettingsBtn
            // 
            psettingsBtn.Location = new Point(10, 321);
            psettingsBtn.Name = "psettingsBtn";
            psettingsBtn.Size = new Size(297, 69);
            psettingsBtn.TabIndex = 3;
            psettingsBtn.Text = "Profile Settings";
            psettingsBtn.UseVisualStyleBackColor = true;
            psettingsBtn.Click += psettingsBtn_Click;
            // 
            // viewMenuBtn
            // 
            viewMenuBtn.Location = new Point(12, 246);
            viewMenuBtn.Name = "viewMenuBtn";
            viewMenuBtn.Size = new Size(297, 69);
            viewMenuBtn.TabIndex = 2;
            viewMenuBtn.Text = "View Menu";
            viewMenuBtn.UseVisualStyleBackColor = true;
            viewMenuBtn.Click += viewMenuBtn_Click;
            // 
            // viewOrdersBtn
            // 
            viewOrdersBtn.Location = new Point(12, 171);
            viewOrdersBtn.Name = "viewOrdersBtn";
            viewOrdersBtn.Size = new Size(297, 69);
            viewOrdersBtn.TabIndex = 1;
            viewOrdersBtn.Text = "View Orders";
            viewOrdersBtn.UseVisualStyleBackColor = true;
            viewOrdersBtn.Click += viewOrdersBtn_Click;
            // 
            // welcomePnl
            // 
            welcomePnl.Controls.Add(label1);
            welcomePnl.Dock = DockStyle.Right;
            welcomePnl.Location = new Point(-2466, 0);
            welcomePnl.Name = "welcomePnl";
            welcomePnl.Size = new Size(932, 673);
            welcomePnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 63);
            label1.Name = "label1";
            label1.Size = new Size(327, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Restaurant Panel";
            // 
            // viewOrdersPnl
            // 
            viewOrdersPnl.Controls.Add(panel1);
            viewOrdersPnl.Controls.Add(orderDgv);
            viewOrdersPnl.Controls.Add(label2);
            viewOrdersPnl.Dock = DockStyle.Right;
            viewOrdersPnl.Location = new Point(-602, 0);
            viewOrdersPnl.Name = "viewOrdersPnl";
            viewOrdersPnl.Size = new Size(932, 673);
            viewOrdersPnl.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(deleteBtn);
            panel1.Controls.Add(doneBtn);
            panel1.Controls.Add(cancelledBtn);
            panel1.Controls.Add(setActiveBtn);
            panel1.Location = new Point(690, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 478);
            panel1.TabIndex = 2;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Top;
            deleteBtn.Location = new Point(0, 150);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(185, 50);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete Completed Orders";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // doneBtn
            // 
            doneBtn.Dock = DockStyle.Top;
            doneBtn.Location = new Point(0, 100);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(185, 50);
            doneBtn.TabIndex = 2;
            doneBtn.Text = "Set Status as Done";
            doneBtn.UseVisualStyleBackColor = true;
            doneBtn.Click += doneBtn_Click;
            // 
            // cancelledBtn
            // 
            cancelledBtn.Dock = DockStyle.Top;
            cancelledBtn.Location = new Point(0, 50);
            cancelledBtn.Name = "cancelledBtn";
            cancelledBtn.Size = new Size(185, 50);
            cancelledBtn.TabIndex = 1;
            cancelledBtn.Text = "Set Status as Cancelled";
            cancelledBtn.UseVisualStyleBackColor = true;
            cancelledBtn.Click += cancelledBtn_Click;
            // 
            // setActiveBtn
            // 
            setActiveBtn.Dock = DockStyle.Top;
            setActiveBtn.Location = new Point(0, 0);
            setActiveBtn.Name = "setActiveBtn";
            setActiveBtn.Size = new Size(185, 50);
            setActiveBtn.TabIndex = 0;
            setActiveBtn.Text = "Set Status as Active";
            setActiveBtn.UseVisualStyleBackColor = true;
            setActiveBtn.Click += setActiveBtn_Click;
            // 
            // orderDgv
            // 
            orderDgv.AllowUserToAddRows = false;
            orderDgv.AllowUserToDeleteRows = false;
            orderDgv.AllowUserToResizeRows = false;
            orderDgv.BorderStyle = BorderStyle.None;
            orderDgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            orderDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderDgv.Location = new Point(68, 148);
            orderDgv.Name = "orderDgv";
            orderDgv.RowHeadersVisible = false;
            orderDgv.RowHeadersWidth = 51;
            orderDgv.RowTemplate.Height = 29;
            orderDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderDgv.Size = new Size(565, 478);
            orderDgv.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 63);
            label2.Name = "label2";
            label2.Size = new Size(143, 31);
            label2.TabIndex = 0;
            label2.Text = "View Orders";
            // 
            // psettingsPnl
            // 
            psettingsPnl.Controls.Add(locationTxtB);
            psettingsPnl.Controls.Add(label8);
            psettingsPnl.Controls.Add(busNameTxtB);
            psettingsPnl.Controls.Add(label10);
            psettingsPnl.Controls.Add(saveBtn);
            psettingsPnl.Controls.Add(addressTxtB);
            psettingsPnl.Controls.Add(label7);
            psettingsPnl.Controls.Add(mailTxtB);
            psettingsPnl.Controls.Add(label6);
            psettingsPnl.Controls.Add(usernameTxtB);
            psettingsPnl.Controls.Add(label5);
            psettingsPnl.Controls.Add(label3);
            psettingsPnl.Dock = DockStyle.Right;
            psettingsPnl.Location = new Point(-1534, 0);
            psettingsPnl.Name = "psettingsPnl";
            psettingsPnl.Size = new Size(932, 673);
            psettingsPnl.TabIndex = 1;
            // 
            // locationTxtB
            // 
            locationTxtB.Location = new Point(494, 243);
            locationTxtB.Name = "locationTxtB";
            locationTxtB.Size = new Size(257, 27);
            locationTxtB.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(494, 220);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 12;
            label8.Text = "Location";
            // 
            // busNameTxtB
            // 
            busNameTxtB.Location = new Point(494, 171);
            busNameTxtB.Name = "busNameTxtB";
            busNameTxtB.Size = new Size(257, 27);
            busNameTxtB.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(494, 148);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 8;
            label10.Text = "Business Name";
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(703, 555);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(169, 71);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // addressTxtB
            // 
            addressTxtB.BorderStyle = BorderStyle.FixedSingle;
            addressTxtB.Location = new Point(63, 321);
            addressTxtB.Name = "addressTxtB";
            addressTxtB.Size = new Size(257, 120);
            addressTxtB.TabIndex = 6;
            addressTxtB.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 293);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 5;
            label7.Text = "Address";
            // 
            // mailTxtB
            // 
            mailTxtB.Location = new Point(63, 241);
            mailTxtB.Name = "mailTxtB";
            mailTxtB.Size = new Size(257, 27);
            mailTxtB.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 218);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 3;
            label6.Text = "Email";
            // 
            // usernameTxtB
            // 
            usernameTxtB.Location = new Point(63, 171);
            usernameTxtB.Name = "usernameTxtB";
            usernameTxtB.Size = new Size(257, 27);
            usernameTxtB.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 148);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 60);
            label3.Name = "label3";
            label3.Size = new Size(180, 31);
            label3.TabIndex = 0;
            label3.Text = "Profile Settings";
            // 
            // viewMenuPnl
            // 
            viewMenuPnl.Controls.Add(panel3);
            viewMenuPnl.Controls.Add(panel2);
            viewMenuPnl.Controls.Add(menuDgv);
            viewMenuPnl.Controls.Add(label4);
            viewMenuPnl.Dock = DockStyle.Right;
            viewMenuPnl.Location = new Point(330, 0);
            viewMenuPnl.Name = "viewMenuPnl";
            viewMenuPnl.Size = new Size(932, 673);
            viewMenuPnl.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(businessNameTxt);
            panel3.Controls.Add(categoryCb);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(priceTxt);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(pnameTxt);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(690, 145);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 308);
            panel3.TabIndex = 3;
            // 
            // businessNameTxt
            // 
            businessNameTxt.Location = new Point(30, 260);
            businessNameTxt.Name = "businessNameTxt";
            businessNameTxt.Size = new Size(125, 27);
            businessNameTxt.TabIndex = 6;
            // 
            // categoryCb
            // 
            categoryCb.AutoCompleteCustomSource.AddRange(new string[] { "Homemade Foods", "Mexican Foods", "Chinese Foods", "Appetizers", "Fast Foods", "Drinks" });
            categoryCb.FormattingEnabled = true;
            categoryCb.Items.AddRange(new object[] { "Homemade Foods", "Chinese Foods", "Mexican Foods", "Fast Foods", "Appetizers", "Drinks" });
            categoryCb.Location = new Point(3, 156);
            categoryCb.Name = "categoryCb";
            categoryCb.Size = new Size(179, 28);
            categoryCb.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 133);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 4;
            label12.Text = "Category";
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(3, 91);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(179, 27);
            priceTxt.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 68);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 2;
            label11.Text = "Price";
            // 
            // pnameTxt
            // 
            pnameTxt.Location = new Point(3, 26);
            pnameTxt.Name = "pnameTxt";
            pnameTxt.Size = new Size(179, 27);
            pnameTxt.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 0;
            label9.Text = "Product Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(delBtn);
            panel2.Controls.Add(editBtn);
            panel2.Controls.Add(addBtn);
            panel2.Location = new Point(690, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(185, 153);
            panel2.TabIndex = 2;
            // 
            // delBtn
            // 
            delBtn.Dock = DockStyle.Top;
            delBtn.Location = new Point(0, 100);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(185, 50);
            delBtn.TabIndex = 2;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Dock = DockStyle.Top;
            editBtn.Location = new Point(0, 50);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(185, 50);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Dock = DockStyle.Top;
            addBtn.Location = new Point(0, 0);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(185, 50);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // menuDgv
            // 
            menuDgv.AllowUserToAddRows = false;
            menuDgv.AllowUserToDeleteRows = false;
            menuDgv.AllowUserToResizeRows = false;
            menuDgv.BorderStyle = BorderStyle.None;
            menuDgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            menuDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            menuDgv.Location = new Point(68, 148);
            menuDgv.Name = "menuDgv";
            menuDgv.RowHeadersVisible = false;
            menuDgv.RowHeadersWidth = 51;
            menuDgv.RowTemplate.Height = 29;
            menuDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            menuDgv.ShowCellErrors = false;
            menuDgv.ShowCellToolTips = false;
            menuDgv.ShowEditingIcon = false;
            menuDgv.ShowRowErrors = false;
            menuDgv.Size = new Size(565, 478);
            menuDgv.TabIndex = 1;
            menuDgv.CellContentClick += menuDgv_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 60);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 0;
            label4.Text = "View Menu";
            // 
            // RestaurantForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuPnl);
            Controls.Add(welcomePnl);
            Controls.Add(psettingsPnl);
            Controls.Add(viewOrdersPnl);
            Controls.Add(viewMenuPnl);
            MaximizeBox = false;
            Name = "RestaurantForm";
            Text = "Restaurant Panel";
            Load += RestaurantForm_Load;
            menuPnl.ResumeLayout(false);
            welcomePnl.ResumeLayout(false);
            welcomePnl.PerformLayout();
            viewOrdersPnl.ResumeLayout(false);
            viewOrdersPnl.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderDgv).EndInit();
            psettingsPnl.ResumeLayout(false);
            psettingsPnl.PerformLayout();
            viewMenuPnl.ResumeLayout(false);
            viewMenuPnl.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPnl;
        private Panel welcomePnl;
        private Button logoutBtn;
        private Button psettingsBtn;
        private Button viewMenuBtn;
        private Button viewOrdersBtn;
        private Label label1;
        private Panel viewOrdersPnl;
        private Label label2;
        private Panel psettingsPnl;
        private Label label3;
        private Panel viewMenuPnl;
        private Label label4;
        private Label label7;
        private TextBox mailTxtB;
        private Label label6;
        private TextBox usernameTxtB;
        private Label label5;
        private RichTextBox addressTxtB;
        private Button saveBtn;
        private RichTextBox richTextBox1;
        private Label label8;
        private TextBox busNameTxtB;
        private Label label10;
        private TextBox locationTxtB;
        private DataGridView orderDgv;
        private Panel panel1;
        private Button deleteBtn;
        private Button doneBtn;
        private Button cancelledBtn;
        private Button setActiveBtn;
        private DataGridView menuDgv;
        private Panel panel2;
        private Button addBtn;
        private Button delBtn;
        private Button editBtn;
        private Panel panel3;
        private TextBox pnameTxt;
        private Label label9;
        private Label label12;
        private TextBox priceTxt;
        private Label label11;
        private ComboBox categoryCb;
        private TextBox businessNameTxt;
    }
}