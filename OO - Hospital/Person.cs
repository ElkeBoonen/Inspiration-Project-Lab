using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO___Hospital
{
    public class Person
    {
        public string Name { get; set; }
        protected DateOnly Birth { get; set; }
        public int Age { get { return CalculateAge(); } }

        public Person(string name, DateOnly birth)
        {
            Name = name;
            Birth = birth;
        }

        public Person()
        {
            Name = "John Doe";
            Birth = new DateOnly(2000,1,1);
        }

        private int CalculateAge()
        {
            DateTime now = DateTime.Now;
            int age = now.Year - Birth.Year;
            if (now.Year < Birth.Year + age)
            {
                age--;
            }
            return age;
        }

        public override string ToString()
        {
            return $"{Name} - {Birth}";
        }

    }
}
