using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Hospital
    {
        public string Name { get; set; }
        private List<Person> People { get; set; }

        public Hospital(string name)
        {
            this.Name = name;
            this.People = new List<Person>();
        }

        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();
            foreach (Person p in People)
            {
                if (p is Patient)
                {
                    patients.Add((Patient)p);
                }
            }
            return patients;
        }

        public List<Person> GetStaff()
        {
            List<Person> staff = new List<Person>();
            foreach (Person p in People)
            {
                if (p is Doctor || p is Nurse) //als we hier is not Patient doen, komen ook de personen mee in de staff
                {
                    staff.Add(p);
                }
            }
            return staff;
        }

        public void AddPerson(Person p)
        {
            People.Add(p);
        }

        public override string ToString()
        {
            string s = "\n" + Name + "\n";
            foreach (var item in People)
            {
                s += " - " + item.ToString() + "\n";
            }
            return s;
        }
    }
}
