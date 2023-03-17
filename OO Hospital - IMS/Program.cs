namespace OO_Hospital___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient elke = new Patient(new DateOnly(1980, 4, 23), "Elke", "Teacher syndrome");
            Patient collin = new Patient(new DateOnly(1991, 4, 16), "Collin", "Teacher syndrome");
            Doctor be = new Doctor(new DateOnly(1980, 4, 16), "Benedikte", "Geriatrie");
            Nurse bart = new Nurse(new DateOnly(2000, 4, 16), "Bart", HospitalDepartment.Cardiology);

            Hospital stmaarten = new Hospital("Sint Maarten 2");
            stmaarten.AddPerson(elke);
            stmaarten.AddPerson(collin);
            stmaarten.AddPerson(be);
            stmaarten.AddPerson(bart);
        }
    }
}