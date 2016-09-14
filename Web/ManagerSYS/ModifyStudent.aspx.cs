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
    
    public partial class ModefyStudent : System.Web.UI.Page
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
            DDL_CAcademy.DataSource = ds;
            DDL_CAcademy.DataTextField = "Ac_Name";
            DDL_CAcademy.DataValueField = "Ac_Id";
            DDL_CAcademy.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SpecialtyQuery2()
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
            DDL_CSpecialty.DataSource = ds;
            DDL_CSpecialty.DataTextField = "Sp_Name";
            DDL_CSpecialty.DataValueField = "Sp_Id";
            DDL_CSpecialty.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
            ClassQuery(null);
        }
        public void SpecialtyQuery(string sql)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            if (sql == null)
            {
                string str = DDL_CAcademy.SelectedValue;
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
            DDL_CSpecialty.DataSource = ds;
            DDL_CSpecialty.DataTextField = "Sp_Name";
            DDL_CSpecialty.DataValueField = "Sp_Id";
            DDL_CSpecialty.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
            ClassQuery(null);
        }

        public void ClassQuery2()
        {
            string str = DDL_CSpecialty.SelectedValue;
            string sql = "select * from T_Class where Sp_Id = " + "'" + str + "'";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selCL;
            selCL = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selCL;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DDL_CClass.DataSource = ds;
            DDL_CClass.DataTextField = "Cl_Name";
            DDL_CClass.DataValueField = "Cl_Id";
            DDL_CClass.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void ClassQuery(string sql)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selCL;

            if (sql == null)
            {
                string str = DDL_CSpecialty.SelectedValue;
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
            DDL_CClass.DataSource = ds;
            DDL_CClass.DataTextField = "Cl_Name";
            DDL_CClass.DataValueField = "Cl_Id";
            DDL_CClass.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SelectStuInfo()
        {
            string sql;
            string SId = Request.QueryString["S_Id"];
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selStu;
            sql = "select * from V_MStudent where 学号=" + "'" + SId + "'";
            selStu = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selStu;
            DataSet ds = new DataSet();
            da.Fill(ds);

            txt_CSName.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
            txt_CSUName.Text = ds.Tables[0].Rows[0]["用户名"].ToString();
            txt_CSUPass.Text = ds.Tables[0].Rows[0]["密码"].ToString();
            txt_CSAPass.Text = ds.Tables[0].Rows[0]["密码"].ToString();
            DDL_CSSex.SelectedIndex = DDL_CSSex.Items.IndexOf(DDL_CSSex.Items.FindByText(ds.Tables[0].Rows[0]["性别"].ToString()));

            txt_CSAge.Text = ds.Tables[0].Rows[0]["年龄"].ToString();
            DDL_CAcademy.SelectedIndex = DDL_CAcademy.Items.IndexOf(DDL_CAcademy.Items.FindByText(ds.Tables[0].Rows[0]["学院"].ToString()));
            DDL_CSpecialty.SelectedIndex = DDL_CSpecialty.Items.IndexOf(DDL_CSpecialty.Items.FindByText(ds.Tables[0].Rows[0]["专业"].ToString()));
            DDL_CClass.SelectedIndex = DDL_CClass.Items.IndexOf(DDL_CClass.Items.FindByText(ds.Tables[0].Rows[0]["班级"].ToString()));

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
                SpecialtyQuery2();
                ClassQuery2();
                SelectStuInfo();
            }
        }

        protected void DDL_CAcademy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DDL_CAcademy.SelectedValue;
            string sql = "select * from T_Specialty where Ac_Id=" + "'" + str + "'";
            SpecialtyQuery(sql);

        }

        protected void DDL_CSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DDL_CSpecialty.SelectedValue;
            string sql = "select * from T_Class where Sp_Id=" + "'" + str + "'";
            ClassQuery(sql);
        }

        protected void btn_Modify_Student_Click(object sender, EventArgs e)
        {
            model.S_Id = Request.QueryString["S_Id"];
            model.S_Name = txt_CSName.Text.Trim();
            model.S_UserName = txt_CSUName.Text.Trim();
            model.S_Pass = txt_CSUPass.Text.Trim();
            model.S_Sex = DDL_CSSex.Text.Trim();
            model.S_Age = int.Parse(txt_CSAge.Text.Trim());
            model.Sp_Id = DDL_CSpecialty.SelectedValue;
            model.Cl_Id = DDL_CClass.SelectedValue;
            model.R_Id = "";

            bool bIsOk = bll.StudentModify(model);
            if (bIsOk == true)
            {
                Response.Redirect("StudentList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }

        protected void DDL_CClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txt_CSAge_TextChanged(object sender, EventArgs e)
        {

        }

    }
}