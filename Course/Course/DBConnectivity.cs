using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;// connectivity for access database

namespace Course
{
    public class DBConnectivity
    {
        private static OleDbConnection GetConnection()
        {
            string connString;
            connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Application Development\Course\Database5.accdb"; //  connection location for database file
            return new OleDbConnection(connString);
        }

        // Method that returns a list of Question objects with the details from the DB
        public static List<Questions> LoadQuestions()
        {
            List<Questions> quest = new List<Questions>();// create new lists quest
            OleDbConnection myConnection = GetConnection();//connection for access database

            string myQuery = "SELECT TOP 10 * FROM testQuestions"; // in string myquery it has the SQL Statement which return top 10 from database
            

            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);
                              
            try// try and catch for event handling
            {
                
                myConnection.Open();//open connection
                OleDbDataReader myReader = myCommand.ExecuteReader(); // read from access 
                while (myReader.Read()) 
                {

                                        //convert question id to int and question to string and store in class Question                                    
                   Questions A = new Questions(int.Parse(myReader["questionid"].ToString()), myReader["question"].ToString());
                   quest.Add(A); //list add class                 
                                  

                }

                return quest;
           
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }


        //Method that returns a list of answers based from question

        public static List<String> LoadAnswers2(int aId)
        {
            List<String> ans = new List<String>();//create a new list string
            OleDbConnection myConnection = GetConnection();
            string myQuery = "SELECT  answer, testAnswers.questionId FROM testAnswers WHERE testAnswers.questionId = " + aId;//SQL Statement which get questionid from test answers table and get question id from int aId.
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read()) //while reading it add answer to string in list
                {
                    ans.Add(myReader["answer"].ToString());
                }
                return ans;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);// handle exception occurs
                return null;
            }
            finally
            {
                myConnection.Close();// important to close connect of database
            }
        }

        public static List<String> LoadCorrect(int aId)//load correct answer from question
        {
            List<String> correct = new List<String>();// create new string list 
            OleDbConnection myConnection = GetConnection();// get connection
            string myQuery = "SELECT correctanswer FROM testQuestions WHERE testQuestions.questionid =" + aId;// SQL Statement for correctanswer from testQuestion table where question id get from int aId.
            OleDbCommand myCommand = new OleDbCommand(myQuery, myConnection);

            try
            {
                myConnection.Open();
                OleDbDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read()) //while reading add correctanswer to correct list in string.
                {
                    correct.Add(myReader["correctanswer"].ToString());
                }
                return correct;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in DBHandler", ex);
                return null;
            }
            finally
            {
                myConnection.Close();
            }
        }

   

     
        
 
    }
}