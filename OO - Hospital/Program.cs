namespace OO___Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient elke = new Patient("Elke", new DateOnly(1980, 4, 23), "Teacher Syndrome");
            Doctor jenny = new Doctor("Jenny", new DateOnly(1970,1,1), "Heart");
            Patient collin = new Patient("Collin", new DateOnly(1991, 4, 16), "Teacher Syndrome");
            Nurse josh = new Nurse("Josh", new DateOnly(2000,1,1), Area.Emergency);

            List<Person> people = new List<Person>();
            people.Add(elke);
            people.Add(jenny);
            people.Add(collin);
            people.Add(josh);

            Hospital hospital = new Hospital("AZ Sint-Maarten", people);

            Doctor bea = new Doctor("Bea", new DateOnly(1970, 1, 1), "Dermatology");
            hospital.AddPerson(bea);

            Console.WriteLine(hospital);
            
        }
    }
}