using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project2
{
    public partial class page4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie Cookie = new HttpCookie("MyCart", TextBox1.Text);
            Cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(Cookie);
            Response.Redirect("~/cookise2.aspx");

        }
    }
}