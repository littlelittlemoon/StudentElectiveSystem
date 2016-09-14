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
    public class T_Specialty
    {
         sqlHelpers sql;
         public T_Specialty(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 添加专业信息
        /// </summary>
        /// <param name="model">准也模型对象</param>
        /// <returns>判断是否添加成功</returns>
         public bool SpecialtyInsert(Model.T_Specialty model)
        {
            string cmdText = "P_SpecialtyInsert";
            SqlParameter[] Sps = new SqlParameter[4];

            Sps[0] = new SqlParameter("@Sp_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@Sp_Id;

            Sps[1] = new SqlParameter("@Sp_Name", SqlDbType.VarChar, 30);
            Sps[1].Value = model.@Sp_Name;

            Sps[2] = new SqlParameter("@Ac_Id", SqlDbType.Char, 4);
            Sps[2].Value = model.@Ac_Id;

            Sps[3] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[3].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[2].Value.ToString());
        }
    }
}
