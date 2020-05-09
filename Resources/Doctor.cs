using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Resources
{
    public class Doctor
    {
        public string IDD { get; set; }
        public string NameD { get; set; }
        public string DistrictD { get; set; }
        public string WardD { get; set; }
        public string PatientD{ get; set; }
        public string GenderD { get; set; }
        public string DateofbirthD { get; set; }
        public string RegencyD { get; set; }
        public string NationalityD{ get; set; }

        public Doctor()
        {
            this.IDD = "";
            this.NameD = "";
            this.DistrictD = "";
            this.WardD = "";
            this.PatientD = "";
            this.GenderD = "";
            this.DateofbirthD = "";
            this.RegencyD = "";
            this.NationalityD = "";
        }
        public Doctor(string IDD, string NameD, string DistrictD, string PatientD, string WardD, string GenderD, string DateofbirthD, string RegencyD, string NationalityD)
        {
            this.IDD = IDD;
            this.NameD = NameD;
            this.DistrictD = DistrictD;
            this.WardD = WardD;
            this.PatientD = PatientD;
            this.GenderD = GenderD;
            this.DateofbirthD = DateofbirthD;
            this.RegencyD = RegencyD;
            this.NationalityD = NationalityD;
        }
        public Doctor(Doctor D)
        {
            this.IDD = D.IDD;
            this.NameD = D.NameD;
            this.DistrictD = D.DistrictD;
            this.WardD = D.WardD;
            this.PatientD = D.PatientD;
            this.GenderD = D.GenderD;
            this.DateofbirthD = D.DateofbirthD;
            this.RegencyD = D.RegencyD;
            this.NationalityD = D.NationalityD;
        }
    }  
}
