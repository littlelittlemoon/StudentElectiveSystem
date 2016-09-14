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
    public partial class master : System.Web.UI.MasterPage
    {
        public void TeaNameQuery()
        {
            string sql = "select T_Name from T_Teacher where T_Id = " + "'" + Session["T_Id"] + "'";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSName;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSName = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSName;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_TeaName.Text = ds.Tables[0].Rows[0]["T_Name"].ToString();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TeaNameQuery();
            }
        }
    }
}