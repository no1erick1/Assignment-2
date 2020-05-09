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
    public partial class ADDoctor : Form
    {
        public static Doctor doctor = new Doctor();
        public string action2;
        public ADDoctor(string action2)
        {
            InitializeComponent();
            this.action2 = action2;
        }

        private void ADDoctor_Load(object sender, EventArgs e)
        {

        }

        private void addD_Click(object sender, EventArgs e)
        {
            bool checkeddoctor = CheckedDoctor();
            if (checkeddoctor == true)
            {
                
                doctor.IDD = ND.Text.ToString();
                doctor.NameD = DD.Text.ToString();
                doctor.DistrictD = WD.Text.ToString();
                doctor.WardD = PD.Text.ToString();
                doctor.PatientD = GD.Text.ToString();
                doctor.GenderD = GD.Text.ToString();
                doctor.DateofbirthD = TD.Text.ToString();
                doctor.RegencyD = RD.Text.ToString();
                doctor.NationalityD = NaD.Text.ToString();
                this.Close();
            }
        }
        public bool CheckedDoctor()
        {
            string ID = ND.Text.ToString();
            string Name = ND.Text.ToString();
            string District = DD.Text.ToString();
            string Ward = WD.Text.ToString();
            string Patient = GD.Text.ToString();
            string Gender = PD.Text.ToString();
            string Dateofbirth = TD.Text.ToString();
            string Regency = RD.Text.ToString();
            string Nationality = NaD.Text.ToString();

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("ID is empty", "Notification");
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
                MessageBox.Show("Name patient is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Dateofbirth))
            {
                MessageBox.Show("Date of birth is empty", "Notification");
                return false;
            }

            if (string.IsNullOrEmpty(Patient))
            {
                MessageBox.Show("Gender is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Regency))
            {
                MessageBox.Show("Regency is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Nationality))
            {
                MessageBox.Show("Nationality is empty", "Notification");
                return false;
            }
            return true;
        }
    }
}
