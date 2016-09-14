using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class T_Student
    {
        /// <summary>
        /// 学生表的数据访问层对象
        /// </summary>
        DAL.T_Student dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_Student(string strConnectionStringName) 
        {
            dal = new DAL.T_Student(strConnectionStringName);
         }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="model">学生模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool StudentInsert(Model.T_Student model)
        {
            return dal.StudentInsert(model);
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="model">学生模型对象</param>
        /// <returns>判断是否修改成功</returns>
        public bool StudentModify(Model.T_Student model)
        {
            return dal.StudentModify(model);
        }

        /// <summary>
        /// 删除学生
        /// </summary>
        /// <param name="model">学生模型对象</param>
        /// <returns>判断是否删除成功</returns>
        public bool StudentDelete(Model.T_Student model)
        {
            return dal.StudentDelete(model);
        }
    }
}
