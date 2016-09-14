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
    public class ModifyTeaPass
    {
        sqlHelpers sql;
        public ModifyTeaPass(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 教师更改密码
        /// </summary>
        /// <param name="model">更改密码模型对象</param>
        /// <returns>判断是否更改成功</returns>
        public bool IsModifyTeaPass(Model.ModifyTeaPass model)
        {
            string cmdText = "P_ModifyTeaPass";
            SqlParameter[] Sps = new SqlParameter[4];

            Sps[0] = new SqlParameter("@T_Id", SqlDbType.Char, 8);
            Sps[0].Value = model.@T_Id;

            Sps[1] = new SqlParameter("@T_PPass", SqlDbType.VarChar, 30);
            Sps[1].Value = model.@T_PPass;

            Sps[2] = new SqlParameter("@T_NPass", SqlDbType.VarChar, 30);
            Sps[2].Value = model.@T_NPass;

            Sps[3] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[3].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[3].Value.ToString());
        }
    }
}
