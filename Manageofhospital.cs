
using Assignment_2.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Manageofhospital : Form
    {
      
        public static List<Equipment> listEquipment { get; set; }
        public static List<Doctor> listDoctor { get; set; }
        public static List<Patient1> listPatient{ get; set; }
        
        public Patient1 PatientSelected { get; set; }
        public Doctor DoctorSelected { get; set; }
      public Equipment EquipmentSelected { get; set; }
        public Manageofhospital()
        {
          
            InitializeComponent();
            Manageofhospital.listEquipment = new List<Equipment>();
            Manageofhospital.listPatient = new List<Patient1>();
            Manageofhospital.listDoctor = new List<Doctor>();
        
           
            LoadPatient();
            LoadDoctor();
            LoadEquipment();
         }
       
        public void LoadEquipment()
        {
            listView4.Items.Clear();
            Equipment emty2;
            for(int e=0; e < Manageofhospital.listEquipment.Count; e++)
            {
                ListViewItem subItem2 = new ListViewItem();
                emty2 = (Equipment)Manageofhospital.listEquipment[e];
                subItem2.Text = e.ToString();
                subItem2.SubItems.Add(emty2.IDE.ToString());
                subItem2.SubItems.Add(emty2.NameE.ToString());
                subItem2.SubItems.Add(emty2.OriginE.ToString());
                subItem2.SubItems.Add(emty2.AddressE.ToString());
                subItem2.SubItems.Add(emty2.PatientE.ToString());
                subItem2.SubItems.Add(emty2.PurposetouseE.ToString());
                subItem2.SubItems.Add(emty2.Dateofpurchase.ToString());
                subItem2.SubItems.Add(emty2.StatusE.ToString());
                subItem2.SubItems.Add(emty2.Doctor.ToString());
                listView4.Items.Add(subItem2);
            }
        }
      public void LoadDoctor()
        {
            listView2.Items.Clear();
            Doctor emty1;
            for(int a =0;a<Manageofhospital.listDoctor.Count; a++)
            {
                ListViewItem subItem1 = new ListViewItem();
                emty1 = (Doctor)Manageofhospital.listDoctor[a];
                subItem1.Text = a.ToString();
                subItem1.SubItems.Add(emty1.IDD.ToString());
                subItem1.SubItems.Add(emty1.NameD.ToString());
                subItem1.SubItems.Add(emty1.DistrictD.ToString());
                subItem1.SubItems.Add(emty1.WardD.ToString());
                subItem1.SubItems.Add(emty1.PatientD.ToString());
                subItem1.SubItems.Add(emty1.DateofbirthD.ToString());
                subItem1.SubItems.Add(emty1.GenderD.ToString());
                subItem1.SubItems.Add(emty1.NationalityD.ToString());
                subItem1.SubItems.Add(emty1.RegencyD.ToString());
                listView2.Items.Add(subItem1);
            }
           
        }
            public void LoadPatient()
        {
            listView1.Items.Clear();         
            Patient1 temp;
            for (int i = 0; i < Manageofhospital.listPatient.Count; i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Patient1)Manageofhospital.listPatient[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.Id.ToString());
                subItem.SubItems.Add(temp.Name.ToString());
                subItem.SubItems.Add(temp.District.ToString());
                subItem.SubItems.Add(temp.Ward.ToString());
                subItem.SubItems.Add(temp.Indentitycard.ToString());
                subItem.SubItems.Add(temp.Dateofbirth.ToString());
                subItem.SubItems.Add(temp.Sick.ToString());
                subItem.SubItems.Add(temp.Nationality.ToString());
                subItem.SubItems.Add(temp.Gender.ToString());             
                listView1.Items.Add(subItem);
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                TXTID.Text = listView1.SelectedItems[0].SubItems[0].Text;
                TXTname.Text = listView1.SelectedItems[0].SubItems[1].Text;
                TXTDistrict.Text = listView1.SelectedItems[0].SubItems[2].Text;
                TXTWard.Text = listView1.SelectedItems[0].SubItems[3].Text;
                TXTCm.Text = listView1.SelectedItems[0].SubItems[4].Text;
                TXTGender.Text = listView1.SelectedItems[0].SubItems[5].Text;
                TXTDOB.Text = listView1.SelectedItems[0].SubItems[6].Text;
                TXTSick.Text = listView1.SelectedItems[0].SubItems[7].Text;
                TXTNa.Text = listView1.SelectedItems[0].SubItems[8].Text;
            }

            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                PatientSelected = (Patient1)Manageofhospital.listPatient[index];
            }      
        }

        private void TXTGender_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 1)
            {
                IDD.Text = listView2.SelectedItems[0].SubItems[0].Text;
                ND.Text = listView2.SelectedItems[0].SubItems[1].Text;
                DD.Text = listView2.SelectedItems[0].SubItems[2].Text;
                WD.Text = listView2.SelectedItems[0].SubItems[3].Text;
                PD.Text = listView2.SelectedItems[0].SubItems[4].Text;
                GD.Text = listView2.SelectedItems[0].SubItems[5].Text;
                TD.Text = listView2.SelectedItems[0].SubItems[6].Text;
                RD.Text = listView2.SelectedItems[0].SubItems[7].Text;
                NaD.Text = listView2.SelectedItems[0].SubItems[8].Text;
            }
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count==1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                DoctorSelected = (Doctor)Manageofhospital.listDoctor[index];
            }
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 1)
            {
                IE.Text = listView4.SelectedItems[0].SubItems[0].Text;
                NE.Text = listView4.SelectedItems[0].SubItems[1].Text;
                OE.Text = listView4.SelectedItems[0].SubItems[2].Text;
                AE.Text = listView4.SelectedItems[0].SubItems[3].Text;
                PE.Text = listView4.SelectedItems[0].SubItems[4].Text;
                PTE.Text = listView4.SelectedItems[0].SubItems[5].Text;
                DTE.Text = listView4.SelectedItems[0].SubItems[6].Text;
                SE.Text = listView4.SelectedItems[0].SubItems[7].Text;
                DOE.Text = listView4.SelectedItems[0].SubItems[8].Text;
            }
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index = Convert.ToInt32(item.Text);
                EquipmentSelected = (Equipment)Manageofhospital.listEquipment[index];
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }      
        private void button2_Click(object sender, EventArgs e)
        {           
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

       

       
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            ADDPATIENT formAdd1 = new ADDPATIENT("Add");
            formAdd1.ShowDialog();
            if (ADDPATIENT.patient != null)
            {
                Patient1 p = new Patient1(ADDPATIENT.patient);

                if (string.IsNullOrEmpty(p.Name.ToString()) || string.IsNullOrEmpty(p.District.ToString()) || string.IsNullOrEmpty(p.Ward.ToString()) || string.IsNullOrEmpty(p.Gender.ToString()) || string.IsNullOrEmpty(p.Indentitycard.ToString()) || string.IsNullOrEmpty(p.Dateofbirth.ToString()) || string.IsNullOrEmpty(p.Sick.ToString()) || string.IsNullOrEmpty(p.Nationality.ToString()))
                {
                    MessageBox.Show("Add successful but empty", "Notification");
                }
                else
                {
                    listPatient.Add(p);
                    MessageBox.Show("Add successful", "Notification");
                    LoadPatient();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ADDPATIENT formUpdate = new ADDPATIENT("update");

            int index = Manageofhospital.listPatient.IndexOf(this.PatientSelected);
            ADDPATIENT.patient.Id = PatientSelected.Id;
            ADDPATIENT.patient.Name = PatientSelected.Name;
            ADDPATIENT.patient.District = PatientSelected.District;
            ADDPATIENT.patient.Ward = PatientSelected.Ward;
            ADDPATIENT.patient.Indentitycard = PatientSelected.Indentitycard;
            ADDPATIENT.patient.Gender = PatientSelected.Gender;
            ADDPATIENT.patient.Dateofbirth = PatientSelected.Dateofbirth;
            ADDPATIENT.patient.Sick = PatientSelected.Sick;
            ADDPATIENT.patient.Nationality = PatientSelected.Nationality;
            formUpdate.ShowDialog();

            Patient1 a = (Patient1)listPatient[index];
            a.Id = ADDPATIENT.patient.Id;
            a.Name = ADDPATIENT.patient.Name;
            a.District = ADDPATIENT.patient.District;
            a.Ward = ADDPATIENT.patient.Ward;
            a.Indentitycard = ADDPATIENT.patient.Indentitycard;
            a.Gender = ADDPATIENT.patient.Gender;
            a.Dateofbirth = ADDPATIENT.patient.Dateofbirth;
            a.Sick = ADDPATIENT.patient.Sick;
            a.Nationality = ADDPATIENT.patient.Nationality;
            ADDPATIENT.patient = null;
            LoadPatient();
            MessageBox.Show("Update successful");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you really want to delete", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                Manageofhospital.listPatient.Remove(this.PatientSelected);
                LoadPatient();
                MessageBox.Show("Delete successful", "Notification");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ADDoctor formAdd2 = new ADDoctor("Add");
            formAdd2.ShowDialog();
            if (ADDoctor.doctor != null)
            {
                Doctor D = new Doctor(ADDoctor.doctor);

                if (string.IsNullOrEmpty(D.NameD.ToString()) || string.IsNullOrEmpty(D.DistrictD.ToString()) || string.IsNullOrEmpty(D.WardD.ToString()) || string.IsNullOrEmpty(D.GenderD.ToString()) || string.IsNullOrEmpty(D.PatientD.ToString()) || string.IsNullOrEmpty(D.DateofbirthD.ToString()) || string.IsNullOrEmpty(D.RegencyD.ToString()) || string.IsNullOrEmpty(D.NationalityD.ToString()))
                {
                    MessageBox.Show("Add successful but empty", "Notification");
                }
                else
                {
                    listDoctor.Add(D);
                    MessageBox.Show("Add successful", "Notification");
                    LoadDoctor();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ADDoctor formUpdate1 = new ADDoctor("update");

            int index = Manageofhospital.listDoctor.IndexOf(this.DoctorSelected);
            ADDoctor.doctor.IDD = DoctorSelected.IDD;
            ADDoctor.doctor.NameD = DoctorSelected.NameD;
            ADDoctor.doctor.DistrictD = DoctorSelected.DistrictD;
            ADDoctor.doctor.WardD = DoctorSelected.WardD;
            ADDoctor.doctor.PatientD = DoctorSelected.PatientD;
            ADDoctor.doctor.GenderD = DoctorSelected.GenderD;
            ADDoctor.doctor.DateofbirthD = DoctorSelected.DateofbirthD;
            ADDoctor.doctor.RegencyD = DoctorSelected.RegencyD;
            ADDoctor.doctor.NationalityD = DoctorSelected.NationalityD;
            formUpdate1.ShowDialog();

            Doctor D = (Doctor)listDoctor[index];
            D.IDD = ADDoctor.doctor.IDD;
            D.NameD = ADDoctor.doctor.NameD;
            D.DistrictD = ADDoctor.doctor.DistrictD;
            D.WardD = ADDoctor.doctor.WardD;
            D.PatientD = ADDoctor.doctor.PatientD;
            D.GenderD = ADDoctor.doctor.GenderD;
            D.DateofbirthD = ADDoctor.doctor.DateofbirthD;
            D.RegencyD = ADDoctor.doctor.RegencyD;
            D.NationalityD = ADDoctor.doctor.NationalityD;
            ADDoctor.doctor = null;
            LoadDoctor();
            MessageBox.Show("Update successful");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you really want to delete", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                Manageofhospital.listDoctor.Remove(this.DoctorSelected);
                LoadDoctor();
                MessageBox.Show("Delete successful", "Notification");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ADDEquipment formAdd2 = new ADDEquipment("Add");
            formAdd2.ShowDialog();
            if (ADDEquipment.equipment != null)
            {
                Equipment E = new Equipment(ADDEquipment.equipment);

                if (string.IsNullOrEmpty(E.NameE.ToString()) || string.IsNullOrEmpty(E.OriginE.ToString()) || string.IsNullOrEmpty(E.AddressE.ToString()) || string.IsNullOrEmpty(E.PatientE.ToString()) || string.IsNullOrEmpty(E.PurposetouseE.ToString()) || string.IsNullOrEmpty(E.Dateofpurchase.ToString()) || string.IsNullOrEmpty(E.StatusE.ToString()) || string.IsNullOrEmpty(E.Doctor.ToString()))
                {
                    MessageBox.Show("Add successful but empty", "Notification");
                }
                else
                {
                    listEquipment.Add(E);
                    MessageBox.Show("Add successful", "Notification");
                    LoadEquipment();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ADDEquipment formUpdate2 = new ADDEquipment("update");

            int index = Manageofhospital.listEquipment.IndexOf(this.EquipmentSelected);
            ADDEquipment.equipment.IDE = EquipmentSelected.IDE;
            ADDEquipment.equipment.NameE = EquipmentSelected.NameE;
            ADDEquipment.equipment.OriginE = EquipmentSelected.OriginE;
            ADDEquipment.equipment.AddressE = EquipmentSelected.AddressE;
            ADDEquipment.equipment.PatientE = EquipmentSelected.PatientE;
            ADDEquipment.equipment.PurposetouseE = EquipmentSelected.PurposetouseE;
            ADDEquipment.equipment.Dateofpurchase = EquipmentSelected.Dateofpurchase;
            ADDEquipment.equipment.StatusE = EquipmentSelected.StatusE;
            ADDEquipment.equipment.Doctor = EquipmentSelected.Doctor;
            formUpdate2.ShowDialog();

            Equipment E = (Equipment)listEquipment[index];
            E.IDE = ADDEquipment.equipment.IDE;
            E.NameE = ADDEquipment.equipment.NameE;
            E.OriginE = ADDEquipment.equipment.OriginE;
            E.AddressE = ADDEquipment.equipment.AddressE;
            E.PatientE = ADDEquipment.equipment.PatientE;
            E.PurposetouseE = ADDEquipment.equipment.PurposetouseE;
            E.Dateofpurchase = ADDEquipment.equipment.Dateofpurchase;
            E.StatusE = ADDEquipment.equipment.StatusE;
            E.Doctor = ADDEquipment.equipment.Doctor;
            ADDEquipment.equipment = null;
            LoadEquipment();
            MessageBox.Show("Update successful");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                
                Manageofhospital.listEquipment.Remove(this.EquipmentSelected);
                LoadEquipment();
                MessageBox.Show("Delete successful", "Notification");
            }         
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Manageofhospital_Load(object sender, EventArgs e)
        {

        }
    }
}
