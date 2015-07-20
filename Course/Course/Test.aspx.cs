using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Course
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack) //check if the page is loaded first time
            {

                QuestionDrop.DataSource = DBConnectivity.LoadQuestions();
                QuestionDrop.DataTextField = "Question";
                QuestionDrop.DataValueField = "QuestionId"; //the name of the property that returns the ID
                QuestionDrop.DataBind();
                                
                if (Session["UserName"] != null & Session["Nationality"] != null) // the session checks for the username if it is written the label1 will display hello with username and nationality
                {//into string alongside the string 

                    Label1.Text = "Welcome    " + Session["UserName"].ToString() + "   from   " + Session["Nationality"].ToString();
                }



                else // redirect to register page.
                {
                    Response.Redirect("Register.aspx");
                }//it wont allow user to enter this page without username

            }
        }

        protected  void Button1_Click(object sender, EventArgs e)//button click event
        {
            int count = 0;//count default to 0
  
            List<String> b = DBConnectivity.LoadCorrect(int.Parse(QuestionDrop.SelectedValue));//list b which load database class with load correct method and convert the selected value from drop down list to integer.
  
            foreach (var details in b)// each variable in list
            {

                count++;             // add to count
            
                ListBox2.Items.Add(details);//added variable to listbox2 
               
              ListBox2.DataValueField = "correctanswer";//address the data value of correctanswer
              Label2.Text = count + "";//label2 display counts
              Session["Points"] = Label2.Text;//add counts from label2 to session point

                }           

           }
        
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();//listbox clear function if the item selection             
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                ListBox1.Items.Clear();// when button 2 pressed it clears items in listbox1
            //list a to access database class and load method which convert the dropdownlost of selected value to int
                List<String> s = DBConnectivity.LoadAnswers2(int.Parse(QuestionDrop.SelectedValue));
               
            //every variable in list 
                foreach (var detail in s)
                {//added into the listbox
                    ListBox1.Items.Add(detail);
                    ListBox1.DataValueField = "Answer";                                    
                    //addressing value to answer
                } 

        }

        protected void QuestionDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

             //image case statement
                switch (Int32.Parse(QuestionDrop.SelectedValue)) // convert selection value of drop down list to number and assign which case is selected.
                {
                    case 1:// if it is the first selection than it will load image url into image1 with image link
                        Image1.ImageUrl = "~/a.jpg";
                        break;
                    case 2:
                        Image1.ImageUrl = "~/b.jpg";
                        break;
                    case 3:
                        Image1.ImageUrl = "~/c.jpg";
                        break;
                    default:// default image if no case matched
                        Image1.ImageUrl = "~/d.jpg";
                        break;
                }
                                             

            }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox2.Items.Clear();//clear lists.
        }        

    }
}
