using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Web
{
    public partial class HaveCourse : System.Web.UI.Page
    {
        public void GV_DataQuery()
        {
            string sql = null;
            string str = Session["S_Id"].ToString(); 

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_CourseSelected where 学号 = " + "'" + str + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_HaveCourseList.DataSource = ds;
            GV_HaveCourseList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["U_Name"] == null)
            {
                Response.Redirect("../V_UserLogin.aspx");
            }
            GV_DataQuery();
        }
    }
}