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
    /// 学院表的业务逻辑层
    /// </summary>
    public class T_Academy
    {
        /// <summary>
        /// 学院表的数据访问层对象
        /// </summary>
        DAL.T_Academy dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_Academy(string strConnectionStringName) 
        {
            dal = new DAL.T_Academy(strConnectionStringName);
         }
        /// <summary>
        /// 添加学院信息
        /// </summary>
        /// <param name="model">学院模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool AcademyInsert(Model.T_Academy model)
        {
            return dal.AcademyInsert(model);
        }
    }
}
