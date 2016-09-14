using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 专业表模型
    /// </summary>
    public class T_Specialty
    {
        /// <summary>
        /// 专业编号
        /// </summary>
        public string Sp_Id { get; set; }
        /// <summary>
        /// 专业名称
        /// </summary>
        public string Sp_Name { get; set; }
        /// <summary>
        /// 学院编号
        /// </summary>
        public string Ac_Id { get; set; }
    }
}
