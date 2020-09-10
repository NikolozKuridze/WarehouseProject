using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using WareHouse.Repository;
using System.Windows.Forms;

namespace WareHouse.App.Dialogs
{
    [System.ComponentModel.DesignerCategory("")]
    public class Dummy { }

    public abstract class BaseDetailForm<TRepository> : Form where TRepository : BaseRepository, new()
    {
        protected TRepository _repository;

        public int RecordID { get; internal set; }

        public bool IsEditMode => RecordID != 0;

        internal virtual void SaveData()
        {
            if (IsEditMode)
            {
                _repository.Update(GetParameters(ActionType.Update));
            }
            else
            {
                _repository.Insert(GetParameters(ActionType.Insert));
            }
        }

        protected virtual SqlParameter[] GetParameters(ActionType action)
        {
            var parameters = new List<SqlParameter>();

            return parameters.ToArray();
        }

        protected abstract void LoadData();
        protected abstract bool ValidateData();
    }
    public enum ActionType
    {
        Insert,
        Update,
    }
}
