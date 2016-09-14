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
    public partial class StuUser : System.Web.UI.MasterPage
    {
        public void StuNameQuery()
        {
            string sql = "select S_Name from T_Student where S_Id = " + "'" + Session["S_Id"] + "'";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSName;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSName = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSName;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_StuName.Text = ds.Tables[0].Rows[0]["S_Name"].ToString();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StuNameQuery();
            }
        }
    }
}