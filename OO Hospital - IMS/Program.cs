namespace OO_Hospital___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient elke = new Patient(new DateOnly(1980, 4, 23), "Elke", "Teacher syndrome");
            Patient collin = new Patient(new DateOnly(1991, 4, 16), "Collin", "Teacher syndrome");
        }
    }
}