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
    public partial class V_UserLogin : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 学生模型对象
        /// </summary>
        Model.V_UserLogin model;
        /// <summary>
        /// 学生表业务逻辑对象
        /// </summary>
        BLL.V_UserLogin bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.V_UserLogin();
            bll = new BLL.V_UserLogin("ConnToCourseSlectedSystem");
        }

        #endregion
        public void URoleQuery()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            string sql = "select R_Name from T_Role";
            SqlCommand selRl = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = selRl;
            DataSet ds = new DataSet();
            da.Fill(ds);
            DDL_URole.DataSource = ds;
            DDL_URole.DataTextField = "R_Name";
            DDL_URole.DataValueField = "R_Name";
            DDL_URole.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGlobal();
            if (!IsPostBack) { 
                URoleQuery();
            }
            
        }

        protected void DDL_URole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DDL_URole.SelectedValue;
        }

        protected void btn_ULogin_Click(object sender, EventArgs e)
        {
            model.U_Name = txt_UName.Text.Trim();
            model.U_Pass = txt_UPass.Text.Trim();
            model.U_Role = DDL_URole.SelectedValue;

            bool bIsOk = bll.UserLogin(model);
            if (bIsOk == true)
            {
                Session["U_Name"] = model.U_Name;
                if (model.U_Role == "管理员")
                {
                    Response.Redirect("ManagerSYS/ManagerWebIndex.aspx");
                }
                else if (model.U_Role == "教师")
                {
                    Response.Redirect("TeacherSYS/TeacherWebIndex.aspx");
                }
                else 
                {
                    Response.Redirect("StudentSYS/StudentWebIndex.aspx");
                }
                
            }
            else
            {
                Response.Redirect("About.aspx");
            }
        }
    }
}