
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
            int userAnswer = 0;

            string level = UserInterFace.GameLevel();

            while(questions < NumberOfquestions)
            {
                switch (level)
                {
                    case "Easy":
                        (int number1, int number2) randomsEasy = Helpers.EasyGame();

                        UserInterFace.AskQuestion(randomsEasy.number1, randomsEasy.number2);
                        userAnswer = Convert.ToInt32(Console.ReadLine());

                        if ((randomsEasy.number1 + randomsEasy.number2) == userAnswer)
                        {
                            UserInterFace.CorrectAnswer();
                            correctAnswers++;
                        } else
                        {
                            UserInterFace.WrongAnswer();
                            wrongAnswers++;
                        }
                        questions++;
                        break;
                    case "Medium":
                        (int number1, int number2) randomsMedium = Helpers.MediumGame();

                        UserInterFace.AskQuestion(randomsMedium.number1, randomsMedium.number2);
                        userAnswer = Convert.ToInt32(Console.ReadLine());

                        if ((randomsMedium.number1 + randomsMedium.number2) == userAnswer)
                        {
                            UserInterFace.CorrectAnswer();
                            correctAnswers++;
                        } else
                        {
                            UserInterFace.WrongAnswer();
                            wrongAnswers++;
                        }
                        questions++;
                        break;

                }
               
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
