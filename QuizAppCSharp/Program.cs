using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question(
                    "What is the capital of Illinois?", // QuestionText
                    new string[] {"Naperville", "Chicago", "Des Plaines", "Springfield"}, // Answers
                    3 // CorrectAnswerIndex
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);

            Console.ReadLine();
        }
    }
}
