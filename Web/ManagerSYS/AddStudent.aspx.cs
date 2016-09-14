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
    public partial class AddStudent : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 学生模型对象
        /// </summary>
        Model.T_Student model;
        /// <summary>
        /// 学生表业务逻辑对象
        /// </summary>
        BLL.T_Student bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.T_Student();
            bll = new BLL.T_Student("ConnToCourseSlectedSystem");
        }
        #endregion
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
            DDL_Academy.DataSource= ds;
            DDL_Academy.DataTextField = "Ac_Name";
            DDL_Academy.DataValueField = "Ac_Id";
            DDL_Academy.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
        public void SpecialtyQuery(string sql)
        {   
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            if (sql == null)
            {
                string str = DDL_Academy.SelectedValue;
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
            DDL_Specialty.DataSource = ds;
            DDL_Specialty.DataTextField = "Sp_Name";
            DDL_Specialty.DataValueField = "Sp_Id";
            DDL_Specialty.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
            ClassQuery(null);
          }

        public void ClassQuery(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selCL;
            
            if (sql == null)
            {
                string str = DDL_Specialty.SelectedValue;
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
            DDL_Class.DataSource = ds;
            DDL_Class.DataTextField = "Cl_Name";
            DDL_Class.DataValueField = "Cl_Id";
            DDL_Class.DataBind();
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
            InitGlobal();
            if (!IsPostBack)
            {
                AcademyQuery();
                SpecialtyQuery(null);
                ClassQuery(null);
            }
        }

        protected void btn_AddStudent_Click(object sender, EventArgs e)
        {
            model.S_Id = "";
            model.S_Name = txt_SName.Text.Trim();
            model.S_UserName = txt_SUName.Text.Trim();
            model.S_Pass = txt_SUPass.Text.Trim();
            model.S_Sex = DDL_SSex.Text.Trim();
            model.S_Age = int.Parse(txt_SAge.Text.Trim());
            model.Sp_Id = DDL_Specialty.SelectedValue;
            model.Cl_Id = DDL_Class.SelectedValue;
            model.R_Id = "";

            bool bIsOk = bll.StudentInsert(model);
            if (bIsOk == true)
            {
                //Response.Write(result);
                Response.Redirect("StudentList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }

        protected void DDL_Academy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DDL_Academy.SelectedValue;
            string sql = "select * from T_Specialty where Ac_Id="+"'"+str+"'";
            SpecialtyQuery(sql);
        }

        protected void DDL_Specialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DDL_Specialty.SelectedValue;
            string sql = "select * from T_Class where Sp_Id=" + "'" + str + "'";
            ClassQuery(sql);
        }

        protected void DDL_Class_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}