using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to out", "Notification",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel= true;
            }
        }
        private void txtLOGIN_Click(object sender, EventArgs e)
        {
             
                Introduce g = new Introduce();
                this.Hide();
                g.ShowDialog();
              
        }     
        private void TXTpw_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtbxUN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
