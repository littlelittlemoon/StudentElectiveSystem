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
    public partial class StudentList : System.Web.UI.Page
    {
        public void AcademyQuery()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            string sql = "select * from T_Academy";
            SqlCommand selAc = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selAc;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_SelAc.DataSource = ds;
            DDL_SelAc.DataTextField = "Ac_Name";
            DDL_SelAc.DataValueField = "Ac_Id";
            DDL_SelAc.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
            GV_DataQuery();
        }
        public void SpecialtyQuery(string sql)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            if (sql == null)
            {
                string str = DDL_SelAc.SelectedValue;
                sql = "select * from T_Specialty where Ac_Id=" + "'" + str + "'";
                selSpe = new SqlCommand(sql, conn);
            }
            else
            {
                selSpe = new SqlCommand(sql, conn);
            }
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
            ClassQuery(null);
            GV_DataQuery();
        }

        public void ClassQuery(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selCL;
            if (sql == null)
            { 
                string str = DDL_SelSp.SelectedValue;
                sql = "select * from T_Class where Sp_Id=" + "'" + str + "'";
                selCL = new SqlCommand(sql, conn);
            }
            else
            {
                selCL = new SqlCommand(sql, conn);
            }
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selCL;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DDL_SelCl.DataSource = ds;
            DDL_SelCl.DataTextField = "Cl_Name";
            DDL_SelCl.DataValueField = "Cl_Id";
            DDL_SelCl.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
            GV_DataQuery();
        }

        public void GV_DataQuery2() 
        {
            string sql = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MStudent";
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

        public void GV_DataQuery()
        {
            string sql = null;
            string str1 = DDL_SelAc.SelectedItem.Text;
            string str2 = DDL_SelSp.SelectedItem.Text;
            string str3 = DDL_SelCl.SelectedItem.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MStudent where 学院 = " + "'" + str1 + "'" + "and 专业=" + "'" + str2 + "'" + "and 专业=" + "'" + str2 + "'" + "and 班级=" + "'" + str3 + "'";
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
                AcademyQuery();
                SpecialtyQuery(null);
                ClassQuery(null);
                GV_DataQuery2();
            }
        }

        protected void DDL_SelAc_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string str = DDL_SelAc.SelectedValue;
            string sql = "select * from T_Specialty where Ac_Id=" + "'" + str + "'";
            SpecialtyQuery(sql);
        }

        protected void DDL_SelSp_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string str = DDL_SelSp.SelectedValue;
            string sql = "select * from T_Class where Sp_Id=" + "'" + str + "'";
            ClassQuery(sql);
        }

        protected void DDL_SelCl_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GV_DataQuery();
        }

        protected void GV_StuList_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        protected void btn_SearchStu_Click(object sender, EventArgs e)
        {
            string sql = null;
            string str = txt_SearchStu.Text.Trim();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_MStudent where 姓名 = " + "'" + str + "'" + "or 学号 = " + "'" + str + "'";
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