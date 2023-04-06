using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspWebApi
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        int Count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                tb_Count.Text = "0";
            }
        }

        protected void btn_Click_Click(object sender, EventArgs e)
        {
            if (ViewState["Click"] != null)
            {
                Count = (int)ViewState["Click"] + 1;
            }
            tb_Count.Text = Count.ToString();
            ViewState["Click"] = Count;
        }
    }
}