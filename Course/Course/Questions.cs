using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course
{
    public class Questions // class question
    {
        int questionId;// variable questionid to int data type
        string question;
        int rand;
        
        
               
          public int QuestionId
        {
            get { return questionId; }
            set { questionId = value; }
        }


        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public int Rand
        {
            get { return rand; }
            set { rand = value; }
        }
                               
        public Questions(int id, string an) // constructor with 3 parameter
        {
            questionId = id;
            question = an;
            
        }

                   

    }
                    }


    
  