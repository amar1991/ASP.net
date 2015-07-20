using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course
{
    public class Points //create a class points
    {
        int point;//variable point into integer
        string correctanswer;// variable correct answer to string
        int marks;
        
        
               
          public int Point // instanciate point by get and set
        {
            get { return point; }
            set { point = value; }
        }


        public string Correctanswer
        {
            get { return correctanswer; }
            set { correctanswer = value; }
        }

        public int Mark
        {
            get { return marks; }
            set { marks = value; }
        }
                               
        public Points (int p, string can, int m)//constructor with 3 parameter
        {
            point = p;
            correctanswer = can;
            marks = m;
        }

                   

    }

    }