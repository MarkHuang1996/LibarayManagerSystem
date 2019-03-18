using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
  public  class BookManager
    {
        private BookService objBookService = new BookService();
        public List<Publisher> GetPublisher()
        {
            return objBookService.GetPublishers();
        }

        public List<Category> GetCategory()
        {
            return objBookService.GetCategory();
        }

        public int AddBookk(Books Book)
        {
            return objBookService.AddBookk(Book);
        }

        public bool BarCodeExistsed(string barcode)
        {
            int count = objBookService.GetCountByBarCode(barcode);
            if (count == 1) return true;
            else return false;
        }

        public Books GetBooksByBarCode(string BarCode)
        {
            return objBookService.GetBooksByBarCode(BarCode);
        }

        /// <summary>
        /// update the BookCount
        /// </summary>
        /// <param name="BarCode">BarCode</param>
        /// <param name="bookcount"></param>
        /// <returns></returns>
        public int AddBookCount(string BarCode, int bookcount)
        {
            return objBookService.AddBookCount(BarCode, bookcount);
        }

        public List<Books> GetBook(int CategoryId, string BarCode, string BookName)
        {
            return objBookService.GetBook(CategoryId, BarCode, BookName);
        }

        public int EditBook(Books Book)
        {
            return objBookService.EditBook(Book);
        }

        public int DeleteBook(string BookId)
        {
            return objBookService.DeleteBook(BookId);
        }
    }

}
