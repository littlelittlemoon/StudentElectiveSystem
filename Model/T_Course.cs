using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 课程表模型
    /// </summary>
    public class T_Course
    {
        /// <summary>
        /// 课程编号
        /// </summary>
        public string C_Id { get; set; }
        /// <summary>
        /// 开设专业代码
        /// </summary>
        public string Sp_Id { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string C_Name { get; set; }
        /// <summary>
        /// 课程性质
        /// </summary>
        public string C_Species { get; set; }
        /// <summary>
        /// 学分
        /// </summary>
        public Double C_Credit { get; set; }
        /// <summary>
        /// 学时
        /// </summary>
        public Int32 C_Period { get; set; }
        /// <summary>
        /// 开课时间
        /// </summary>
        public DateTime C_StartTime { get; set; }
        /// <summary>
        /// 上课地点
        /// </summary>
        public string C_Location { get; set; }
        /// <summary>
        /// 授课教师编号
        /// </summary>
        public string T_Id { get; set; }
    }
}
