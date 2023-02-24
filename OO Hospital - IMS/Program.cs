namespace OO_Hospital___IMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            Person elke = new Person(new DateOnly(1980, 4, 23), "Elke", "Patient");
            Person emma = new Person(new DateOnly(2000, 1, 1), "Emma", "Doctor");
            Person jake = new Person(new DateOnly(1990, 2, 2), "Jake", "Nurse");

            Console.WriteLine(john.Name + " " + john.Role);
            Console.WriteLine(elke.Name + " " + elke.Role);
            Console.WriteLine(emma.Name + " " + emma.Role);

            john.Name = "Frank";
            Console.WriteLine(john.Name + " " + john.Role);

            //john.Print();
           
            Console.WriteLine(elke);

        }
    }
}