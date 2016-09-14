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
    public class V_UserLogin
    {
        sqlHelpers sql;
        public V_UserLogin(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="model">用户模型对象</param>
        /// <returns>判断是否登录成功</returns>
        public bool UserLogin(Model.V_UserLogin model)
        {
            string cmdText = "P_UserLogin";
            SqlParameter[] Sps = new SqlParameter[4];

            Sps[0] = new SqlParameter("@U_Name", SqlDbType.VarChar, 20);
            Sps[0].Value = model.@U_Name;

            Sps[1] = new SqlParameter("@U_Pass", SqlDbType.VarChar, 30);
            Sps[1].Value = model.@U_Pass;

            Sps[2] = new SqlParameter("@U_Role", SqlDbType.VarChar, 6);
            Sps[2].Value = model.@U_Role;

            Sps[3] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[3].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[3].Value.ToString());
        }
    }
}
