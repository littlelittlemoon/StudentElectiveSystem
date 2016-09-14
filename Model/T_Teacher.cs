using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class T_Teacher
    {
        /// <summary>
        /// 教师编号
        /// </summary>
        public string T_Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string T_UseName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string T_Pass { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string T_Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string T_Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public Int32 T_Age { get; set; }
        /// <summary>
        /// 所属部门编号
        /// </summary>
        public string D_Id { get; set; }
        /// <summary>
        /// 角色编号
        /// </summary>
        public string R_Id { get; set; }
    }
}
