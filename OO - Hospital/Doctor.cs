using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Hospital
{
    public class Doctor: Person
    {
        public string Specialty { get; set; }
        public Doctor(string name, DateOnly birth, string specialty) : base(name, birth)
        {
            Specialty = specialty;
        }
        public override string ToString()
        {
            return $"DOCTOR: {Name} - {Birth} - {Specialty}";
        }

    }
}
