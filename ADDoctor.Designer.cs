namespace Assignment_2
{
    partial class ADDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDoctor));
            this.addD = new System.Windows.Forms.Button();
            this.NaD = new System.Windows.Forms.TextBox();
            this.RD = new System.Windows.Forms.TextBox();
            this.TD = new System.Windows.Forms.DateTimePicker();
            this.PD = new System.Windows.Forms.TextBox();
            this.GD = new System.Windows.Forms.ComboBox();
            this.WD = new System.Windows.Forms.ComboBox();
            this.DD = new System.Windows.Forms.ComboBox();
            this.ND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Sick = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Cm = new System.Windows.Forms.Label();
            this.Ward = new System.Windows.Forms.Label();
            this.District = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addD
            // 
            this.addD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addD.ForeColor = System.Drawing.Color.DarkRed;
            this.addD.Location = new System.Drawing.Point(191, 293);
            this.addD.Name = "addD";
            this.addD.Size = new System.Drawing.Size(136, 40);
            this.addD.TabIndex = 18;
            this.addD.Text = "Add";
            this.addD.UseVisualStyleBackColor = false;
            this.addD.Click += new System.EventHandler(this.addD_Click);
            // 
            // NaD
            // 
            this.NaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaD.Location = new System.Drawing.Point(304, 248);
            this.NaD.Name = "NaD";
            this.NaD.Size = new System.Drawing.Size(214, 22);
            this.NaD.TabIndex = 17;
            // 
            // RD
            // 
            this.RD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RD.Location = new System.Drawing.Point(304, 178);
            this.RD.Name = "RD";
            this.RD.Size = new System.Drawing.Size(214, 24);
            this.RD.TabIndex = 15;
            // 
            // TD
            // 
            this.TD.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TD.Location = new System.Drawing.Point(304, 109);
            this.TD.Name = "TD";
            this.TD.Size = new System.Drawing.Size(214, 22);
            this.TD.TabIndex = 13;
            // 
            // PD
            // 
            this.PD.Location = new System.Drawing.Point(15, 248);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(205, 22);
            this.PD.TabIndex = 8;
            // 
            // GD
            // 
            this.GD.FormattingEnabled = true;
            this.GD.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GD.Location = new System.Drawing.Point(304, 44);
            this.GD.Name = "GD";
            this.GD.Size = new System.Drawing.Size(214, 24);
            this.GD.TabIndex = 6;
            // 
            // WD
            // 
            this.WD.FormattingEnabled = true;
            this.WD.Location = new System.Drawing.Point(15, 178);
            this.WD.Name = "WD";
            this.WD.Size = new System.Drawing.Size(205, 24);
            this.WD.TabIndex = 6;
            // 
            // DD
            // 
            this.DD.FormattingEnabled = true;
            this.DD.Items.AddRange(new object[] {
            "1.Quận 1",
            "2. Quận 2",
            "3. Quận 3",
            "4. Quận 4",
            "5. Quận 5",
            "6. Quận 6",
            "7. Quận 7",
            "8. Quận 8",
            "9. Quận 9",
            "10. Quận 10",
            "11. Quận 11",
            "12. Quận 12",
            "13. Quận Thủ Đức",
            "14. Quận Bình Thạnh",
            "15. Quận Gò Vấp",
            "16. Quận Phú Nhuận",
            "17. Quận Tân Phú",
            "18. Quận Bình Tân",
            "19. Quận Tân Bình",
            "20. Huyện Nhà Bè",
            "21. Huyện Bình Chánh",
            "22. Huyện Hóc Môn",
            "23. Huyện Củ Chi",
            "24. Huyện Cần Giờ"});
            this.DD.Location = new System.Drawing.Point(15, 112);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(205, 24);
            this.DD.TabIndex = 4;
            // 
            // ND
            // 
            this.ND.Location = new System.Drawing.Point(14, 46);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(206, 22);
            this.ND.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nationality";
            // 
            // Sick
            // 
            this.Sick.AutoSize = true;
            this.Sick.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sick.Location = new System.Drawing.Point(302, 149);
            this.Sick.Name = "Sick";
            this.Sick.Size = new System.Drawing.Size(60, 17);
            this.Sick.TabIndex = 14;
            this.Sick.Text = "Regency";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Location = new System.Drawing.Point(302, 82);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(93, 17);
            this.Birth.TabIndex = 12;
            this.Birth.Text = "Date Of Birth";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(302, 17);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(53, 17);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Gender";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cm.Location = new System.Drawing.Point(13, 219);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(52, 17);
            this.Cm.TabIndex = 7;
            this.Cm.Text = "Patient";
            // 
            // Ward
            // 
            this.Ward.AutoSize = true;
            this.Ward.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ward.Location = new System.Drawing.Point(13, 149);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(41, 17);
            this.Ward.TabIndex = 5;
            this.Ward.Text = "Ward";
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.District.Location = new System.Drawing.Point(12, 82);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(54, 17);
            this.District.TabIndex = 3;
            this.District.Text = "District";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(13, 17);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(43, 17);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.addD);
            this.panel2.Controls.Add(this.NaD);
            this.panel2.Controls.Add(this.RD);
            this.panel2.Controls.Add(this.TD);
            this.panel2.Controls.Add(this.PD);
            this.panel2.Controls.Add(this.GD);
            this.panel2.Controls.Add(this.WD);
            this.panel2.Controls.Add(this.DD);
            this.panel2.Controls.Add(this.ND);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.Sick);
            this.panel2.Controls.Add(this.Birth);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.Cm);
            this.panel2.Controls.Add(this.Ward);
            this.panel2.Controls.Add(this.District);
            this.panel2.Controls.Add(this.Name1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 354);
            this.panel2.TabIndex = 4;
            // 
            // ADDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 357);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDoctor";
            this.Text = "Manage Of Hospital Ver 1.1.2";
            this.Load += new System.EventHandler(this.ADDoctor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addD;
        private System.Windows.Forms.TextBox NaD;
        private System.Windows.Forms.TextBox RD;
        private System.Windows.Forms.DateTimePicker TD;
        private System.Windows.Forms.TextBox PD;
        private System.Windows.Forms.ComboBox GD;
        private System.Windows.Forms.ComboBox WD;
        private System.Windows.Forms.ComboBox DD;
        private System.Windows.Forms.TextBox ND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Sick;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Cm;
        private System.Windows.Forms.Label Ward;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Panel panel2;
    }
}