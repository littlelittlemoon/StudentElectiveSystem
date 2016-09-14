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
    public partial class DeleteStu : System.Web.UI.Page
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
            Lab_Id.Text = ds.Tables[0].Rows[0]["学号"].ToString();
            Lab_SName.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
            Lab_SAc.Text = ds.Tables[0].Rows[0]["学院"].ToString();
            Lab_Sp.Text = ds.Tables[0].Rows[0]["专业"].ToString();
            Lab_Cl.Text = ds.Tables[0].Rows[0]["班级"].ToString();

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
            if(!IsPostBack)
            {
                SelectStuInfo();
            }
        }

        protected void btn_DelStudent_Click(object sender, EventArgs e)
        {
            model.S_Id = Request.QueryString["S_Id"];

            bool bIsOk = bll.StudentDelete(model);
            if (bIsOk == true)
            {
                Response.Redirect("StudentList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }
    }
}