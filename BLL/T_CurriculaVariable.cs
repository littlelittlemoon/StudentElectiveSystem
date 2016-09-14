using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class T_CurriculaVariable
    {
        /// <summary>
        /// 选课表的数据访问层对象
        /// </summary>
        DAL.T_CurriculaVariable dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_CurriculaVariable(string strConnectionStringName)
        {
            dal = new DAL.T_CurriculaVariable(strConnectionStringName);
        }
        /// <summary>
        /// 学生选课
        /// </summary>
        /// <param name="model">选课表模型对象</param>
        /// <returns>判断是否选课成功</returns>
        public bool StuAddCourse(Model.T_CurriculaVariable model)
        {
            return dal.StuAddCourse(model);
        }
        public bool StuReturnCourse(Model.T_CurriculaVariable model)
        {
            return dal.StuReturnCourse(model);
        }
    }
}
