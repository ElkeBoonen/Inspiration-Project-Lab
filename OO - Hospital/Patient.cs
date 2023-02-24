using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Hospital
{
    public class Patient: Person
    {
        public string Problem { get; set; }
        public string Treatment { get; set; }

        public Patient(string name, DateOnly birth, string problem) : base(name, birth)
        {
            Problem = problem;
            Treatment = "None";
        }
        public override string ToString()
        {
            return $"PATIENT: {Name} - {Birth} - {Problem} -> {Treatment}";
        }

    }
}
