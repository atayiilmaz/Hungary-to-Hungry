namespace From_Hungary_for_hungry
{
    partial class AdminForm
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
            allAccountsBtn = new Button();
            allRestaurantsBtn = new Button();
            mainPnl = new Panel();
            label1 = new Label();
            allAccountsPnl = new Panel();
            label2 = new Label();
            deleteAccountBtn = new Button();
            allRestaurantsPnl = new Panel();
            membershipBtn = new Button();
            label3 = new Label();
            RestaurantsListV = new ListView();
            accountsListV = new ListView();
            menuPnl.SuspendLayout();
            mainPnl.SuspendLayout();
            allAccountsPnl.SuspendLayout();
            allRestaurantsPnl.SuspendLayout();
            SuspendLayout();
            // 
            // menuPnl
            // 
            menuPnl.BackColor = SystemColors.ControlDark;
            menuPnl.Controls.Add(logoutBtn);
            menuPnl.Controls.Add(allAccountsBtn);
            menuPnl.Controls.Add(allRestaurantsBtn);
            menuPnl.Dock = DockStyle.Left;
            menuPnl.Location = new Point(0, 0);
            menuPnl.Name = "menuPnl";
            menuPnl.Size = new Size(324, 673);
            menuPnl.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(12, 343);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(297, 69);
            logoutBtn.TabIndex = 2;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // allAccountsBtn
            // 
            allAccountsBtn.Location = new Point(12, 268);
            allAccountsBtn.Name = "allAccountsBtn";
            allAccountsBtn.Size = new Size(297, 69);
            allAccountsBtn.TabIndex = 1;
            allAccountsBtn.Text = "View All Accounts";
            allAccountsBtn.UseVisualStyleBackColor = true;
            allAccountsBtn.Click += allAccountsBtn_Click;
            // 
            // allRestaurantsBtn
            // 
            allRestaurantsBtn.Location = new Point(12, 193);
            allRestaurantsBtn.Name = "allRestaurantsBtn";
            allRestaurantsBtn.Size = new Size(297, 69);
            allRestaurantsBtn.TabIndex = 0;
            allRestaurantsBtn.Text = "View All Restaurants";
            allRestaurantsBtn.UseVisualStyleBackColor = true;
            allRestaurantsBtn.Click += allRestaurantsBtn_Click;
            // 
            // mainPnl
            // 
            mainPnl.Controls.Add(label1);
            mainPnl.Dock = DockStyle.Right;
            mainPnl.Location = new Point(330, 0);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(932, 673);
            mainPnl.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 63);
            label1.Name = "label1";
            label1.Size = new Size(284, 31);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Admin Panel";
            // 
            // allAccountsPnl
            // 
            allAccountsPnl.Controls.Add(accountsListV);
            allAccountsPnl.Controls.Add(label2);
            allAccountsPnl.Controls.Add(deleteAccountBtn);
            allAccountsPnl.Location = new Point(330, 0);
            allAccountsPnl.Name = "allAccountsPnl";
            allAccountsPnl.Size = new Size(932, 673);
            allAccountsPnl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 72);
            label2.Name = "label2";
            label2.Size = new Size(149, 31);
            label2.TabIndex = 1;
            label2.Text = "All Accounts";
            // 
            // deleteAccountBtn
            // 
            deleteAccountBtn.Location = new Point(68, 523);
            deleteAccountBtn.Name = "deleteAccountBtn";
            deleteAccountBtn.Size = new Size(154, 29);
            deleteAccountBtn.TabIndex = 0;
            deleteAccountBtn.Text = "Delete Account";
            deleteAccountBtn.UseVisualStyleBackColor = true;
            // 
            // allRestaurantsPnl
            // 
            allRestaurantsPnl.Controls.Add(RestaurantsListV);
            allRestaurantsPnl.Controls.Add(membershipBtn);
            allRestaurantsPnl.Controls.Add(label3);
            allRestaurantsPnl.Location = new Point(330, 0);
            allRestaurantsPnl.Name = "allRestaurantsPnl";
            allRestaurantsPnl.Size = new Size(932, 673);
            allRestaurantsPnl.TabIndex = 3;
            // 
            // membershipBtn
            // 
            membershipBtn.Location = new Point(68, 523);
            membershipBtn.Name = "membershipBtn";
            membershipBtn.Size = new Size(175, 29);
            membershipBtn.TabIndex = 1;
            membershipBtn.Text = "Give Membership";
            membershipBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 63);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 0;
            label3.Text = "All Restaurants";
            // 
            // RestaurantsListV
            // 
            RestaurantsListV.Location = new Point(68, 115);
            RestaurantsListV.Name = "RestaurantsListV";
            RestaurantsListV.Size = new Size(820, 382);
            RestaurantsListV.TabIndex = 2;
            RestaurantsListV.UseCompatibleStateImageBehavior = false;
            // 
            // accountsListV
            // 
            accountsListV.Location = new Point(68, 126);
            accountsListV.Name = "accountsListV";
            accountsListV.Size = new Size(820, 382);
            accountsListV.TabIndex = 2;
            accountsListV.UseCompatibleStateImageBehavior = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuPnl);
            Controls.Add(allAccountsPnl);
            Controls.Add(allRestaurantsPnl);
            Controls.Add(mainPnl);
            Name = "AdminForm";
            Text = "AdminForm";
            menuPnl.ResumeLayout(false);
            mainPnl.ResumeLayout(false);
            mainPnl.PerformLayout();
            allAccountsPnl.ResumeLayout(false);
            allAccountsPnl.PerformLayout();
            allRestaurantsPnl.ResumeLayout(false);
            allRestaurantsPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuPnl;
        private Panel mainPnl;
        private Button logoutBtn;
        private Button allAccountsBtn;
        private Button allRestaurantsBtn;
        private Label label1;
        private Panel allAccountsPnl;
        private Label label2;
        private Button deleteAccountBtn;
        private Panel allRestaurantsPnl;
        private Label label3;
        private Button membershipBtn;
        private ListView RestaurantsListV;
        private ListView accountsListV;
    }
}