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
            Console.WriteLine(question.QuestionText);
        }
    }
}