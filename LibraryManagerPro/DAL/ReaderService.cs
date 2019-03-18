using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ReaderService
    {
        // New Reader
        public int AddNewReader(Reader objReader)
        {
            //define sql quary
            string sql = "insert into Readers(ReaderCard,ReaderNumber,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,RoleId,ReaderImage,ReaderPwd,AdminId) ";
            sql += " values (@ReaderCard,@ReaderNumber,@Gender,@IDCard,@ReaderAddress,@PostCode,@PhoneNumber,@RoleId,@ReaderImage,@ReaderPwd,@AdminId)";
            //define sqlparameters
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReaderCard",objReader.ReaderCard),
                 new SqlParameter("@ReaderNumber",objReader.ReaderNumber),
                  new SqlParameter("@Gender",objReader.Gender),
                   new SqlParameter("@IDCard",objReader.IDCard),
                    new SqlParameter("@ReaderAddress",objReader.ReaderAddress),
                     new SqlParameter("@PostCode",objReader.PostCode),
                      new SqlParameter("@PhoneNumber",objReader.PhoneNumber),
                       new SqlParameter("@RoleId",objReader.RoleId),
                        new SqlParameter("@ReaderImage",objReader.ReaderImage),
                        new SqlParameter("@ReaderPwd",objReader.ReaderPwd),
                        new SqlParameter("@AdminId",objReader.AdminId)

            };

            //call DAL
            return SQLServerHelper.Update(sql, param);

        };

        //Edit Reader
        public int EditReader(Reader objReader)
        {
            string sql = "Update Readers set ReaderNumber=@ReaderNumber,Gender=@Gender,ReaderAddress=@ReaderAddress,PostCode=@PostCode,PhoneNumber=@PhoneNumber,ReaderImage=@ReaderImage ";
            sql += " where ReaderId = @ReaderId ";


            //define sqlparameters
            SqlParameter[] param = new SqlParameter[]
            {

                 new SqlParameter("@ReaderNumber",objReader.ReaderNumber),
                 new SqlParameter("@Gender",objReader.Gender),
                 new SqlParameter("@ReaderAddress",objReader.ReaderAddress),
                 new SqlParameter("@PostCode",objReader.PostCode),
                 new SqlParameter("@PhoneNumber",objReader.PhoneNumber),
                 new SqlParameter("@RoleId",objReader.RoleId),
                 new SqlParameter("@ReaderImage",objReader.ReaderImage),
                 new SqlParameter("@ReaderId",objReader.ReaderId)


            };
            return SQLServerHelper.Update(sql, param);
        };

        //Lost Reader Card
        public int BanedCard(string readerId)
        {
            string sql = "Update Readers set StatusId = 0 where ReaderId = @ReaderId";
            return SQLServerHelper.Update(sql, new SqlParameter[] { new SqlParameter("@ReaderId", readerId) });
        }



        //ReaderRole Search
       public DataTable GetAllReaderRole()
        {
            string sql = "select RoleId ,RoleName from ReaderRoles";
            return SQLServerHelper.GetDataSet(sql).Tables[0];
        }

    //SearchByReaderCard
   public Reader SearchByReaderCard()
        {
           string sql = "select ReaderCard,ReaderNumber,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,RoleId,ReaderImage,ReaderPwd,AdminId "
        }


    //Search By Id

        //search the count of the reader in different  ReaderRoles


    }
}
