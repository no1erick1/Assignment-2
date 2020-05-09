namespace Assignment_2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLOGIN = new System.Windows.Forms.Button();
            this.txtOUT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TXTpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.txtLOGIN);
            this.panel2.Controls.Add(this.txtOUT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 231);
            this.panel2.TabIndex = 1;
            // 
            // txtLOGIN
            // 
            this.txtLOGIN.BackColor = System.Drawing.Color.Violet;
            this.txtLOGIN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtLOGIN.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLOGIN.Location = new System.Drawing.Point(3, 182);
            this.txtLOGIN.Name = "txtLOGIN";
            this.txtLOGIN.Size = new System.Drawing.Size(83, 28);
            this.txtLOGIN.TabIndex = 1;
            this.txtLOGIN.Text = "Log in";
            this.txtLOGIN.UseVisualStyleBackColor = false;
            this.txtLOGIN.Click += new System.EventHandler(this.txtLOGIN_Click);
            // 
            // txtOUT
            // 
            this.txtOUT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOUT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtOUT.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOUT.Location = new System.Drawing.Point(310, 182);
            this.txtOUT.Name = "txtOUT";
            this.txtOUT.Size = new System.Drawing.Size(94, 28);
            this.txtOUT.TabIndex = 1;
            this.txtOUT.Text = "Out";
            this.txtOUT.UseVisualStyleBackColor = false;
            this.txtOUT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(82, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "MANAGE OF HOSPITAL";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TXTpw);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 53);
            this.panel3.TabIndex = 0;
            // 
            // TXTpw
            // 
            this.TXTpw.Location = new System.Drawing.Point(123, 19);
            this.TXTpw.Name = "TXTpw";
            this.TXTpw.Size = new System.Drawing.Size(278, 22);
            this.TXTpw.TabIndex = 1;
            this.TXTpw.TextChanged += new System.EventHandler(this.TXTpw_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtUN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 53);
            this.panel1.TabIndex = 0;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(123, 17);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(278, 22);
            this.txtUN.TabIndex = 1;
            this.txtUN.UseSystemPasswordChar = true;
            this.txtUN.TextChanged += new System.EventHandler(this.txtbxUN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passwords";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 235);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TXTpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.Button txtLOGIN;
        private System.Windows.Forms.Button txtOUT;
    }
}

