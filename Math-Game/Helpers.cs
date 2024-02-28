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
            }
            else if (militaryTime >= 13 && militaryTime <= 17)
            {
                Console.WriteLine($"Good afternoon {name}, Please choose from the menu below..");
            }
            else
            {
                Console.WriteLine($"Good evening {name}, Please choose from the menu below: ");
            }

        }
       
        internal static (int number1, int number2) EasyGame()
        {
            Random random = new Random();
            int number1 = random.Next(1, 11);
            int number2 = random.Next(1, 11);

            return (number1, number2);
        }

        internal static (int number1, int number2) MediumGame()
        {
            Random random = new Random();
            int number1 = random.Next(1, 51);
            int number2 = random.Next(1, 51);

            return (number1, number2);
        }



    }
}
