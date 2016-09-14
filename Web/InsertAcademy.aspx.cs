using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class InsertAcademy : System.Web.UI.Page
    {
        #region==全局对象==
        /// <summary>
        /// 学院模型对象
        /// </summary>
        Model.T_Academy model;
        /// <summary>
        /// 学院表业务逻辑对象
        /// </summary>
        BLL.T_Academy bll;
        #endregion
        #region==全局函数==
        /// <summary>
        /// 初始化全局对象
        /// </summary>
        private void InitGlobal()
        {
            model = new Model.T_Academy();
            bll = new BLL.T_Academy("ConnToCourseSlectedSystem");
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            InitGlobal();
        }

        protected void btn_ACAdd_Click(object sender, EventArgs e)
        {
            model.Ac_Id = txt_AcId.Text.Trim();
            model.Ac_Name = txt_AcName.Text.Trim();

            bool bIsOk = bll.AcademyInsert(model);
            if (bIsOk == true)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Redirect("About.aspx");
              
            }
        }
    }
}