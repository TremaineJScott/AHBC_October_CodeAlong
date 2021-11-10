using System;

namespace AhbcOctoberWeekFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Animal newAnimal = new Animal();

            Dog myDog = new Dog();
            myDog.Name = "Bear";
            myDog.Age = 2;
            myDog.FoodType = "Peanut Butter Dog Food";
            myDog.FurType = "hair";
            myDog.Grow(12); // increasing height (base class functionality)

            Fish thisFish = new Fish() { Name = "red fish" };
            thisFish.WaterType = "Salt Water";
            thisFish.Grow(2); // increasing length (derived class functionality)

            Labradoodle bear = new Labradoodle();
            
            try
            {
                int zero = 0;
                int calc = 12 / zero;
            }
            catch (DivideByZeroException ex)
            {
                ExceptionManager.LogException(ex,DateTime.Now,"stremaine");
            }

            ExportDataManager.ExportData(@"C:\Code");

            DataRepository newRepo = new DataRepository();
            newRepo.DatabaseName = "ThisTable";
            ExportDataManager.ExportData("data",newRepo);

            ExportDataManager.ExportData("data",
                new DataRepository { DatabaseName = "thatTable", Servername = "thisServer" });

        }

        
    }
}
