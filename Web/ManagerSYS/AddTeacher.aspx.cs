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
    public partial class AddTeacher : System.Web.UI.Page
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
        public void DocumentQuery()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            string sql = "select * from T_Department";
            SqlCommand selDe= new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = selDe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_Document.DataSource = ds;
            DDL_Document.DataTextField = "D_Name";
            DDL_Document.DataValueField = "D_Id";
            DDL_Document.DataBind();
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
                DocumentQuery();
            }
        }

        protected void DDL_Document_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_AddTeacher_Click(object sender, EventArgs e)
        {
            model.T_Id = "";
            model.T_Name = txt_TName.Text.Trim();
            model.T_UseName = txt_TUName.Text.Trim();
            model.T_Pass = txt_TUPass.Text.Trim();
            model.T_Sex = DDL_TSex.Text.Trim();
            model.T_Age = int.Parse(txt_TAge.Text.Trim());
            model.D_Id = DDL_Document.SelectedValue;
            model.R_Id = "";

            bool bIsOk = bll.TeacherInsert(model);
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