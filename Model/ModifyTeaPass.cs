using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModifyTeaPass
    {
        /// <summary>
        /// 教师编号
        /// </summary>
        public string T_Id { get; set; }
        /// <summary>
        /// 原密码
        /// </summary>
        public string T_PPass { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string T_NPass { get; set; }
    }
}
