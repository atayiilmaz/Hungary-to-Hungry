namespace From_Hungary_for_hungry
{
    partial class CustomerForm
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
            pictureBox1 = new PictureBox();
            CartPanel = new Panel();
            button2 = new Button();
            MenuPanel = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            logouttBtn = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CartPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Image1;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CartPanel
            // 
            CartPanel.BackColor = SystemColors.ActiveCaption;
            CartPanel.Controls.Add(button2);
            CartPanel.Controls.Add(pictureBox1);
            CartPanel.Location = new Point(1015, 16);
            CartPanel.Margin = new Padding(3, 4, 3, 4);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(235, 565);
            CartPanel.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(58, 531);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(77, 31);
            button2.TabIndex = 5;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = SystemColors.ActiveCaption;
            MenuPanel.Controls.Add(button1);
            MenuPanel.Controls.Add(label1);
            MenuPanel.Controls.Add(pictureBox2);
            MenuPanel.Location = new Point(674, 16);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(335, 565);
            MenuPanel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(163, 531);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(46, 31);
            button1.TabIndex = 4;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 24);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Image2;
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 56);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(logouttBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 591);
            panel1.TabIndex = 4;
            // 
            // logouttBtn
            // 
            logouttBtn.Location = new Point(12, 275);
            logouttBtn.Name = "logouttBtn";
            logouttBtn.Size = new Size(297, 69);
            logouttBtn.TabIndex = 0;
            logouttBtn.Text = "Logout";
            logouttBtn.UseVisualStyleBackColor = true;
            logouttBtn.Click += logouttBtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(330, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(338, 565);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 591);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Controls.Add(CartPanel);
            Controls.Add(MenuPanel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CustomerForm";
            Text = "Customer Panel";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CartPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel CartPanel;
        private Panel MenuPanel;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Button logouttBtn;
        private ListView listView1;
    }
}