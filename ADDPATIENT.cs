using Assignment_2.Resources;
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
    public partial class ADDPATIENT : Form
    {
        public static Patient1 patient = new Patient1();
        public string action;              
        public ADDPATIENT(string action)

        {
            InitializeComponent();
            this.action = action;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // b1: kiểm tra form hợp lệ
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                patient.Id = TXTname.Text.ToString();
                patient.Name = TXTDistrict.Text.ToString();
                patient.District = TXTWard.Text.ToString();
                patient.Ward = TXTCm.Text.ToString();
                patient.Indentitycard = TXTGender.Text.ToString();
                patient.Gender = TXTGender.Text.ToString();
                patient.Dateofbirth = TXTDOB.Text.ToString();
                patient.Sick = TXTSick.Text.ToString();
                patient.Nationality = TXTNa.Text.ToString();
                this.Close();
            }
        }

        public bool CheckAvailible()
        {
            string ID= TXTname.Text.ToString();
            string Name = TXTname.Text.ToString();
            string District = TXTDistrict.Text.ToString();
            string Ward = TXTWard.Text.ToString();
            string Indentitycard = TXTGender.Text.ToString();
            string  Gender = TXTCm.Text.ToString();
          string Dateofbirth = TXTDOB.Text.ToString();
           string Sick = TXTSick.Text.ToString();
           string Nationality = TXTNa.Text.ToString();
        
            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Name is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("District is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(District))
            {
                MessageBox.Show("District is empty", "Notification");
                return false;
            }

            if (string.IsNullOrEmpty(Ward))
            {
                MessageBox.Show("Ward is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Gender))
            {
                MessageBox.Show("Indentitycard is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Dateofbirth))
            {
                MessageBox.Show("Date of birth is empty", "Notification");
                return false;
            }

            if (string.IsNullOrEmpty(Indentitycard))
            {
                MessageBox.Show("Gender is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Sick))
            {
                MessageBox.Show("Sick is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Nationality))
            {
                MessageBox.Show("Nationality is empty", "Notification");
                return false;
            }
            return true;
        }

        private void TXTGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ADDPATIENT_Load(object sender, EventArgs e)
        {
        }   

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void TXTSick_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
