using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Nurse : Person
    {
        public HospitalDepartment Department { get; set; }

        private Data _data = new Data();

        public Nurse(DateOnly birth, string name, HospitalDepartment department) : base(birth, name)
        {
            this.Department = department;
            ID = _data.InsertNurse(this);
        }

        public Nurse(int id, DateOnly birth, string name, HospitalDepartment department) : base(birth, name)
        {
            this.Department = department;
            this.ID = id;
        }

        public override string ToString()
        {
            return $"Nurse " + base.ToString() + " works in " + Department;
            //dit zou ook kunnen
            //return $"Nurse {Name} born on {Birth} works in {Department}";
            //return "Nurse " + Name + " born on " + Birth + " works in " + Department;
        }
    }
}
