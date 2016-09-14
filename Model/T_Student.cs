using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 学生表模型
    /// </summary>
    public class T_Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string S_Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string S_UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string S_Pass { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string S_Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string S_Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public Int32 S_Age { get; set; }
        /// <summary>
        /// 专业编号
        /// </summary>
        public string Sp_Id { get; set; }
        /// <summary>
        /// 班级编号
        /// </summary>
        public string Cl_Id { get; set; }
        /// <summary>
        /// 角色编号
        /// </summary>
        public string R_Id { get; set; }
        
    }
}
