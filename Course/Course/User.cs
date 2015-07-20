using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course
{
    public class User
    {
            int userId;
            string fullName;            
            DateTime attemptDate;



            public int UserId
            {
                get { return userId; }
                set { userId = value; }
            }


            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            
         

                    
        
          public DateTime AttemptDate
            {
                get { return attemptDate; }
                set { attemptDate = value; }
            }


          public User(int uid, string fn, DateTime at)
            {
              userId = uid;
              fullName = fn;           
              attemptDate = at;

            }


    }
}