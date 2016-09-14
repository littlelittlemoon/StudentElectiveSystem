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
    public partial class ModifyCourse : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 课程模型对象
        /// </summary>
        Model.T_Course model;
        /// <summary>
        /// 课程表业务逻辑对象
        /// </summary>
        BLL.T_Course bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.T_Course();
            bll = new BLL.T_Course("ConnToCourseSlectedSystem");
        }
        #endregion
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

            DDL_CourseSp.DataSource = ds;
            DDL_CourseSp.DataTextField = "Sp_Name";
            DDL_CourseSp.DataValueField = "Sp_Id";
            DDL_CourseSp.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void TeacherQuery()
        {
            string sql = "select T_Id, T_Name from T_Teacher where R_Id = 'R102'";
            SqlConnection conn = new SqlConnection();
            SqlCommand selTea;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selTea = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selTea;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_CTeacher.DataSource = ds;
            DDL_CTeacher.DataTextField = "T_Name";
            DDL_CTeacher.DataValueField = "T_Id";
            DDL_CTeacher.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SelCourseInfo()
        {
            string CId = Request.QueryString["C_Id"];
            string sql = "select * from V_Course where 课程代码 = " + "'" + CId + "'";
            SqlConnection conn = new SqlConnection();
            SqlCommand selCour;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selCour = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selCour;
            DataSet ds = new DataSet();
            da.Fill(ds);

            txt_CName.Text = ds.Tables[0].Rows[0]["课程名称"].ToString();
            txt_StartTime.Text = ds.Tables[0].Rows[0]["开课时间"].ToString();
            DDL_CourseSp.SelectedIndex = DDL_CourseSp.Items.IndexOf(DDL_CourseSp.Items.FindByText(ds.Tables[0].Rows[0]["开设专业"].ToString()));
            DDL_Credit.SelectedIndex = DDL_Credit.Items.IndexOf(DDL_Credit.Items.FindByText(ds.Tables[0].Rows[0]["学分"].ToString()));
            DDL_CTeacher.SelectedIndex = DDL_CTeacher.Items.IndexOf(DDL_CTeacher.Items.FindByText(ds.Tables[0].Rows[0]["授课教师"].ToString()));
            DDL_Period.SelectedIndex = DDL_Period.Items.IndexOf(DDL_Period.Items.FindByText(ds.Tables[0].Rows[0]["学时"].ToString()));
            DDL_Species.SelectedIndex = DDL_Species.Items.IndexOf(DDL_Species.Items.FindByText(ds.Tables[0].Rows[0]["课程性质"].ToString()));
            txt_CLocation.Text = ds.Tables[0].Rows[0]["上课地点"].ToString();

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
                SpecialtyQuery();
                TeacherQuery();
                SelCourseInfo();
            }
            
        }

        protected void btn_ModifyCourse_Click(object sender, EventArgs e)
        {
            model.C_Id = Request.QueryString["C_Id"];
            model.C_Name = txt_CName.Text.Trim();
            model.C_Species = DDL_Species.Text.Trim();
            model.C_Credit = double.Parse(DDL_Credit.SelectedValue);
            model.Sp_Id = DDL_CourseSp.SelectedValue;
            model.C_Period = int.Parse(DDL_Period.SelectedValue);
            model.C_StartTime = DateTime.Parse(txt_StartTime.Text);
            model.C_Location = txt_CLocation.Text.Trim();
            model.T_Id = DDL_CTeacher.SelectedValue;

            bool bIsOk = bll.CourseModify(model);
            if (bIsOk == true)
            {
                Response.Redirect("CourseList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }
    }
}