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
    public partial class ADDEquipment : Form
    {
        public static Equipment equipment = new Equipment();
        public string action3;
        public ADDEquipment(string action3)
        {
            InitializeComponent();
            this.action3 = action3;
        }
        public bool CheckedEquipment()
        {
            string ID = NE.Text.ToString();
            string Name = NE.Text.ToString();
            string Origin = OE.Text.ToString();
            string Adsress = AE.Text.ToString();
            string Patien = PTE.Text.ToString();
            string Purposetouse = PE.Text.ToString();
            string Dateofpurchase = DTE.Text.ToString();
            string Status =SE.Text.ToString();
            string Doctor = DE.Text.ToString();

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
            if (string.IsNullOrEmpty(Origin))
            {
                MessageBox.Show("Origin is empty", "Notification");
                return false;
            }

            if (string.IsNullOrEmpty(Adsress))
            {
                MessageBox.Show("Addess is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Patien))
            {
                MessageBox.Show("Patient is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Dateofpurchase))
            {
                MessageBox.Show("Date of purchase is empty", "Notification");
                return false;
            }

            if (string.IsNullOrEmpty(Purposetouse))
            {
                MessageBox.Show("Purpose To Use is emty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Status is empty", "Notification");
                return false;
            }
            if (string.IsNullOrEmpty(Doctor))
            {
                MessageBox.Show("Doctor's name is empty", "Notification");
                return false;
            }
            return true;
        }
        
        private void ADDEquipment_Load(object sender, EventArgs e)
        {

        }

        private void addE_Click(object sender, EventArgs e)
        {
            bool checkedequipment = CheckedEquipment();
            if (checkedequipment == true)
            {

                equipment.IDE = NE.Text.ToString();
                equipment.NameE = OE.Text.ToString();
                equipment.OriginE = AE.Text.ToString();
                equipment.AddressE = PE.Text.ToString();
                equipment.PatientE= PE.Text.ToString();
                equipment.PurposetouseE = DTE.Text.ToString();
                equipment.Dateofpurchase = PTE.Text.ToString();
                equipment.StatusE = SE.Text.ToString();
                equipment.Doctor = DE.Text.ToString();
                this.Close();
            }
        }

        
    }
}
