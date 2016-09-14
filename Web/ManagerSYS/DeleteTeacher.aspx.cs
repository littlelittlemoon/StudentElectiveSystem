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
    public partial class DeleteTeacher : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 教师模型对象
        /// </summary>
        Model.T_Teacher model;
        /// <summary>
        /// 教师表业务逻辑对象
        /// </summary>
        BLL.T_Teacher bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.T_Teacher();
            bll = new BLL.T_Teacher("ConnToCourseSlectedSystem");
        }
        #endregion

        public void SelectTeaInfo()
        {
            string sql;
            string TId = Request.QueryString["T_Id"];
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selStu;
            sql = "select * from V_MTeacherCourse where 教师编号=" + "'" + TId + "'";
            selStu = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selStu;
            DataSet ds = new DataSet();
            da.Fill(ds);

            Lab_Id.Text = ds.Tables[0].Rows[0]["教师编号"].ToString();
            Lab_TName.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
            Lab_TDoc.Text = ds.Tables[0].Rows[0]["部门"].ToString();

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
                SelectTeaInfo();
            }
        }

        protected void btn_DelTeacher_Click(object sender, EventArgs e)
        {
            model.T_Id = Request.QueryString["T_Id"];

            bool bIsOk = bll.TeacherDelete(model);
            if (bIsOk == true)
            {
                Response.Redirect("TeacherList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }
    }
}