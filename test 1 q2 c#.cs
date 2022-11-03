// this is darshit's code ....

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Web;  
using System.Web.UI;  
using System.Web.UI.WebControls;  
namespace WebFormsControlls  
{  
    public partial class WebControls : System.Web.UI.Page  
    {  
        protected System.Web.UI.HtmlControls.HtmlInputFile File1;  
        protected System.Web.UI.HtmlControls.HtmlInputButton Submit1;  
        protected void Page_Load(object sender, EventArgs e)  
        {  
        }  
        protected void click1_Click(object sender, EventArgs e)  
        {  
            alert.Text      = "Hyy " + studentname.Text + " !! ";  
            alert.Text      = alert.Text + " <br/> perfect you did it (you are now registred).";  
            ShowstudentName.Text = studentname.Text;  
            ShowstudentEmail.Text    = studentEmailID.Text;  
            if (RadioButton1.Checked)  
            {  
                ShowGender.Text = RadioButton1.Text;  
            }  
            else ShowGender.Text = RadioButton2.Text;  
        var courses = "";  
            if (CheckBox1.Checked)  
            {  
                courses = CheckBox1.Text + " ";  
            }  
            if (CheckBox2.Checked)  
            {  
                courses += CheckBox2.Text + " ";  
            }     
            if (CheckBox3.Checked)  
            {  
                courses += CheckBox3.Text;  
            }  
            ShowCourses.Text = courses;  
            ShowstudentNameLabel.Text = "student Name";  
            ShowstudentEmailIDLabel.Text = "studentEmail ID";  
            ShowGenderLabel.Text = "Gender";  
            ShowCourseLabel.Text = "Courses";  
            studentname.Text = "";  
            studentEmailID.Text = "";  
            RadioButton1.Checked = false;  
            RadioButton2.Checked = false;  
            CheckBox1.Checked = false;  
            CheckBox2.Checked = false;  
            CheckBox3.Checked = false;  
        }  
    }  
}  


// end of this code........