namespace Math_Game
{
    internal class Games
    {
        internal static void Add()
        {
            int NumberOfquestions = UserInterFace.GameQuestions();

            int questions = 0;
            int correctAnswers = 0;
            int wrongAnswers = 0;

            UserInterFace.GameLevel();

            while(questions < NumberOfquestions)
            {
                (int number1, int number2) randoms = Helpers.GetRandomNumbers();

                Console.Write($"What is {randoms.number1} + {randoms.number2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randoms.number1 + randoms.number2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That's Correct.");
                    Console.ResetColor();
                    correctAnswers++;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That's Wrong.");
                    Console.ResetColor();
                    wrongAnswers++;
                }

                questions++;
            }
        }

        internal static void Subtract()
        {
            Console.WriteLine("This is the Subtract Game.");
        }

        internal static void Multiply()
        {
            Console.WriteLine("This is the Multiply Game.");
        }

        internal static void Divide()
        {
            Console.WriteLine("This is the Divide Game.");
        }

        internal static void Random()
        {
            Console.WriteLine("This is the Random Game.");
        }

        internal static void ViewGameHistory()
        {
            Console.WriteLine("Game History.");
        }


    }
}
