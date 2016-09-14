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
    public partial class TeacherWebIndex : System.Web.UI.Page
    {
        public string SelTId()
        {
            string sql = null;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selTId;
            sql = sql = "select T_Id from T_Teacher where T_UseName = " + "'" + Session["U_Name"] + "'"; 
            selTId = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selTId;
            DataSet ds = new DataSet();
            da.Fill(ds);
            string TId = ds.Tables[0].Rows[0]["T_Id"].ToString();
            return TId;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["U_Name"] == null)
            {
                Response.Redirect("../V_UserLogin.aspx");
            }
            Session["T_Id"] = SelTId();
        }
    }
}