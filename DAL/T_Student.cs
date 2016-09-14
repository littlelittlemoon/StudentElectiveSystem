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
    public class T_Student
    {
        sqlHelpers sql;
        public T_Student(string strConnectionStringName)
        {
            sql = new sqlHelpers(strConnectionStringName);
        }

         public bool StudentInsert(Model.T_Student model)
        {
            string cmdText = "P_StudentInsert";
            SqlParameter[] Sps = new SqlParameter[10];

            Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
            Sps[0].Value = model.@S_Id;

            Sps[1] = new SqlParameter("@S_UserName", SqlDbType.VarChar, 20);
            Sps[1].Value = model.@S_UserName;

            Sps[2] = new SqlParameter("@S_Pass", SqlDbType.VarChar, 30);
            Sps[2].Value = model.@S_Pass;

            Sps[3] = new SqlParameter("@S_Name", SqlDbType.VarChar, 6);
            Sps[3].Value = model.@S_Name;
            
            Sps[4] = new SqlParameter("@S_Sex", SqlDbType.Char, 2);
            Sps[4].Value = model.@S_Sex;
             
            Sps[5] = new SqlParameter("@S_Age", SqlDbType.SmallInt);
            Sps[5].Value = model.@S_Age;
            
            Sps[6] = new SqlParameter("@Sp_Id", SqlDbType.Char, 4);
            Sps[6].Value = model.@Sp_Id;
             
            Sps[7] = new SqlParameter("@Cl_Id", SqlDbType.Char, 4);
            Sps[7].Value = model.@Cl_Id;

            Sps[8] = new SqlParameter("@R_Id", SqlDbType.Char, 4);
            Sps[8].Value = model.@R_Id;

            Sps[9] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[9].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);
         
            return bool.Parse(Sps[9].Value.ToString());
        }
         public bool StudentModify(Model.T_Student model)
         {
             string cmdText = "P_StudentModify";
             SqlParameter[] Sps = new SqlParameter[10];

             Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
             Sps[0].Value = model.@S_Id;

             Sps[1] = new SqlParameter("@S_UserName", SqlDbType.VarChar, 20);
             Sps[1].Value = model.@S_UserName;

             Sps[2] = new SqlParameter("@S_Pass", SqlDbType.VarChar, 30);
             Sps[2].Value = model.@S_Pass;

             Sps[3] = new SqlParameter("@S_Name", SqlDbType.VarChar, 6);
             Sps[3].Value = model.@S_Name;

             Sps[4] = new SqlParameter("@S_Sex", SqlDbType.Char, 2);
             Sps[4].Value = model.@S_Sex;

             Sps[5] = new SqlParameter("@S_Age", SqlDbType.SmallInt);
             Sps[5].Value = model.@S_Age;

             Sps[6] = new SqlParameter("@Sp_Id", SqlDbType.Char, 4);
             Sps[6].Value = model.@Sp_Id;

             Sps[7] = new SqlParameter("@Cl_Id", SqlDbType.Char, 4);
             Sps[7].Value = model.@Cl_Id;

             Sps[8] = new SqlParameter("@R_Id", SqlDbType.Char, 4);
             Sps[8].Value = model.@R_Id;

             Sps[9] = new SqlParameter("@bIsOK", SqlDbType.Bit);
             Sps[9].Direction = ParameterDirection.Output;

             sql.ExecuteProcReturnVoid(cmdText, Sps);

             return bool.Parse(Sps[9].Value.ToString());
         }

         public bool StudentDelete(Model.T_Student model)
         {
             string cmdText = "P_StudentDelete";
             SqlParameter[] Sps = new SqlParameter[2];

             Sps[0] = new SqlParameter("@S_Id", SqlDbType.Char, 8);
             Sps[0].Value = model.@S_Id;

             Sps[1] = new SqlParameter("@bIsOK", SqlDbType.Bit);
             Sps[1].Direction = ParameterDirection.Output;

             sql.ExecuteProcReturnVoid(cmdText, Sps);

             return bool.Parse(Sps[1].Value.ToString());
         }
    }
}
