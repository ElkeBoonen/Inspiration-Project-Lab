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
        public DateOnly Birth { get; protected set; }
        public string Name { get; set; }
        public int Age { get { return CalculateAge(); }  }

        public int ID { get; set; }

        public Person()
        {
            Birth = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Name = "John Doe";
        }
        public Person(DateOnly birth, string name)
        {
            this.Birth = birth;
            this.Name = name;
        }

        // Print-methode wordt vervangen door ToString() --> cutting dependencies
        /* public void Print()
        {
            Console.WriteLine();
            //Console.WriteLine(Name + " is " + Role + ", is born on " + Birth);
        }*/

        private int CalculateAge()
        {
            int age = DateTime.Now.Year - Birth.Year;
            if (DateTime.Now.Month < Birth.Month || (DateTime.Now.Month == Birth.Month && DateTime.Now.Day < Birth.Day))
            {
                age--;
            }
            return age;
        }

        public override string ToString()
        {
            return $"{Name} born on {Birth}";
        }
    }
}
