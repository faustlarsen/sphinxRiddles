using System;

namespace Sphinx 
{
    public class Riddle
    {
        public string Question {get; set;}
        public string Answer {get; set;}
    
        public Riddle(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}