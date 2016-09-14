using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class V_UserLogin
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string U_Name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string U_Pass { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        public string U_Role { get; set; }
    }
}
