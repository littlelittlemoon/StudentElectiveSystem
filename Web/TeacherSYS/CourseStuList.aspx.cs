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
    public partial class CourseStuList : System.Web.UI.Page
    {
        public void SelCourseSp()
        {
            string sql = null;
            string str = Request.QueryString["课程代码"];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selSp;
            sql = "select 授课专业 from V_TeachCourse where 课程代码 = " + "'" + str + "'";
            selSp = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSp;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_Sp.Text = ds.Tables[0].Rows[0]["授课专业"].ToString();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SelStuClass()
        {
            string sql = null;
            string str = Request.QueryString["课程代码"];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selSp;
            sql = "select 班级 from V_CourseSelectedStu where 课程代码 = " + "'" + str + "'";
            selSp = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSp;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DDL_StuClass.DataSource = ds;
            DDL_StuClass.DataTextField = "班级";
            DDL_StuClass.DataValueField = "班级";
            DDL_StuClass.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SelCourseName()
        {
            string sql = null;
            string str = Request.QueryString["课程代码"];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selSp;
            sql = "select 课程名称 from V_Course where 课程代码 = " + "'" + str + "'";
            selSp = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSp;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_CourseName.Text = ds.Tables[0].Rows[0]["课程名称"].ToString();

            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void GV_DataQuery()
        {
            string sql = null;
            string str = Request.QueryString["课程代码"];

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select 学号,姓名,性别,班级 from V_CourseSelectedStu where 课程代码 = " + "'" + str + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);

            GV_CourseStuList.DataSource = ds;
            GV_CourseStuList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void GV_DataQuery2()
        {
            string sql = null;
            string str = Request.QueryString["课程代码"];
            string str1 = DDL_StuClass.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select 学号,姓名,性别,班级 from V_CourseSelectedStu where 课程代码 = " + "'" + str + "' and 班级 =" + "'" + str1 + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);

            GV_CourseStuList.DataSource = ds;
            GV_CourseStuList.DataBind();
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
                GV_DataQuery();
                SelCourseSp();
                SelCourseName();
                SelStuClass();
            }
        }

        protected void DDL_StuClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            GV_DataQuery2();
        }
    }
}