using System;
using Assignment_2.Resources;
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
    public partial class ADD : Form
    {
        public static SupplyFood Food = new SupplyFood();
        public ADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // b1: kiểm tra form hợp lệ
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                Food.FoodWater = TXTF.Text.ToString();
                Food.CategoryFood = TXTCF.Text.ToString();
                Food.Patient = TXTP.Text.ToString();                              
                this.Close();
            }
        }

        public bool CheckAvailible()
        {
            string name =TXTF.Text.ToString();
            string kind = TXTCF.Text.ToString();
            string patient = TXTP.Text.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name of food or water is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(kind))
            {
                MessageBox.Show("Category Food is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(patient))
            {
                MessageBox.Show("Name patient is empty", "Notification");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }
    }
}
