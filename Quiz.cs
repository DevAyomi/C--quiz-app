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
            int totalQuestionCount = 0;

            foreach (Question question in questions)
            {
                totalQuestionCount++;
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
            System.Console.WriteLine($"Your total score is: {correctAnswerCount} out of {totalQuestionCount}");
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