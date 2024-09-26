using System.Security.Principal;

namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Question[] question = new Question[]{
                new Question("What is the capital of Germany?",
                    new string[] { "Paris", "Berlin", "London","Madrid"},
                    1
                ),
                new Question("What is the capital of France?",
                    new string[] { "Paris", "Berlin", "London","Madrid"},
                    0
                ),
                new Question("What is the creator name?",
                    new string[] { "Gbolagade", "Winner", "Demi","Kayor"},
                    1
                )
           };

           Quiz quiz= new Quiz(question);
           quiz.StartQuiz();
           Console.ReadLine();
        }
    }
}