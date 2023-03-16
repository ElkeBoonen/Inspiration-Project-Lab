using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Patient : Person
    {
        public string Problem { get; set; }
        public string Treatment { get; set; }

        public Patient(DateOnly birth, string name, string problem) : base(birth,name)
        {
            this.Problem = problem;
            this.Treatment = String.Empty;
            // this.Name = name;
            // this.Birth = birth;
            // dit kan ook maar waarom zouden we dat doen? 
            // we hergebruiken de code die we reeds schreven
            // basis van OO!!

            Data data = new Data();
            data.InsertPatient(this);
        }

        public override string ToString()
        {
            return $"Patient {Name} born on {Birth} has {Problem} and is treated with {Treatment}";
        }

    }
}
