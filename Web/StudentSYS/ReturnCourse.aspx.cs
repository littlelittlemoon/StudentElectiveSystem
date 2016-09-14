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
    public partial class ReturnCourse : System.Web.UI.Page
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


        public string SelTId(int i)
        {
            string sql = null;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selTId;
            sql = "select T_Id from T_Teacher where T_Name = " + "'" + GV_HaveCourseList.Rows[i].Cells[5].Text + "'";
            selTId = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selTId;
            DataSet ds = new DataSet();
            da.Fill(ds);
            string TId = ds.Tables[0].Rows[0]["T_Id"].ToString();

            return TId;
        }

        public void GV_DataQuery()
        {
            string sql = null;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=CourseSlectedSystem;Integrated Security=True";
            SqlCommand selDVData;
            sql = "select * from V_CourseSelected where 学号 = " + "'" + Session["S_Id"] + "'";
            selDVData = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = selDVData;
            DataSet ds = new DataSet();
            da.Fill(ds);
            GV_HaveCourseList.DataSource = ds;
            GV_HaveCourseList.DataBind();
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
                GV_DataQuery();
            }
            
        }

        protected void btn_ReturnCourse_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GV_HaveCourseList.Rows.Count; i++)
            {
                CheckBox chk = (CheckBox)GV_HaveCourseList.Rows[i].Cells[0].FindControl ("CB_ReCourse");
                if(chk.Checked)
                {
                    model.C_Id = GV_HaveCourseList.Rows[i].Cells[3].Text;
                    model.S_Id = Session["S_Id"].ToString();
                    model.T_Id = SelTId(i);
                    bool bIsOk = bll.StuReturnCourse(model);
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

                   
    }
}