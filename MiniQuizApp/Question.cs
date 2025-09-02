using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniQuizApp
{
    class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswer { get; set; }

        public Question(string text, string[] options, int correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }

}
