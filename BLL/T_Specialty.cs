using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 专业表的业务逻辑层
    /// </summary>
    public class T_Specialty
    {
        /// <summary>
        /// 专业表的数据访问层对象
        /// </summary>
        DAL.T_Specialty dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_Specialty(string strConnectionStringName) 
        {
            dal = new DAL.T_Specialty(strConnectionStringName);
         }
        /// <summary>
        /// 添加专业信息
        /// </summary>
        /// <param name="model">专业模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool SpecialtyInsert(Model.T_Specialty model)
        {
            return dal.SpecialtyInsert(model);
        }
    }
}
