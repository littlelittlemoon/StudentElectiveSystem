using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class T_Course
    {
        /// <summary>
        /// 课程表的数据访问层对象
        /// </summary>
        DAL.T_Course dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_Course(string strConnectionStringName) 
        {
            dal = new DAL.T_Course(strConnectionStringName);
         }
        /// <summary>
        /// 添加课程
        /// </summary>
        /// <param name="model">课程模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool CourseInsert(Model.T_Course model)
        {
            return dal.CourseInsert(model);
        }

        public bool CourseModify(Model.T_Course model)
        {
            return dal.CourseModify(model);
        }

        public bool CourseDelete(Model.T_Course model)
        {
            return dal.CourseDelete(model);
        }
    }
}
