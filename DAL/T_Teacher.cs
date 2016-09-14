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
    public class T_Teacher
    {
         sqlHelpers sql;
         public T_Teacher(string strConnectionStringName)
        {
            sql = new sqlHelpers(strConnectionStringName);
        }

         public bool TeacherInsert(Model.T_Teacher model)
        {
            string cmdText = "P_TeacherInsert";
            SqlParameter[] Sps = new SqlParameter[9];

            Sps[0] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@T_Id;

            Sps[1] = new SqlParameter("@T_UseName", SqlDbType.VarChar, 20);
            Sps[1].Value = model.@T_UseName;

            Sps[2] = new SqlParameter("@T_Pass", SqlDbType.VarChar, 30);
            Sps[2].Value = model.@T_Pass;

            Sps[3] = new SqlParameter("@T_Name", SqlDbType.VarChar, 6);
            Sps[3].Value = model.@T_Name;
            
            Sps[4] = new SqlParameter("@T_Sex", SqlDbType.Char, 2);
            Sps[4].Value = model.@T_Sex;
             
            Sps[5] = new SqlParameter("@T_Age", SqlDbType.SmallInt);
            Sps[5].Value = model.@T_Age;
            
            Sps[6] = new SqlParameter("@D_Id", SqlDbType.Char, 4);
            Sps[6].Value = model.@D_Id;

            Sps[7] = new SqlParameter("@R_Id", SqlDbType.Char, 4);
            Sps[7].Value = model.@R_Id;

            Sps[8] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[8].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[8].Value.ToString());
        }

         public bool TeacherModify(Model.T_Teacher model)
         {
             string cmdText = "P_TeacherModify";
             SqlParameter[] Sps = new SqlParameter[9];

             Sps[0] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
             Sps[0].Value = model.@T_Id;

             Sps[1] = new SqlParameter("@T_UseName", SqlDbType.VarChar, 20);
             Sps[1].Value = model.@T_UseName;

             Sps[2] = new SqlParameter("@T_Pass", SqlDbType.VarChar, 30);
             Sps[2].Value = model.@T_Pass;

             Sps[3] = new SqlParameter("@T_Name", SqlDbType.VarChar, 6);
             Sps[3].Value = model.@T_Name;

             Sps[4] = new SqlParameter("@T_Sex", SqlDbType.Char, 2);
             Sps[4].Value = model.@T_Sex;

             Sps[5] = new SqlParameter("@T_Age", SqlDbType.SmallInt);
             Sps[5].Value = model.@T_Age;

             Sps[6] = new SqlParameter("@D_Id", SqlDbType.Char, 4);
             Sps[6].Value = model.@D_Id;

             Sps[7] = new SqlParameter("@R_Id", SqlDbType.Char, 4);
             Sps[7].Value = model.@R_Id;

             Sps[8] = new SqlParameter("@bIsOK", SqlDbType.Bit);
             Sps[8].Direction = ParameterDirection.Output;

             sql.ExecuteProcReturnVoid(cmdText, Sps);

             return bool.Parse(Sps[8].Value.ToString());
         }


         public bool TeacherDelete(Model.T_Teacher model)
         {
             string cmdText = "P_TeacherDelete";
             SqlParameter[] Sps = new SqlParameter[2];

             Sps[0] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
             Sps[0].Value = model.@T_Id;

             Sps[1] = new SqlParameter("@bIsOK", SqlDbType.Bit);
             Sps[1].Direction = ParameterDirection.Output;

             sql.ExecuteProcReturnVoid(cmdText, Sps);

             return bool.Parse(Sps[1].Value.ToString());
         }
    }
}
