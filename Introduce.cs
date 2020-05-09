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
    public partial class Introduce : Form
    {
        public Introduce()
        {
            InitializeComponent();
        }

        private void Introduce_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manageofhospital f = new Manageofhospital();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             SupplyProduct a = new SupplyProduct();
                this.Hide();
                a.ShowDialog();
            this.Show();
        }
    }
}
