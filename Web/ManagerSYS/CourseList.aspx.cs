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
    public partial class CourseList : System.Web.UI.Page
    {
        public void SpecialtyQuery()
        {
            string sql = "select * from T_Specialty";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSpe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSpe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_SelSp.DataSource = ds;
            DDL_SelSp.DataTextField = "Sp_Name";
            DDL_SelSp.DataValueField = "Sp_Id";
            DDL_SelSp.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SpecQuery()
        {
            string sql = "select DISTINCT C_Species from T_Course";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSpe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSpe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_SelSpec.DataSource = ds;
            DDL_SelSpec.DataTextField = "C_Species";
            DDL_SelSpec.DataValueField = "C_Species";
            DDL_SelSpec.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }


        public void GV_DataQuery2()
        {
            string sql = null;

            string str1 = DDL_SelSp.SelectedItem.Text;
            string str2 = DDL_SelSpec.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course where 开设专业 = " + "'" + str1 + "'" + "and 课程性质=" + "'" + str2 + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();

        }

        public void GV_DataQuery()
        {
            string sql = null;
            
            string str1 = DDL_SelSp.SelectedItem.Text;
            string str2 = DDL_SelSpec.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
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
            if(!IsPostBack)
            {
                SpecialtyQuery();
                SpecQuery();
                GV_DataQuery();
            }
           
        }

        protected void DDL_SelSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GV_DataQuery2();
        }

        protected void DDL_SelSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            GV_DataQuery2();
        }



        protected void btn_SearchCourse_Click(object sender, EventArgs e)
        {
            string sql = null;
            string str = txt_SearchCourse.Text.Trim();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course where 课程代码 = " + "'" + str + "'" + "or 课程名称 = " + "'" + str + "'" + "or 授课教师 = " + "'" + str + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
    }
}