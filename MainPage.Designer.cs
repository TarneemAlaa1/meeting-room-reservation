namespace Meeting_Room_Reservation
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservationsStrpMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutStrpMenuItm = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameStrptxtBx = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationsStrpMenuItm,
            this.logoutStrpMenuItm,
            this.usernameStrptxtBx});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1002, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservationsStrpMenuItm
            // 
            this.reservationsStrpMenuItm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.reservationsStrpMenuItm.BackColor = System.Drawing.SystemColors.Control;
            this.reservationsStrpMenuItm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.reservationsStrpMenuItm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsStrpMenuItm.Name = "reservationsStrpMenuItm";
            this.reservationsStrpMenuItm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reservationsStrpMenuItm.Size = new System.Drawing.Size(89, 31);
            this.reservationsStrpMenuItm.Text = "الحجوزات";
            this.reservationsStrpMenuItm.Click += new System.EventHandler(this.reservationsStrpMenuItm_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 28);
            this.toolStripMenuItem1.Text = "حجوزاتى";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 28);
            this.toolStripMenuItem2.Text = "بحث";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(185, 28);
            this.toolStripMenuItem3.Text = "تعديل / الغاء";
            // 
            // logoutStrpMenuItm
            // 
            this.logoutStrpMenuItm.BackColor = System.Drawing.SystemColors.Control;
            this.logoutStrpMenuItm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.logoutStrpMenuItm.ForeColor = System.Drawing.Color.Red;
            this.logoutStrpMenuItm.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.logoutStrpMenuItm.Name = "logoutStrpMenuItm";
            this.logoutStrpMenuItm.Size = new System.Drawing.Size(60, 31);
            this.logoutStrpMenuItm.Text = "خروج";
            this.logoutStrpMenuItm.Click += new System.EventHandler(this.logoutStrpMenuItm_Click);
            // 
            // usernameStrptxtBx
            // 
            this.usernameStrptxtBx.BackColor = System.Drawing.SystemColors.Menu;
            this.usernameStrptxtBx.Enabled = false;
            this.usernameStrptxtBx.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameStrptxtBx.Name = "usernameStrptxtBx";
            this.usernameStrptxtBx.Size = new System.Drawing.Size(200, 31);
            this.usernameStrptxtBx.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(256, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "حجز قاعات الاجتماعات";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(672, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 203);
            this.button1.TabIndex = 2;
            this.button1.Text = "قاعة الدور الاول";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(341, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(325, 203);
            this.button2.TabIndex = 3;
            this.button2.Text = "قاعة الدور الثاني";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(8, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(325, 203);
            this.button3.TabIndex = 4;
            this.button3.Text = "قاعة الدور الثالث";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(670, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(325, 98);
            this.button4.TabIndex = 5;
            this.button4.Text = "قاعة الدور الرابع";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(339, 387);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(325, 203);
            this.button5.TabIndex = 6;
            this.button5.Text = "قاعة الدور الخامس";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(10, 387);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(325, 203);
            this.button6.TabIndex = 7;
            this.button6.Text = "قاعة الدور السادس";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(670, 493);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(325, 98);
            this.button7.TabIndex = 8;
            this.button7.Text = "قاعات الدور الرابع الخاصة";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 35);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 588);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Meeting_Room_Reservation.Properties.Resources.RoomBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 623);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox usernameStrptxtBx;
        private System.Windows.Forms.ToolStripMenuItem reservationsStrpMenuItm;
        private System.Windows.Forms.ToolStripMenuItem logoutStrpMenuItm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}