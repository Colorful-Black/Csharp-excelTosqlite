using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;

namespace WebApplication2
{
    public partial class SqlLiteTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Start_Click(object sender, EventArgs e)
        {
            //做文件检测，如果有不新建数据库文件
            //if()
        }
        
        protected void ShowMSTable()
        {
            try
            {
                DataTable dt;
                string filename = @"E:\1.xls";
                using (NPOIHelper excelHelper = new NPOIHelper())
                {
                    dt = excelHelper.ExcelToDataTable("MySheet", true, filename);

                }
                //filename = @"E:\2.xls";
                //using (NPOIHelper excelHelper = new NPOIHelper())
                //{
                //    int count = excelHelper.DataTableToExcel(dt, "苏上话", true, filename);
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}