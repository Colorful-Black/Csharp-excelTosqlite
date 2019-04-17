using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;

namespace WebApplication2
{
    public partial class SqlLiteTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Start_Click(object sender, EventArgs e)
        {
            Sqllite3Conn test = new Sqllite3Conn();
            LbResult.Text = "结果：" + test.sqlitetest();
        }
    }
}