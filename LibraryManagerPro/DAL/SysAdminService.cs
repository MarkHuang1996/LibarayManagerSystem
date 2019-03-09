using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBUtility;
using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SysAdminService
    {
        /// <summary>
        /// loginid and pwd compare with  database 
        /// </summary>
        /// <param name="objAdmin">the object incoulde id and pwd</param>
        /// <returns>admin object</returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            //sql 
            string sql = "select AdminName,StatusId ,RoleId from SysAdmins where ";
            sql += "AdminId = @AdminId and LoginPwd = @LoginPwd";
            //encapsulation of param data
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@AdminId",objAdmin.AdminId),
                new SqlParameter("@AdminPwd",objAdmin.LoginPwd)
            };
            //excute quary
            SqlDataReader objReader = SQLServerHelper.GetReader(sql, param);
            //encapsulation of objAdmin info
            if (objReader.Read())
            {
                objAdmin.AdminName = objReader["AdminName"].ToString();
                objAdmin.StatusId = Convert.ToInt32(objReader["StatusId"]);
                objAdmin.RoleId = Convert.ToInt32(objReader["RoleId"]); 
            }
            else
            {
                objAdmin = null;
            }
            return objAdmin;
        }

    }
}
