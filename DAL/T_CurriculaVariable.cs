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
    public class T_CurriculaVariable
    {
        sqlHelpers sql;
        public T_CurriculaVariable(string strConnectionStringName)
        {
             sql = new sqlHelpers(strConnectionStringName);
        }
        /// <summary>
        /// 学生选课
        /// </summary>
        /// <param name="model">选课表模型对象</param>
        /// <returns>判断是否选课成功</returns>
        public bool StuAddCourse(Model.T_CurriculaVariable model)
        {
            string cmdText = "P_CurriculaVariableInsert";
            SqlParameter[] Sps = new SqlParameter[4];

            Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
            Sps[0].Value = model.@S_Id;

            Sps[1] = new SqlParameter("@C_Id", SqlDbType.Char, 4);
            Sps[1].Value = model.@C_Id;

            Sps[2] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
            Sps[2].Value = model.@T_Id;

            Sps[3] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[3].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[3].Value.ToString());
        }

        public bool StuReturnCourse(Model.T_CurriculaVariable model)
        {
            string cmdText = "P_CurriculaVariableDelete";
            SqlParameter[] Sps = new SqlParameter[3];

            Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
            Sps[0].Value = model.@S_Id;

            Sps[1] = new SqlParameter("@C_Id", SqlDbType.Char, 4);
            Sps[1].Value = model.@C_Id;

            Sps[2] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[2].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[2].Value.ToString());
        }
    }
}
