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
    /// 更改学生密码业务逻辑层
    /// </summary>
    public class ModifyStuPass
    {
        /// <summary>
        /// 更改学生密码的数据访问层对象
        /// </summary>
        DAL.ModifyStuPass dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public ModifyStuPass(string strConnectionStringName)
        {
            dal = new DAL.ModifyStuPass(strConnectionStringName);
        }
        /// <summary>
        /// 学生更改密码
        /// </summary>
        /// <param name="model">更改学生密码模型对象</param>
        /// <returns>判断是否更改成功</returns>
        public bool IsModifyStuPass(Model.ModifyStuPass model)
        {
            return dal.IsModifyStuPass(model);
        }
    }

}
