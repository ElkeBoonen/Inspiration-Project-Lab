using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Doctor : Person
    {
        public string Specialty { get; set; }

        private Data _data = new Data();

        public Doctor(DateOnly birth, string name, string specialty) : base(birth, name)
        {
            this.Specialty = specialty;
            ID = _data.InsertDoctor(this);
        }
        public Doctor(int id, DateOnly birth, string name, string specialty) : base(birth, name)
        {
            this.Specialty = specialty;
            this.ID = id;
        }
        public override string ToString()
        {
            return $"Doctor " + base.ToString() + " is a " + Specialty;
        }
    }
}
