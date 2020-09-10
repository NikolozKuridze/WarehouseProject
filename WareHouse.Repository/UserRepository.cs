using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DatabaseHelper;

namespace WareHouse.Repository
{
    public class UserRepository : BaseRepository
    {
        public static int? LoggedUserID { get; internal set; }

        public bool Login(string username, string password)
        {
            var userId = new SqlParameter("UserID", SqlDbType.Int) { Direction = ParameterDirection.Output };
            _database.ExecuteNonQuery("LoginUser", CommandType.StoredProcedure,
              new SqlParameter("UserName", username) { SqlDbType = SqlDbType.NVarChar },
              new SqlParameter("Password", password) { SqlDbType = SqlDbType.NVarChar },
              userId
            );

            if ((int)userId.Value != -1)
            {
                LoggedUserID = (int)userId.Value;
                return true;
            }
            LoggedUserID = null;
            return false;
        }
    } 
}
