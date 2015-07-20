using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace Course
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;//the text from textbox1 will store to string varialbe a
            string b = TextBox2.Text;//this will store to variable b
            DateTime c = DateTime.Now.Date;//now date will store in c 
            
            

            if (TextBox1.Text != "" & TextBox2.Text != "")//if textbox1 and textbox2 is not null then it will add the items in session
            {
                Session["UserName"] = TextBox1.Text;//textbox1 text will store into username
                Session["Nationality"] = TextBox2.Text;//textbox2 text will store into nationality

            }
                      
            Response.Redirect("Test.aspx");// redirect to test page


           
        }

    }
}