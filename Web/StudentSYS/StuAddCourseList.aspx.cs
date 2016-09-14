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
    public partial class StuAddCourseList : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 课程模型对象
        /// </summary>
        Model.T_CurriculaVariable model;
        /// <summary>
        /// 课程表业务逻辑对象
        /// </summary>
        BLL.T_CurriculaVariable bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.T_CurriculaVariable();
            bll = new BLL.T_CurriculaVariable("ConnToCourseSlectedSystem");
        }
        #endregion

        public void SpecialtyQuery()
        {
            string sql = "select * from T_Specialty where Sp_Id in(select Sp_Id from T_Student where S_UserName = "+"'" +Session["U_Name"] + "'"+")";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSpe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSpe;
            DataSet ds = new DataSet();
            da.Fill(ds);
            Lab_Sp.Text = ds.Tables[0].Rows[0]["Sp_Name"].ToString();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void SpeciQuery()
        {
            string sql = "select DISTINCT C_Species from T_Course";
            SqlConnection conn = new SqlConnection();
            SqlCommand selSpe;
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            selSpe = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selSpe;
            DataSet ds = new DataSet();
            da.Fill(ds);

            DDL_SelSpec.DataSource = ds;
            DDL_SelSpec.DataTextField = "C_Species";
            DDL_SelSpec.DataValueField = "C_Species";
            DDL_SelSpec.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }


        public void GV_DataQuery()
        {
            string sql = null;
            string str = Lab_Sp.Text;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course where 开设专业 = " + "'" + str + "'";
            selDVData = new SqlCommand(sql, conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;

            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        public void GV_DataQuery2()
        {
            string sql = null;

            string str = Lab_Sp.Text;
            string str1 = DDL_SelSpec.SelectedItem.Text;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course where 开设专业 = " + "'" + str + "' and 课程性质 = "+ "'" + str1 + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
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
                GV_DataQuery();
                SpeciQuery();
            }
        }

        protected void btn_SearchCourse_Click(object sender, EventArgs e)
        {
            string sql = null;
            string str = txt_SearchCourse.Text.Trim();
            string str1 = Lab_Sp.Text;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_Course where 课程代码 = " + "'" + str + "'" + "or 课程名称 = " + "'" + str + "'" + "or 授课教师 = " + "'" + str + "'" + "and 开设专业 = " + "'" + str1 + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_CourseList.DataSource = ds;
            GV_CourseList.DataBind();
            ds.Dispose();
            da.Dispose();
            conn.Dispose();
            conn.Close();
        }

        protected void btn_HavaCourseList_Click(object sender, EventArgs e)
        {
            Response.Redirect("HaveCourse.aspx");
        }

        protected void btn_AddCourse_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < GV_CourseList.Rows.Count; i++)
            {
                CheckBox chk =(CheckBox )GV_CourseList.Rows [i].Cells [0].FindControl ("CB_AddCourse");
                if (chk.Checked)
                {
                    model.C_Id = GV_CourseList.Rows[i].Cells[1].Text;
                    model.S_Id = Session["S_Id"].ToString();
                    model.T_Id = SelTId(i);

                    bool bIsOk = bll.StuAddCourse(model);
                    if (bIsOk == true)
                    {
                        Response.Redirect("HaveCourse.aspx");
                    }
                    else
                    {
                        Response.Redirect("About.aspx");
                    }
                }
            }         
        }

        public string SelTId(int i)
        {
            string sql = null;

            string str = Lab_Sp.Text;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selTId;
            sql = "select T_Id from T_Teacher where T_Name = " + "'" + GV_CourseList.Rows[i].Cells[3].Text + "'";
            selTId = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selTId;
            DataSet ds = new DataSet();
            da.Fill(ds);
            string TId = ds.Tables[0].Rows[0]["T_Id"].ToString();

            return TId;
        }

        protected void DDL_SelSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            GV_DataQuery2();
        }
    }
}