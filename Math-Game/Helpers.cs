namespace Math_Game
{
    internal class Helpers
    {
        internal static string GetUserName()
        {
            Console.WriteLine("Hello there, first lets get to know you. What is your name?");
            string name = Console.ReadLine().Trim().ToUpper();

            return name;
        }

        internal static void Greeting() 
        {
            DateTime time = DateTime.Now;
            string name = GetUserName();

            int militaryTime = Convert.ToInt32(time.ToString("HH"));
            if (militaryTime >= 1 && militaryTime <= 12)
            {
                Console.WriteLine($"Good Morning {name}, Please choose from the menu below..");
            } else if (militaryTime >= 13 && militaryTime <= 17)
            {
                Console.WriteLine($"Good afternoon {name}, Please choose from the menu below..");
            } else
            {
                Console.WriteLine($"Good evening {name}, Please choose from the menu below: ");
            }

        }

        internal static (int random1, int random2) LevelOfDificulty() 
        {
            Random random = new Random();

            int random1 = 0;
            int random2 = 0;

            Console.WriteLine(@"Choose your level of difficulty: 
'E' Easy (1 to 10).
'M' Medium (1 to 50).
'D' Difficult (1 to 100).");

            string userChoice = Console.ReadLine().Trim().ToUpper();

            switch(userChoice)
            {
                case "E":
                    random1 = random.Next(1, 11);
                    random2 = random.Next(1, 11);
                    break;
                case "M":
                    random1 = random.Next(1, 51);
                    random2 = random.Next(1, 51);
                    break;
                case "D":
                    random1 = random.Next(1, 101);
                    random2 = random.Next(1, 101);
                    break;
            }

            return (random1, random2);

        }
    }
}
