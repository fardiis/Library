using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BuisnesLibrary.Entities
{
   public class Karbar
    {
        #region properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName
        {
            get
            {
                return Name + " " + SurName;
            }
        }
        #endregion
        #region crud
        public bool Insert()
        {
            string command = "INSERT into [Karbar]([Name],[SurName],[Username],[Password]) values(@Name,@SurName,@Username,@Password)";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var NameParameter = new SqlParameter("@[Name", this.Name);
            var SurNameParameter = new SqlParameter("@SurName", this.SurName);
            var userNameParameter = new SqlParameter("@Username", this.Username);
            var passwordParameter = new SqlParameter("@Password", this.Password);

            parametersList.Add(NameParameter);
            parametersList.Add(SurNameParameter);
            parametersList.Add(userNameParameter);
            parametersList.Add(passwordParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public bool Update()
        {
            string command = "Update [karbar] set [Name]=@Name,SurName=@SurName,[Username]=@Username,[Password]=@Password where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            parametersList.Add(new SqlParameter("@FirstName", this.Name));
            parametersList.Add(new SqlParameter("@LastName", this.SurName));
            parametersList.Add(new SqlParameter("@Username", this.Username));
            parametersList.Add(new SqlParameter("@Password", this.Password));
            parametersList.Add(new SqlParameter("@id", this.ID));

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public bool Delete()
        {
            string command = "delete from [karbar] where ID=@id";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var idParameter = new SqlParameter("@id", this.ID);
            parametersList.Add(idParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteCommand(command, parametersList);
            return result;
        }
        public List<Karbar> Read()
        {
            string command = "Select * from [karbar]";
            var db = new DataAccess.DataBaseManager();
            var result = db.GetData(command);

            List<Karbar> lstResult = new List<Karbar>();
            foreach (DataRow r in result.Rows)
            {
                Karbar karbar = new Karbar();
                karbar.ID = Convert.ToInt32(r["ID"]);
                karbar.Name = r["Name"].ToString();
                karbar.SurName = r["SurName"].ToString();
                karbar.Username = r["Username"].ToString();
                karbar.Password = r["Password"].ToString();

                lstResult.Add(karbar);
            }

            return lstResult;
        }
        public int GetCount()
        {
            string command = "select count(*) from [karbar] where [Name]=@Name";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var nameParameter = new SqlParameter("@Name", this.Name);
            parametersList.Add(nameParameter);

            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteScalar(command, parametersList);
            return result;
        }
        #endregion
        #region Methods

        public bool CheckLoginInfo()
        {
            string command = "select count(*) from [karbar] where [Username]=@username and [Password]=@password";

            List<SqlParameter> parametersList = new List<SqlParameter>();
            var usernameParameter = new SqlParameter("@username", this.Username);
            var passwordParameter = new SqlParameter("@password", this.Password);

            parametersList.Add(usernameParameter);
            parametersList.Add(passwordParameter);


            var db = new DataAccess.DataBaseManager();
            var result = db.ExecuteScalar(command, parametersList);
            if (result == 1)
                return true;
            else
                return false;
        }

        #endregion
    }
}
