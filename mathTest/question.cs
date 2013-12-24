using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mathTest
{
    public class question
    {
        public string question_text;
        int answer;
        public string status { get; set; }
        
        public question()
        {
            int multiplierA = 0;
            int multiplierB = 0;
            Random r = new Random();
            multiplierA = r.Next(11);
            multiplierB = r.Next(11);
            question_text = multiplierA.ToString() + " * " + multiplierB.ToString();
            answer = multiplierA * multiplierB;
            status = "new";

            for (int i = 0; i < (9999999); i++) ;//delay for random number generation
        }

        public bool result(int userAnswer)
        {
            if (userAnswer == answer)
            {
                status = "correct";
                return true;
            }
            status = "incorrect";
            return false;
        }

        
    }
}
