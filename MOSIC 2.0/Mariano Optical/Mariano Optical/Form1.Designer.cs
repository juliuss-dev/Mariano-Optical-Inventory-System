namespace Initial_UI_Mariano_Optical
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMarianoOpticalCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMarianoOpticalPatientRecordSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbAddNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPatientName = new System.Windows.Forms.Label();
            this.lbPAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbVisualAcuity = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.tbBday = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPatientToolStripMenuItem,
            this.searchPatientToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newPatientToolStripMenuItem
            // 
            this.newPatientToolStripMenuItem.Name = "newPatientToolStripMenuItem";
            this.newPatientToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.newPatientToolStripMenuItem.Text = "New Patient";
            this.newPatientToolStripMenuItem.Click += new System.EventHandler(this.newPatientToolStripMenuItem_Click);
            // 
            // searchPatientToolStripMenuItem
            // 
            this.searchPatientToolStripMenuItem.Name = "searchPatientToolStripMenuItem";
            this.searchPatientToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.searchPatientToolStripMenuItem.Text = "Patient List";
            this.searchPatientToolStripMenuItem.Click += new System.EventHandler(this.searchPatientToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMarianoOpticalCenterToolStripMenuItem,
            this.aboutMarianoOpticalPatientRecordSystemToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMarianoOpticalCenterToolStripMenuItem
            // 
            this.aboutMarianoOpticalCenterToolStripMenuItem.Name = "aboutMarianoOpticalCenterToolStripMenuItem";
            this.aboutMarianoOpticalCenterToolStripMenuItem.Size = new System.Drawing.Size(395, 26);
            this.aboutMarianoOpticalCenterToolStripMenuItem.Text = "About Mariano Optical Center";
            // 
            // aboutMarianoOpticalPatientRecordSystemToolStripMenuItem
            // 
            this.aboutMarianoOpticalPatientRecordSystemToolStripMenuItem.Name = "aboutMarianoOpticalPatientRecordSystemToolStripMenuItem";
            this.aboutMarianoOpticalPatientRecordSystemToolStripMenuItem.Size = new System.Drawing.Size(395, 26);
            this.aboutMarianoOpticalPatientRecordSystemToolStripMenuItem.Text = "About Mariano Optical Patient Record System";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbAddNew
            // 
            this.tbAddNew.Location = new System.Drawing.Point(450, 579);
            this.tbAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(269, 28);
            this.tbAddNew.TabIndex = 5;
            this.tbAddNew.Text = "Add Visit Record";
            this.tbAddNew.UseVisualStyleBackColor = true;
            this.tbAddNew.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address:";
            // 
            // lbPatientName
            // 
            this.lbPatientName.AutoSize = true;
            this.lbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatientName.Location = new System.Drawing.Point(95, 65);
            this.lbPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPatientName.Name = "lbPatientName";
            this.lbPatientName.Size = new System.Drawing.Size(0, 20);
            this.lbPatientName.TabIndex = 8;
            // 
            // lbPAddress
            // 
            this.lbPAddress.AutoSize = true;
            this.lbPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPAddress.Location = new System.Drawing.Point(95, 101);
            this.lbPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPAddress.Name = "lbPAddress";
            this.lbPAddress.Size = new System.Drawing.Size(0, 20);
            this.lbPAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birth Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comprehensive Information";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbVisualAcuity);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(315, 250);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(404, 321);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual Acuity";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbVisualAcuity
            // 
            this.tbVisualAcuity.Location = new System.Drawing.Point(45, 57);
            this.tbVisualAcuity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVisualAcuity.Multiline = true;
            this.tbVisualAcuity.Name = "tbVisualAcuity";
            this.tbVisualAcuity.ReadOnly = true;
            this.tbVisualAcuity.Size = new System.Drawing.Size(316, 240);
            this.tbVisualAcuity.TabIndex = 5;
            // 
            // tbLName
            // 
            this.tbLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLName.Location = new System.Drawing.Point(315, 78);
            this.tbLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLName.Name = "tbLName";
            this.tbLName.ReadOnly = true;
            this.tbLName.Size = new System.Drawing.Size(120, 26);
            this.tbLName.TabIndex = 43;
            // 
            // tbGender
            // 
            this.tbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.Location = new System.Drawing.Point(315, 112);
            this.tbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(72, 26);
            this.tbGender.TabIndex = 44;
            // 
            // tbBday
            // 
            this.tbBday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBday.Location = new System.Drawing.Point(315, 146);
            this.tbBday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBday.Name = "tbBday";
            this.tbBday.ReadOnly = true;
            this.tbBday.Size = new System.Drawing.Size(132, 26);
            this.tbBday.TabIndex = 45;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(315, 180);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(288, 26);
            this.tbAddress.TabIndex = 46;
            // 
            // tbPatientID
            // 
            this.tbPatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientID.Location = new System.Drawing.Point(315, 38);
            this.tbPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPatientID.Name = "tbPatientID";
            this.tbPatientID.ReadOnly = true;
            this.tbPatientID.Size = new System.Drawing.Size(85, 26);
            this.tbPatientID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Patient ID:";
            // 
            // tbFName
            // 
            this.tbFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFName.Location = new System.Drawing.Point(445, 78);
            this.tbFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFName.Name = "tbFName";
            this.tbFName.ReadOnly = true;
            this.tbFName.Size = new System.Drawing.Size(111, 26);
            this.tbFName.TabIndex = 49;
            // 
            // tbMName
            // 
            this.tbMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMName.Location = new System.Drawing.Point(564, 78);
            this.tbMName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMName.Name = "tbMName";
            this.tbMName.ReadOnly = true;
            this.tbMName.Size = new System.Drawing.Size(39, 26);
            this.tbMName.TabIndex = 50;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 617);
            this.Controls.Add(this.tbMName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPatientID);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbBday);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPAddress);
            this.Controls.Add(this.lbPatientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAddNew);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Mariano Optical Patient Record System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMarianoOpticalCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMarianoOpticalPatientRecordSystemToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button tbAddNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPatientName;
        private System.Windows.Forms.Label lbPAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.TextBox tbBday;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVisualAcuity;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbMName;
    }
}

