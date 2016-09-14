using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using DBUtility;

namespace DAL
{
    public class T_Academy
    {
        sqlHelpers sql;
        public T_Academy(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 添加学院信息
        /// </summary>
        /// <param name="model">学院模型对象</param>
        /// <returns>判断是否添加成功</returns>
        public bool AcademyInsert(Model.T_Academy model)
        {
            string cmdText = "P_AcademyInsert";
            SqlParameter[] Sps = new SqlParameter[3];

            Sps[0] = new SqlParameter("@Ac_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@Ac_Id;

            Sps[1] = new SqlParameter("@Ac_Name", SqlDbType.VarChar, 30);
            Sps[1].Value = model.@Ac_Name;

            Sps[2] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[2].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[2].Value.ToString());
        }
    
    }
}
