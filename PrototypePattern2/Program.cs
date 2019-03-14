using System;

namespace PrototypePattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer()
            {
                age = 20,
                name = "James",
                language = "C#",
                salary = 150,
                title = "Junior"
            };

            Developer devCopy = (Developer)developer.Clone();
            devCopy.name = "Sean";
            devCopy.language = "Java";

            Console.WriteLine(developer.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Administrator administrator = new Administrator()
            {
                age = 25,
                name = "Jenny",
                salary = 120,
                title = "Junior"
            };
            Administrator adminCopy = (Administrator)administrator.Clone();
            adminCopy.name = "Huel";

            Console.WriteLine(administrator.GetDetails());
            Console.WriteLine(adminCopy.GetDetails());

            Console.ReadLine();
        }
    }
}
