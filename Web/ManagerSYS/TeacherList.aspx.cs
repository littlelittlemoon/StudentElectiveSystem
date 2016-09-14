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
    public partial class TeacherList : System.Web.UI.Page
    {
        public void DocumentQuery()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            string sql = "select * from T_Department";
            SqlCommand selDe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = selDe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_SelDc.DataSource = ds;
            DDL_SelDc.DataTextField = "D_Name";
            DDL_SelDc.DataValueField = "D_Id";
            DDL_SelDc.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void GV_DataQuery()
        {
            string sql = null;
            string str1 = DDL_SelDc.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MTeacherCourse where 部门 = " + "'" + str1 + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_StuList.DataSource = ds;
            GV_StuList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();

        }

        public void GV_DataQuery2()
        {
            string sql = null;
            string str1 = DDL_SelDc.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MTeacherCourse";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_StuList.DataSource = ds;
            GV_StuList.DataBind();
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
            if (!IsPostBack)
            {
                DocumentQuery();
                GV_DataQuery2();
            }
        }

        protected void DDL_SelDc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GV_DataQuery();
        }

        protected void btn_SearchTeacher_Click(object sender, EventArgs e)
        {
            string sql = null;
            string str = txt_SearchBox.Text.Trim();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MTeacherCourse where 姓名 = " + "'" + str + "'" +"or 教师编号 = " + "'" + str + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_StuList.DataSource = ds;
            GV_StuList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
    }
}