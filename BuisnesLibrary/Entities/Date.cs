using BuisnesLibrary.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLibrary.Entities
{
   public class Date
    {
        #region Properties
        public int ID { get; set; }
        public  DateTime EntranceDate { get; set; }



        public Karbar Karbar { get; set; }//1-n
        public BookType BookType { get; set; }//1-n



        #endregion
        #region  ReadOnly
        public string NameOfUser
        {
            get
            {
                return Karbar.Name + " " + Karbar.SurName;
            }
        }
        public string BookTypeName
        {
            get
            {
                return BookType.BookName;
            }
        }
        public string ShamsiDate
        {
            get
            {
                return this.EntranceDate.ToPersianDateString();
            }
        }
        public String NameOfBook { get;  }
        #endregion
        #region Crud

        public bool Insert()
        {
            string command = "INSERT into [Date](EntranceDate,KarbarID,BookTypeID) values(@EntranceDate,@KarbarID ,@BookTypeID)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var entranceDateParameter = new SqlParameter("@EntranceDate", this.EntranceDate);
            var KarbarParameter = new SqlParameter("@UserID", this.Karbar.ID);
            var bookypeParameter = new SqlParameter("@BookTypeID", this.BookType.ID);
           
            parametersList.Add(entranceDateParameter);
            parametersList.Add(KarbarParameter);
            parametersList.Add(bookypeParameter);
            
            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public List<Date> Read()
        {
            string command = "Select * from Date";
            var db = new DataAccess.DataBaseManager();
            var result = db.GetData(command);

            var karbarList = new Karbar().Read();
            var booktyoelist = new BookType().Read();

            List<Date> lstResult = new List<Date>();
            foreach (DataRow r in result.Rows)
            {
                Date date = new Date();
                date.ID = Convert.ToInt32(r["ID"]);
                date.EntranceDate = Convert.ToDateTime(r["EntranceDate"]);
               
                //User
              Karbar karbar= new Karbar();
                var karbarID = Convert.ToInt64(r["KarbarId"]);
                date.Karbar = karbarList.FirstOrDefault(a => a.ID == karbarID);

                //CarType
               BookType bookType = new BookType();
                var BookTypeID = Convert.ToInt64(r[" BookTypeID"]);
                date.BookType= booktyoelist.FirstOrDefault(a => a.ID == BookTypeID);

                lstResult.Add(date);
            }

            return lstResult;
        }
        #endregion
        #region Methods

        #endregion
    }
}
