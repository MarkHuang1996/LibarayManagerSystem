﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using DBUtility;
using Common;


namespace DAL
{
    public class BookService
    {
        #region category and publisher
        public List<Category> GetCategory()
        {
            string sql = "select CategoryId,CategoryName from Categories ";
            List<Category> list = new List<Category>();
            SqlDataReader objReader = SQLServerHelper.GetReader(sql);
            //
            while (objReader.Read())
            {
                list.Add(new Category()
                {
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    CategoryName = objReader["CategoryName"].ToString()

                });

            }
            objReader.Close();
            return list;
        }

        public List<Publisher> GetPublishers()
        {
            string sql = "select PublisherId,PublisherName from Publishers ";
            List<Publisher> list = new List<Publisher>();
            SqlDataReader objReader = SQLServerHelper.GetReader(sql);
            //
            while (objReader.Read())
            {
                list.Add(new Publisher()
                {
                    PublisherId = Convert.ToInt32(objReader["PublisherId"]),
                    PublisherName = objReader["PublisherName"].ToString()

                });

            }
            objReader.Close();
            return list;
        }
        #endregion

        #region Add new book
        /// <summary>
        /// 判断条码是否存在
        /// </summary>
        /// <param name="BarCode"></param>
        /// <returns></returns>
        public int GetCountByBarCode(string BarCode)
        {
            string sql = "select count(*) from Books where BarCode = @BarCode";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@BarCode", BarCode) };
            return Convert.ToInt32(SQLServerHelper.GetSingleReulst(sql, param));
        }

        public int AddBookk(Books Book)
        {
            //packege data
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@BarCode",Book.BarCode),
                new SqlParameter("@BookName",Book.BookName),
                new SqlParameter("@Author",Book.Author),
                new SqlParameter("@PublisherId",Book.PublisherId),
                new SqlParameter("@PublisherDate",Book.PublisherDate),
                new SqlParameter("@BookCategory",Book.BookCategoryId),
                new SqlParameter("@UnitPrice",Book.UnitPrice),
                new SqlParameter("@BookImage",Book.BookImage),
                new SqlParameter("@BookCount",Book.BookCount),
                new SqlParameter("@Remainder",Book.Remainder),
                new SqlParameter("@BookPosition",Book.BookPosition)

            };
            return SQLServerHelper.UpdateProcedure("usp_AddBook", parameters);






        }
        #endregion

        #region SearchBookByBarCode
        public Books GetBooksByBarCode(string BarCode)
        {
            string sql = "select BookId, BarCode, BookName, Author, Books.PublisherId, PublisherDate, BookCategoryId, UnitPrice, BookImage, BookCount, Remainder, BookPosition, RegTime,PublisherName,CategoryName from Books ";
            sql += " inner join Categories on Books.BookCategoryId = Categories.CategoryId ";
            sql += " inner join Publishers  on Books.PublisherId = Publishers.PublisherId ";
            sql += "where BarCode = @BarCode";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BarCode",BarCode )
            };

            SqlDataReader objReader = SQLServerHelper.GetReader(sql, param);
            Books objBook = null;
            if (objReader.Read())
            {
                objBook = new Books()
                {
                    BookId = Convert.ToInt32(objReader["BookId"]),

                    BarCode = objReader["BarCode"].ToString(),
                    BookName = objReader["BookName"].ToString(),
                    Author = objReader["Author"].ToString(),
                    PublisherId = Convert.ToInt32(objReader["PublisherId"]),
                    PublisherDate = Convert.ToDateTime(objReader["PublisherDate"]),
                    BookCategoryId = Convert.ToInt32(objReader["BookCategoryId"]),
                    UnitPrice = Convert.ToInt32(objReader["UnitPrice"]),
                    BookImage = objReader["BookImage"] is DBNull?"": objReader["BookImage"].ToString(),
                    BookCount = Convert.ToInt32(objReader["BookCount"]),
                    Remainder = Convert.ToInt32(objReader["BookCount"]),
                    BookPosition = objReader["BookPosition"].ToString(),
                    Regtime = Convert.ToDateTime(objReader["Regtime"]),
                    PublisherName = objReader["PublisherName"].ToString(),
                    CategoryName = objReader["CategoryName"].ToString()
                };
            }
            objReader.Close();
            return objBook;

        }

        /// <summary>
        /// update the BookCount
        /// </summary>
        /// <param name="BarCode">BarCode</param>
        /// <param name="bookcount"></param>
        /// <returns></returns>
        public int AddBookCount(string BarCode,int bookcount)
        {
            string sql = "update Books set BookCount =  BookCount +@BookCount where BarCode = @BarCode";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BarCode",BarCode),
                new SqlParameter("@BookCount",bookcount)
            };
            return SQLServerHelper.Update(sql, param);
        }
        #endregion


    }
}
