using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DBUtility
{
    /// <summary>
    /// Sql server Helper
    /// </summary>
    public class SQLServerHelper
    {

        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        #region SQL quary 

        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the Update method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static object GetSingleReulst(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the GetSingleReulst method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the GetReader method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the GetDataSet method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }


        #endregion


        #region sql quary with param
        public static int Update(string sql,SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  Update(string sql,SqlParameter[] param) method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static object GetSingleReulst(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  GetSingleReulst(string sql, SqlParameter[] param) method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static SqlDataReader GetReader(string sql,SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  GetReader(string sql,SqlParameter[] param) method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }

        #endregion

        #region sql quary with process 
        public static int UpdateProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  UpdateProceduremethod : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static object GetSingleReulstProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  GetSingleReulstProcedure param) method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }

        }
        public static SqlDataReader GetReaderProcedure(string spName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(spName, conn);
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                //excepion log call writelog method
                string errorInfo = "when calling the  GetReaderProcedure method : " + ex.Message;
                WriteLog(errorInfo);
                throw new Exception(errorInfo);
            }
        }

        /// <summary>
        /// using the Transaction submit sql quary with Param
        /// </summary>
        /// <param name="mainSql">MainTable sql</param>
        /// <param name="mainParam">Maintabel Param</param>
        /// <param name="detailSql">Detail Sql</param>
        /// <param name="detailParam">Deatal param</param>
        /// <returns></returns>
        public static bool UpdateByTran(string mainSql, SqlParameter[] mainParam,string detailSql,List<SqlParameter[]> detailParam)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();//Start Transaction
                if(mainSql != null&& mainSql.Length!= 0)
                {
                    cmd.CommandText = mainSql;
                    cmd.Parameters.AddRange(mainParam);
                    cmd.ExecuteNonQuery();
                }
               foreach(SqlParameter[] param  in detailParam)
                {
                    cmd.CommandText = detailSql;
                    cmd.Parameters.Clear();// must be clared befre use
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                     
                }
                cmd.Transaction.Commit();
                return true; 
            }
            catch (Exception ex)
            {

                if(cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//Rollback
                }
                string errorinfo = "when calling the  UpdateByTran(string mainSql, SqlParameter[] mainParam,string detailSql,List<SqlParameter[]> detailParam)   method : " + ex.Message;
                throw new Exception(errorinfo);

            }
            finally
            {
               if(cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }
        /// <summary>
        /// using Transaction to call procedure with param
        /// </summary>
        /// <param name="procedureName"></param>
        /// <param name="paramArray"></param>
        /// <returns></returns>
        public static bool UpdateByTran(string procedureName,List<SqlParameter[]> paramArray)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedureName;
                cmd.Transaction = conn.BeginTransaction();//Start Transaction
          
                foreach (SqlParameter[] param  in paramArray)
                {
                 
                    cmd.Parameters.Clear();// must be clared befre use
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();

                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {

                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();//Rollback
                }
                string errorinfo = "when calling the  UpdateByTran(string procedureName,List<SqlParameter[]> paramArray)    method : " + ex.Message;
                throw new Exception(errorinfo);

            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }
        #endregion


        #region other
        private static void WriteLog(string log)
        {
            FileStream fs = new FileStream("sqlhelperLog", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString() + "    " + log);
            sw.Close();
            fs.Close();
        }
        #endregion
    }
}
