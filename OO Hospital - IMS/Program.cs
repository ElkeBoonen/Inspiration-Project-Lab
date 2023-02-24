namespace OO_Hospital___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            Patient elke = new Patient(new DateOnly(1980, 4, 23), "Elke", "Teacher syndrome");
            Doctor emma = new Doctor(new DateOnly(2000, 1, 1), "Emma", "Pediatrician");
            Nurse jake = new Nurse(new DateOnly(1990, 2, 2), "Jake", HospitalDepartment.Radiology);

            john.Name = "Frank";
            Console.WriteLine(john.Name);
            //john.Print();

            List<Person> persons = new List<Person>();
            persons.Add(john);
            persons.Add(elke);
            persons.Add(emma);
            persons.Add(jake);
            persons.Add(new Patient(new DateOnly(1991, 4, 16), "Collin", "Teacher syndrome"));
            persons.Add(new Patient(new DateOnly(2023, 7, 10), "Baby van Collin", "Baby syndrome"));
            persons.Add(new Patient(new DateOnly(2023, 2, 9), "Baby Collin", "Baby syndrome"));
            persons.Add(new Doctor(new DateOnly(1980, 4, 16), "Tante Be", "Geriater"));

            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

            Hospital hospital = new Hospital("Sint-Maarten");
            hospital.AddPerson(john);
            hospital.AddPerson(elke);
            hospital.AddPerson(emma);
            hospital.AddPerson(jake);

            Console.WriteLine(hospital);

            Console.WriteLine("\nPATIENTS");
            foreach (Patient p in hospital.GetPatients())
            {
                Console.WriteLine(p);
            }
            
            Console.WriteLine("\nSTAFF");
            foreach (Person p in hospital.GetStaff())
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(emma.Age);
            
        }
    }
}