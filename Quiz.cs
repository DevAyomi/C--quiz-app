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
    }
}