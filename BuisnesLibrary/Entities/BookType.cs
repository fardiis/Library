using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BuisnesLibrary.Entities
{
  public  class BookType
    {
        #region Properies
        public int ID { get; set; }
        public String BookName { get; set; }

        #endregion

        #region Crud
        public bool Insert()
        {
            string command = "Insert into[BookType] (bookname) values (@bookname)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@bookname", this.BookName);
            parametersList.Add(nameParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }

        public bool Update()
        {
            string command = "Update [BookType] set [name]=@name where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@bookname", this.BookName);
            var idParameter = new SqlParameter("@id", this.ID);
            parametersList.Add(nameParameter);
            parametersList.Add(idParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public bool Delete()
        {
            string command = "delete from [BookType] where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var idParameter = new SqlParameter("@id", this.ID);
            parametersList.Add(idParameter);

            var db = new DataAccess.DataBaseManager();

            var result = db.ExecuteCommand(command, parametersList);

            return result;
        }
        public List<BookType> Read()
        {
            string command = "Select * from BookType";
            var db = new DataAccess.DataBaseManager();
            var result = db.GetData(command);

            List<BookType> lstResult = new List<BookType>();
            foreach (DataRow r in result.Rows)
            {
                BookType book = new BookType();
                book.ID = Convert.ToInt32(r["ID"]);
                book.BookName = r["BookName"].ToString();
                lstResult.Add(book);
            }

            return lstResult;
        }
        public int GetCount()
        {
            string command = "select count(*) from BookType where [bookname]=@bookname";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@bookname", this.BookName);
            parametersList.Add(nameParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteScalar(command, parametersList);
            return result;
        }
        #endregion

    }
}
