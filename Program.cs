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
                )
           };

           Quiz quiz= new Quiz(question);
           quiz.DisplayQuestion(question[0]);
           Console.ReadLine();
        }
    }
}