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
    /// 更改教师密码业务逻辑层
    /// </summary>
    public class ModifyTeaPass
    {  
        /// <summary>
        /// 更改教师密码的数据访问层对象
        /// </summary>
        DAL.ModifyTeaPass dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public ModifyTeaPass(string strConnectionStringName)
        {
            dal = new DAL.ModifyTeaPass(strConnectionStringName);
        }
        /// <summary>
        /// 教师更改密码
        /// </summary>
        /// <param name="model">更改教师密码模型对象</param>
        /// <returns>判断是否更改成功</returns>
        public bool IsModifyTeaPass(Model.ModifyTeaPass model)
        {
            return dal.IsModifyTeaPass(model);
        }
    }
}
