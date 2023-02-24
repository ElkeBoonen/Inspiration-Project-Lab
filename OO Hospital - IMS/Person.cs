using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Hospital___IMS
{
    class Person
    {
        private DateOnly Birth { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public Person()
        {
            Birth = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Name = "John Doe";
            Role = "Patient";
        }
        public Person(DateOnly birth, string name, string role)
        {
            this.Birth = birth;
            this.Name = name;
            this.Role = role;
        }

        // Print-methode wordt vervangen door ToString() --> cutting dependencies
        /* public void Print()
        {
            Console.WriteLine();
            //Console.WriteLine(Name + " is " + Role + ", is born on " + Birth);
        }*/

        public override string ToString()
        {
            return $"{Name} is {Role}, born on {Birth}";
        }
    }
}
