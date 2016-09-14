using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    /// <summary>
    /// 用户视图的业务逻辑层
    /// </summary>
    public class V_UserLogin
    {
        
        /// <summary>
        /// 用户视图的数据访问层对象
        /// </summary>
        DAL.V_UserLogin dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public V_UserLogin(string strConnectionStringName)
        {
            dal = new DAL.V_UserLogin(strConnectionStringName);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model">用户模型对象</param>
        /// <returns>判断是否登录成功</returns>
        public bool UserLogin(Model.V_UserLogin model)
        {
            return dal.UserLogin(model);
        }
    }
}
