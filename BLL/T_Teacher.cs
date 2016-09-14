using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class T_Teacher
    {
        /// <summary>
        /// 教师表的数据访问层对象
        /// </summary>
        DAL.T_Teacher dal;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strConnectionStringName">数据库连接字符串的名字</param>
        public T_Teacher(string strConnectionStringName) 
        {
            dal = new DAL.T_Teacher(strConnectionStringName);
         }
        /// <summary>
        /// 添加教师
        /// </summary>
        /// <param name="model">教师模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool TeacherInsert(Model.T_Teacher model)
        {
            return dal.TeacherInsert(model);
        }
        public bool TeacherModify(Model.T_Teacher model)
        {
            return dal.TeacherModify(model);
        }

        public bool TeacherDelete(Model.T_Teacher model)
        {
            return dal.TeacherDelete(model);
        }
    }
}
