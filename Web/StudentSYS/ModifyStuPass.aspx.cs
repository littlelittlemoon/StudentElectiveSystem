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
    public partial class ModifyStuPss : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 更改学生密码模型对象
        /// </summary>
        Model.ModifyStuPass model;
        /// <summary>
        /// 更改学生密码业务逻辑对象
        /// </summary>
        BLL.ModifyStuPass bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.ModifyStuPass();
            bll = new BLL.ModifyStuPass("ConnToCourseSlectedSystem");
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

        protected void btn_ModifyStuPass_Click(object sender, EventArgs e)
        {
            model.S_Id = Session["S_Id"].ToString();
            model.S_PPass = txt_PSUPass.Text.Trim();
            model.S_NPass = txt_NSUPass.Text.Trim();

            bool IsOk = bll.IsModifyStuPass(model);
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