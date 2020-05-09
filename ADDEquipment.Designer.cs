namespace Assignment_2
{
    partial class ADDEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADDEquipment));
            this.addE = new System.Windows.Forms.Button();
            this.DE = new System.Windows.Forms.TextBox();
            this.SE = new System.Windows.Forms.TextBox();
            this.DTE = new System.Windows.Forms.DateTimePicker();
            this.PE = new System.Windows.Forms.TextBox();
            this.PTE = new System.Windows.Forms.ComboBox();
            this.AE = new System.Windows.Forms.ComboBox();
            this.OE = new System.Windows.Forms.ComboBox();
            this.NE = new System.Windows.Forms.TextBox();
            this.Doctor = new System.Windows.Forms.Label();
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
            // addE
            // 
            this.addE.BackColor = System.Drawing.Color.LemonChiffon;
            this.addE.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addE.ForeColor = System.Drawing.Color.Black;
            this.addE.Location = new System.Drawing.Point(194, 293);
            this.addE.Name = "addE";
            this.addE.Size = new System.Drawing.Size(137, 40);
            this.addE.TabIndex = 18;
            this.addE.Text = "ADD";
            this.addE.UseVisualStyleBackColor = false;
            this.addE.Click += new System.EventHandler(this.addE_Click);
            // 
            // DE
            // 
            this.DE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DE.Location = new System.Drawing.Point(304, 248);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(215, 22);
            this.DE.TabIndex = 17;
            // 
            // SE
            // 
            this.SE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SE.Location = new System.Drawing.Point(304, 178);
            this.SE.Name = "SE";
            this.SE.Size = new System.Drawing.Size(215, 24);
            this.SE.TabIndex = 15;
            // 
            // DTE
            // 
            this.DTE.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTE.Location = new System.Drawing.Point(304, 109);
            this.DTE.Name = "DTE";
            this.DTE.Size = new System.Drawing.Size(215, 22);
            this.DTE.TabIndex = 13;
            // 
            // PE
            // 
            this.PE.Location = new System.Drawing.Point(15, 248);
            this.PE.Name = "PE";
            this.PE.Size = new System.Drawing.Size(206, 22);
            this.PE.TabIndex = 8;
            // 
            // PTE
            // 
            this.PTE.FormattingEnabled = true;
            this.PTE.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PTE.Location = new System.Drawing.Point(304, 44);
            this.PTE.Name = "PTE";
            this.PTE.Size = new System.Drawing.Size(215, 24);
            this.PTE.TabIndex = 6;
            // 
            // AE
            // 
            this.AE.FormattingEnabled = true;
            this.AE.Location = new System.Drawing.Point(15, 178);
            this.AE.Name = "AE";
            this.AE.Size = new System.Drawing.Size(206, 24);
            this.AE.TabIndex = 6;
            // 
            // OE
            // 
            this.OE.FormattingEnabled = true;
            this.OE.Items.AddRange(new object[] {
            ""});
            this.OE.Location = new System.Drawing.Point(15, 112);
            this.OE.Name = "OE";
            this.OE.Size = new System.Drawing.Size(206, 24);
            this.OE.TabIndex = 4;
            // 
            // NE
            // 
            this.NE.Location = new System.Drawing.Point(14, 46);
            this.NE.Name = "NE";
            this.NE.Size = new System.Drawing.Size(207, 22);
            this.NE.TabIndex = 3;
            // 
            // Doctor
            // 
            this.Doctor.AutoSize = true;
            this.Doctor.BackColor = System.Drawing.Color.SandyBrown;
            this.Doctor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Location = new System.Drawing.Point(302, 219);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(53, 17);
            this.Doctor.TabIndex = 16;
            this.Doctor.Text = "Doctor";
            // 
            // Sick
            // 
            this.Sick.AutoSize = true;
            this.Sick.BackColor = System.Drawing.Color.SandyBrown;
            this.Sick.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sick.Location = new System.Drawing.Point(302, 149);
            this.Sick.Name = "Sick";
            this.Sick.Size = new System.Drawing.Size(48, 17);
            this.Sick.TabIndex = 14;
            this.Sick.Text = "Status";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.BackColor = System.Drawing.Color.SandyBrown;
            this.Birth.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth.Location = new System.Drawing.Point(302, 82);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(123, 17);
            this.Birth.TabIndex = 12;
            this.Birth.Text = "Date Of Purchase";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.SandyBrown;
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(302, 17);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(113, 17);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Purpose To Use";
            // 
            // Cm
            // 
            this.Cm.AutoSize = true;
            this.Cm.BackColor = System.Drawing.Color.SandyBrown;
            this.Cm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cm.Location = new System.Drawing.Point(13, 219);
            this.Cm.Name = "Cm";
            this.Cm.Size = new System.Drawing.Size(54, 17);
            this.Cm.TabIndex = 7;
            this.Cm.Text = "Patient";
            // 
            // Ward
            // 
            this.Ward.AutoSize = true;
            this.Ward.BackColor = System.Drawing.Color.SandyBrown;
            this.Ward.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ward.Location = new System.Drawing.Point(13, 149);
            this.Ward.Name = "Ward";
            this.Ward.Size = new System.Drawing.Size(63, 17);
            this.Ward.TabIndex = 5;
            this.Ward.Text = "Address";
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.BackColor = System.Drawing.Color.SandyBrown;
            this.District.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.District.Location = new System.Drawing.Point(12, 82);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(50, 17);
            this.District.TabIndex = 3;
            this.District.Text = "Origin";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.SandyBrown;
            this.Name1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(13, 17);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(46, 17);
            this.Name1.TabIndex = 2;
            this.Name1.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.addE);
            this.panel2.Controls.Add(this.DE);
            this.panel2.Controls.Add(this.SE);
            this.panel2.Controls.Add(this.DTE);
            this.panel2.Controls.Add(this.PE);
            this.panel2.Controls.Add(this.PTE);
            this.panel2.Controls.Add(this.AE);
            this.panel2.Controls.Add(this.OE);
            this.panel2.Controls.Add(this.NE);
            this.panel2.Controls.Add(this.Doctor);
            this.panel2.Controls.Add(this.Sick);
            this.panel2.Controls.Add(this.Birth);
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.Cm);
            this.panel2.Controls.Add(this.Ward);
            this.panel2.Controls.Add(this.District);
            this.panel2.Controls.Add(this.Name1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(536, 354);
            this.panel2.TabIndex = 5;
            // 
            // ADDEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 354);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADDEquipment";
            this.Text = "Manage Of Hospital Ver 1.1.2";
            this.Load += new System.EventHandler(this.ADDEquipment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addE;
        private System.Windows.Forms.TextBox DE;
        private System.Windows.Forms.TextBox SE;
        private System.Windows.Forms.DateTimePicker DTE;
        private System.Windows.Forms.TextBox PE;
        private System.Windows.Forms.ComboBox PTE;
        private System.Windows.Forms.ComboBox AE;
        private System.Windows.Forms.ComboBox OE;
        private System.Windows.Forms.TextBox NE;
        private System.Windows.Forms.Label Doctor;
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