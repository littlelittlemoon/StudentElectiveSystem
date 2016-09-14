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
    public class T_Course
    {
        sqlHelpers sql;
        public T_Course(string strConnectionStringName)
        {
            sql = new sqlHelpers(strConnectionStringName);
        }

        public bool CourseInsert(Model.T_Course model)
        {
            string cmdText = "P_CourseInsert";
            SqlParameter[] Sps = new SqlParameter[10];

            Sps[0] = new SqlParameter("@C_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@C_Id;

            Sps[1] = new SqlParameter("@Sp_Id", SqlDbType.Char, 4);
            Sps[1].Value = model.@Sp_Id;

            Sps[2] = new SqlParameter("@C_Name", SqlDbType.VarChar, 20);
            Sps[2].Value = model.@C_Name;

            Sps[3] = new SqlParameter("@C_Species", SqlDbType.Char, 4);
            Sps[3].Value = model.@C_Species;

            Sps[4] = new SqlParameter("@C_Credit", SqlDbType.Float);
            Sps[4].Value = model.@C_Credit;

            Sps[5] = new SqlParameter("@C_Period", SqlDbType.Int);
            Sps[5].Value = model.@C_Period;

            Sps[6] = new SqlParameter("@C_StartTime", SqlDbType.Date);
            Sps[6].Value = model.@C_StartTime;

            Sps[7] = new SqlParameter("@C_Location", SqlDbType.VarChar, 8);
            Sps[7].Value = model.@C_Location;

            Sps[8] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
            Sps[8].Value = model.@T_Id;

            Sps[9] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[9].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);

            return bool.Parse(Sps[9].Value.ToString());
        }


        public bool CourseModify(Model.T_Course model)
        {
            string cmdText = "P_CourseModify";
            SqlParameter[] Sps = new SqlParameter[10];

            Sps[0] = new SqlParameter("@C_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@C_Id;

            Sps[1] = new SqlParameter("@Sp_Id", SqlDbType.Char, 4);
            Sps[1].Value = model.@Sp_Id;

            Sps[2] = new SqlParameter("@C_Name", SqlDbType.VarChar, 20);
            Sps[2].Value = model.@C_Name;

            Sps[3] = new SqlParameter("@C_Species", SqlDbType.Char, 4);
            Sps[3].Value = model.@C_Species;

            Sps[4] = new SqlParameter("@C_Credit", SqlDbType.Float);
            Sps[4].Value = model.@C_Credit;

            Sps[5] = new SqlParameter("@C_Period", SqlDbType.Int);
            Sps[5].Value = model.@C_Period;

            Sps[6] = new SqlParameter("@C_StartTime", SqlDbType.Date);
            Sps[6].Value = model.@C_StartTime;

            Sps[7] = new SqlParameter("@C_Location", SqlDbType.VarChar, 8);
            Sps[7].Value = model.@C_Location;

            Sps[8] = new SqlParameter("@T_Id", SqlDbType.Char, 4);
            Sps[8].Value = model.@T_Id;

            Sps[9] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[9].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);

            return bool.Parse(Sps[9].Value.ToString());
        }

        public bool CourseDelete(Model.T_Course model)
        {
            string cmdText = "P_CourseDelete";
            SqlParameter[] Sps = new SqlParameter[2];

            Sps[0] = new SqlParameter("@C_Id", SqlDbType.Char, 4);
            Sps[0].Value = model.@C_Id;

            Sps[1] = new SqlParameter("@bIsOK", SqlDbType.Bit);
            Sps[1].Direction = ParameterDirection.Output;

            sql.ExecuteProcReturnVoid(cmdText, Sps);

            return bool.Parse(Sps[1].Value.ToString());
        }
    }
}
