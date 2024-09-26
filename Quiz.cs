using System.Security.Principal;

namespace QuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void StartQuiz()
        {
            System.Console.WriteLine("Welcome to the QUIZ!");

            int questionNumber = 1;
            int correctAnswerCount = 0;

            foreach (Question question in questions)
            {
                System.Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if(question.isAnswerCorrect(userChoice))
                {
                    System.Console.WriteLine("Correct");
                    correctAnswerCount++;
                }else{
                    System.Console.WriteLine($"Wrong!, The correct annswer was:{question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            displayResult(correctAnswerCount);
        }

        private void displayResult(int _score)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("||===================================================================||");
            Console.WriteLine("||                             Results                               ||");
            Console.WriteLine("||===================================================================||");
            Console.ResetColor();

            double scorePercentage = ((double)_score / questions.Length) * 100;
            if(scorePercentage >= 80){
                Console.WriteLine("You got a perfect score! your score is: "+ _score + " and your percentage is: "+ scorePercentage + "%");
            }else if(scorePercentage >= 60){
                Console.WriteLine("You got a good score! your score is: "+ _score + " and your percentage is: "+ scorePercentage + "%");
            }else if(scorePercentage >= 40){
                Console.WriteLine("You got a okay score! your score is: "+ _score + " and your percentage is: "+ scorePercentage + "%");
            }else{
                Console.WriteLine("You got a poor score! your score is: "+ _score + " and your percentage is: "+ scorePercentage + "%");
            }
        }

        public void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("||===================================================================||");
            Console.WriteLine("||                             Questions                             ||");
            Console.WriteLine("||===================================================================||");
            Console.ResetColor();
            Console.WriteLine(question.QuestionText);
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" {i + 1}. ");
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
            }
        }

        private int GetUserChoice()
        {
            int choice = 0;
            Console.Write("Your answer is (number): ");
            string input = Console.ReadLine();
            while(!int.TryParse(input, out choice) || choice < 1 || choice > 4){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice, Please enter a number between 1 and 4:");
                Console.ResetColor();
                input = Console.ReadLine();
            }
            return choice-1;
        }
    }
}