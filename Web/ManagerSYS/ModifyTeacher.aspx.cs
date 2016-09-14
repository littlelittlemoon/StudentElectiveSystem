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
    public partial class ModifyTeacher : System.Web.UI.Page
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
            SqlCommand selDe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = selDe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_MDocument.DataSource = ds;
            DDL_MDocument.DataTextField = "D_Name";
            DDL_MDocument.DataValueField = "D_Id";
            DDL_MDocument.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

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


            txt_MTName.Text = ds.Tables[0].Rows[0]["姓名"].ToString();
            txt_MTUName.Text = ds.Tables[0].Rows[0]["用户名"].ToString();
            txt_MTUPass.Text = ds.Tables[0].Rows[0]["密码"].ToString();
            txt_MTAPass.Text = ds.Tables[0].Rows[0]["密码"].ToString();

            //DDL_MTSex.SelectedIndex = DDL_MTSex.Items.IndexOf(DDL_MTSex.Items.FindByText(ds.Tables[0].Rows[0]["性别"].ToString()));
            txt_MTAge.Text = ds.Tables[0].Rows[0]["年龄"].ToString();
            //DDL_MDocument.SelectedIndex = DDL_MDocument.Items.IndexOf(DDL_MDocument.Items.FindByText(ds.Tables[0].Rows[0]["部门"].ToString()));

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
                SelectTeaInfo();
            }
        }

        protected void btn_ModifyTeacher_Click(object sender, EventArgs e)
        {
            model.T_Id = Request.QueryString["T_Id"];
            model.T_Name = txt_MTName.Text.Trim();
            model.T_UseName = txt_MTUName.Text.Trim();
            model.T_Pass = txt_MTUPass.Text.Trim();
            model.T_Sex = DDL_MTSex.Text.Trim();
            model.T_Age = int.Parse(txt_MTAge.Text.Trim());
            model.D_Id = DDL_MDocument.SelectedValue;
            model.R_Id = "";

            bool bIsOk = bll.TeacherModify(model);
            if (bIsOk == true)
            {
                Response.Redirect("TeacherList.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");

            }
        }

        protected void DDL_MDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}