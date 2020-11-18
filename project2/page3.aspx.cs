using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2
{
    public partial class page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["FirstName"].ToString();
            TextBox2.Text = ViewState["LasttName"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["FirstName"]= TextBox1.Text;
            ViewState["LasttName"] = TextBox2.Text;
            TextBox1.Text = TextBox2.Text="";
        }
        //seesion
        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["UserName"] = TextBox3.Text;

            Response.Redirect("page1.aspx");
        }

    }
}