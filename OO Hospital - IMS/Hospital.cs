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
        public int ID { get; set; }

        private Data _data = new Data();

        public Hospital(string name)
        {
            this.Name = name;
            ID = _data.InsertHospital(this);
        }

        public void AddPerson(Person person)
        {
            _data.AddPersonToHospital(person.ID, this.ID);
        }

        public List<Patient> GetPatients()
        {
            return _data.SelectPatients(this.ID);
        }
        
        public List<Person> GetStaff()
        {
            return _data.SelectStaff(this.ID);
        }

        public override string ToString()
        {
            string s = "\n" + Name + "\n";
            s += "Patients:\n";
            foreach (var item in GetPatients())
            {
                s += " - " + item.ToString() + "\n";
            }
            s += "Staff:\n";
            foreach (var item in GetStaff())
            {
                s += " - " + item.ToString() + "\n";
            }
            return s;
        }

    }
}
