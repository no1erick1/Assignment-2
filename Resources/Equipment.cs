using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Resources
{
    public class Equipment
    {
        public string IDE { get; set; }
        public string NameE { get; set; }
        public string OriginE { get; set; }
        public string AddressE { get; set; }
        public string PatientE { get; set; }
        public string PurposetouseE { get; set; }
        public string Dateofpurchase { get; set; }
        public string StatusE { get; set; }
        public string Doctor { get; set; }

        public Equipment()
        {
            this.IDE = "";
            this.NameE = "";
            this.OriginE = "";
            this.AddressE = "";
            this.PatientE = "";
            this.PurposetouseE = "";
            this.Dateofpurchase = "";
            this.StatusE = "";
            this.Doctor = "";
        }
        public Equipment(string IDE, string NameE ,string OriginE ,string AddressE ,string PatientE ,string PurposetouseE , string Dateofpurchase , string StatusE , string Doctor )
        {
            this.IDE = IDE;
            this.NameE = NameE;
            this.OriginE = OriginE;
            this.AddressE = AddressE;
            this.PatientE = PatientE;
            this.PurposetouseE = PurposetouseE;
            this.Dateofpurchase = Dateofpurchase;
            this.StatusE = StatusE;
            this.Doctor = Doctor;
        }
        public Equipment(Equipment E)
        {
            this.IDE = E.IDE;
            this.NameE = E.NameE;
            this.OriginE = E.OriginE;
            this.AddressE = E.AddressE;
            this.PatientE = E.PatientE;
            this.PurposetouseE = E.PurposetouseE;
            this.Dateofpurchase = E.Dateofpurchase;
            this.StatusE = E.StatusE;
            this.Doctor = E.Doctor;
        }
    }
}
