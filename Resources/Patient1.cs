using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2.Resources
{
    public class Patient1
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Indentitycard { get; set; }
        public string Gender { get; set; }
        public string Dateofbirth { get; set; }
        public string Sick { get; set; }
        public string Nationality { get; set; }

        public Patient1()
        {
            this.Id = "";
            this.Name = "";
            this.District = "";
            this.Indentitycard = "";
            this.Ward = "";
            this.Gender = "";
            this.Dateofbirth = "";
            this.Sick = "";
            this.Nationality = "";
         }
       public Patient1(string Id, string Name, string District, string Indentitycard, string Ward, string Gender, string Dateofbirth, string Sick, string Nationality )
       {

            this.Id = Id;
            this.Name = Name;
            this.District = District;
            this.Indentitycard = Indentitycard;
            this.Ward = Ward;
            this.Gender = Gender;
            this.Dateofbirth = Dateofbirth;
            this.Sick = Sick;
            this.Nationality = Nationality;

        }

        public Patient1(Patient1 p)
        {

            this.Id = p.Id;
            this.Name = p.Name;
            this.District = p.District;
            this.Indentitycard = p.Indentitycard;
            this.Ward = p.Ward;
            this.Gender = p.Gender;
            this.Dateofbirth = p.Dateofbirth;
            this.Sick = p.Sick;
            this.Nationality = p.Nationality;

        }
        
    }
   
}
