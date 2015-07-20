using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course
{
    public class Answers
    {
        int answersId;
        string answer;
        
        
               
          public int AnswerId
        {
            get { return answersId; }
            set { answersId = value; }
        }


        public string Answer
        {
            get { return answer; }
            set { answer = value; }
        }

    

                     
        public Answers(int aid, string ans)
        {
            answersId = aid;
            answer = ans;
          
           
        }
    

    }
}