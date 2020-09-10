using DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WareHouse.Repository
{
  public abstract class BaseRepository
  {
    protected readonly Database _database;

    public BaseRepository()
    {
      _database = new Database();
    }

    public virtual string ObjectName => this.GetType().Name.Replace("Repository", "");

    public virtual string InsertProcedureName => $"Insert{ObjectName}";
    public virtual string UpdateProcedureName => $"Update{ObjectName}";
    public virtual string DeleteProcedureName => $"Delete{ObjectName}";

    protected int ExecuteAction(string commandText, params SqlParameter[] parameters)
    {
      return _database.ExecuteNonQuery(commandText, CommandType.StoredProcedure, parameters);
    }

    public virtual DataRow Get(int id)
    {
      var table = _database.GetTable($"select * from {ObjectName} where ID = @ID", new SqlParameter("ID", id));
      return table.Rows.Count > 0 ? table.Rows[0] : null;
    }

    public virtual int Insert(params SqlParameter[] parameters)
    {
      return ExecuteAction(InsertProcedureName, parameters);
    }

    public virtual int Update(params SqlParameter[] parameters)
    {
      return ExecuteAction(UpdateProcedureName, parameters);
    }

    public virtual int Delete(params SqlParameter[] parameters)
    {
      return ExecuteAction(DeleteProcedureName, parameters);
    }
  }
}
