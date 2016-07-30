using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToolBoxExamples1
{
    public partial class BulletListExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BulletedList1.Items.Add("raju");
            BulletedList1.Items.Add("rani");
            BulletedList1.Items.Add("kumar");
            BulletedList1.Items.Add("prakash");
        }
    }
}