

namespace Math_Game
{
    internal class UserInterFace
    {
        internal static void divider()
        {
            Console.WriteLine("------------------------------------------------------------");
        }
        internal static void Header()
        {
            Console.WriteLine(@"
                                   _   _     
                                  | | | |    
                   _ __ ___   __ _| |_| |__  
                  | '_ ` _ \ / _` | __| '_ \ 
                  | | | | | | (_| | |_| | | |
  WELCOME TO THE  |_| |_| |_|\__,_|\__|_| |_| GAME
 ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************************************************************");
            Console.ResetColor();
        }

        internal static void Menu()
        {
            Console.WriteLine(@"
'V' View Game History.
'A' Add.
'S' Subtract.
'M' Multiplay.
'D' Divide.
'R' Random.
'E' Exit. ");
        }

       

        internal static void Game()
        {
            Console.Write("Your choice: ");
            string userChoice = Console.ReadLine().Trim().ToUpper();

            bool isUserChoiceValid = false;

            while (!isUserChoiceValid)
            {
                switch (userChoice)
                {
                    case "V":
                        Games.ViewGameHistory();
                        break;
                    case "A":
                        Games.Add();
                        isUserChoiceValid = true;
                        break;
                    case "S":
                        Games.Subtract();
                        isUserChoiceValid = true;
                        break;
                    case "M":
                        Games.Multiply();
                        isUserChoiceValid = true;
                        break;
                    case "D":
                        Games.Divide();
                        isUserChoiceValid = true;
                        break;
                    case "R":
                        Games.Random();
                        isUserChoiceValid = true;
                        break;
                    case "E":
                        Console.WriteLine("GOOD BYE..");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input.. Try again.");
                        Console.Write("Your choice: ");
                        userChoice = Console.ReadLine().Trim().ToUpper();
                        break;

                }              
            }
        }

    }
}
