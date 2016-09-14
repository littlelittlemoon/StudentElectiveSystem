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
    public partial class DeleteCourse : System.Web.UI.Page
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
        public void SelectCourseInfo()
        {
            string sql;
            string CId = Request.QueryString["C_Id"];
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selStu;
            sql = "select * from V_Course where 课程代码 = " + "'" + CId + "'";
            selStu = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selStu;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_Id.Text = ds.Tables[0].Rows[0]["课程代码"].ToString();
            Lab_CName.Text = ds.Tables[0].Rows[0]["课程名称"].ToString();
            Lab_CSpeci.Text = ds.Tables[0].Rows[0]["课程性质"].ToString();
            Lab_Sp.Text = ds.Tables[0].Rows[0]["开设专业"].ToString();
            Lab_Tea.Text = ds.Tables[0].Rows[0]["授课教师"].ToString();
            
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
                SelectCourseInfo();
            }
        }

        protected void btn_DelCourse_Click(object sender, EventArgs e)
        {
            model.C_Id = Request.QueryString["C_Id"];

            bool bIsOk = bll.CourseDelete(model);
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