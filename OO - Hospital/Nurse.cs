using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Hospital
{
    public class Nurse: Person
    {
        public Area Department { get; set; }
        private Data _data = new Data();
        public Nurse(string name, DateOnly birth, Area department) : base(name, birth)
        {
            Department = department;
            ID = _data.InsertNurse(this);
        }
        public Nurse(int id, string name, DateOnly birth, Area department) : base(id, name, birth)
        {
            Department = department;
        }
        public override string ToString()
        {
            return $"NURSE: {ID} - {Name} - {Birth} - {Department}";
        }
    }
}
