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
    public partial class StudentWebIndex : System.Web.UI.Page
    {
        public string SelSId()
        {
            string sql = null;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selSId;
            sql = sql = "select S_Id from T_Student where S_UserName = " + "'" + Session["U_Name"] + "'"; ;
            selSId = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSId;
            DataSet ds = new DataSet();
            da.Fill(ds);
            string SId = ds.Tables[0].Rows[0]["S_Id"].ToString();
            return SId;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["U_Name"] == null)
            {
                Response.Redirect("../V_UserLogin.aspx");
            }
            Session["S_Id"] = SelSId();
        }
    }
}