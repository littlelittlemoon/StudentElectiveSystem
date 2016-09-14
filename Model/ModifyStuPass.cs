using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModifyStuPass
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string S_Id { get; set; }
        /// <summary>
        /// 原密码
        /// </summary>
        public string S_PPass { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        public string S_NPass { get; set; }
    }
}
