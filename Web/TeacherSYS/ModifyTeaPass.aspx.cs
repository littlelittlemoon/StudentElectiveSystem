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
    public partial class ModifyTeaPass : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 更改教师密码模型对象
        /// </summary>
        Model.ModifyTeaPass model;
        /// <summary>
        /// 更改教师密码业务逻辑对象
        /// </summary>
        BLL.ModifyTeaPass bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.ModifyTeaPass();
            bll = new BLL.ModifyTeaPass("ConnToCourseSlectedSystem");
        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["U_Name"] == null)
            {
                Response.Redirect("../V_UserLogin.aspx");
            }
            InitGlobal();
        }



        protected void btn_ModifyTeaPass_Click1(object sender, EventArgs e)
        {
            model.T_Id = Session["T_Id"].ToString();
            model.T_PPass = txt_PTUPass.Text.Trim();
            model.T_NPass = txt_NTUPass.Text.Trim();

            bool IsOk = bll.IsModifyTeaPass(model);
            if (IsOk)
            {
                Response.Redirect("V_UserLogin.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");
            }
        }
    }
}