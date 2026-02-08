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
                ),
                new Question(
                    "What is the value of Pi?",
                    new string[] {"2.13", "1.16", "3.14", "2.14"},
                    3
                ),
                new Question(
                    "Which of the following is a fruit?",
                    new string[] {"Tomato", "Potato", "Brocolli", "Carrot"},
                    0
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
