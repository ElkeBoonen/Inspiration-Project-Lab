using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Hospital
{
    public class Hospital
    {
        public string Name { get; set; }
        public int ID { get; set; }
        
        private Data _data = new Data();

        public Hospital(string name)
        {
            Name = name;
            ID = _data.InsertHospital(this);
        }

        public Hospital(string name, List<Person> people)
        {
            Name = name;
            ID = _data.InsertHospital(this, people);

        }
        public void AddPerson(Person person)
        {
            _data.AddPeopleToHospital(person.ID, this.ID);            
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
            string s = "HOSPITAL " + Name + "\n";
            s += "---PATIENTS\n";
            foreach (Person person in GetPatients())
            {
                s += " - " + person + "\n";
            }
            s += "---STAFF\n";
            foreach (Person person in GetStaff())
            {
                s += " - " + person + "\n";
            }
            return s;

        }
    }
}
