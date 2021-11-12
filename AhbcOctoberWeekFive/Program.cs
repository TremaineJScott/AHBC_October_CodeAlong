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
            myDog.FurType = "Hair";
            myDog.Grow(12); // increasing height (base class functionality)
            myDog.Sleep(8, "the floor");
            ExecuteBirthingMethod(myDog);
            
            Fish thisFish = new Fish() { Name = "red fish" };
            thisFish.WaterType = "Salt Water";
            thisFish.Grow(2); // increasing length (derived class functionality)
            thisFish.IncubationTime = 20;
            ExecuteBirthingMethod(thisFish);

            BoaConstrictor boa = new BoaConstrictor() { IncubationTime = 10 };
            Labradoodle bear = new Labradoodle();
            ExecuteBirthingMethod(bear);
            ExecuteBirthingMethod(boa);
            DisplayIncubationTime(boa);
            DisplayIncubationTime(thisFish);            

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

        public static int ValidateInteger(string input)
        {
            int validInt = -1;
            bool isValid = int.TryParse(input,out validInt);
            return validInt;
            CheckRange(input);
        }

        public static bool CheckRange(string input)
        {
            return true;
        }

        public static void DisplayEgglayerStuff(IEggLayer eggLayer)
        {
            if (eggLayer.LayEggs() == true)
            {
                Console.WriteLine(eggLayer.IncubationTime);
            }
        }

        public static void DisplayIncubationTime(IEggLayer eggLayer)
        {
            Console.WriteLine(eggLayer.IncubationTime);
        }

        public static void ExecuteBirthingMethod(ILiveBirthGiver animal)
        {
            Console.WriteLine("You have giving live birth.");
        }

        public static void ExecuteBirthingMethod(IEggLayer animal)
        {
            Console.WriteLine($"You have laid eggs.");
        }



    }
}
