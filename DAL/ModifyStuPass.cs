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
    public class ModifyStuPass
    {
        sqlHelpers sql;
        public ModifyStuPass(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 学生更改密码
        /// </summary>
        /// <param name="model">更改密码模型对象</param>
        /// <returns>判断是否更改成功</returns>
        public bool IsModifyStuPass(Model.ModifyStuPass model)
        {
            string cmdText = "P_StuModifyPass";
            SqlParameter[] Sps = new SqlParameter[4];

            Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
            Sps[0].Value = model.@S_Id;

            Sps[1] = new SqlParameter("@S_PPass", SqlDbType.VarChar, 30);
            Sps[1].Value = model.@S_PPass;

            Sps[2] = new SqlParameter("@S_NPass", SqlDbType.VarChar, 30);
            Sps[2].Value = model.@S_NPass;

            Sps[3] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[3].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[3].Value.ToString());
        }
    }
}
