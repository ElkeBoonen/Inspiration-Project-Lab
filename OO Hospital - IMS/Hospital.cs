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

        /*
        public List<Patient> GetPatients()
        {
           
        }

        public List<Person> GetStaff()
        {
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
        */
    }
}
