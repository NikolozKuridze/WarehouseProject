using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Repository;
using DatabaseHelper;
using System.Data.SqlClient;

namespace WareHouse.App.Dialogs
{
    public partial class EmployeeDetailsForm : BaseDetailForm<EmployeesRepository>
    {
        //private EmployeesRepository _repository;

        //public int RecordID { get; private set; }

        //public bool IsEditMode => RecordID != 0;

        public EmployeeDetailsForm()
        {
            InitializeComponent();
            _repository = new EmployeesRepository();
        }

        public EmployeeDetailsForm(int recordID) : this()
        {
            RecordID = recordID;
            LoadData();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveData();
                DialogResult = DialogResult.OK;
            }
        }

        protected override void LoadData()
        {
            var row = _repository.Get(RecordID);
            txtfirstname.Text = row["FirstName"].ToString();
            txtlastname.Text = row["LastName"].ToString();
            txtphone.Text = row["Phone"].ToString();
        }

        //protected void SaveData()
        //{
        //    if (IsEditMode)
        //    {
        //        _repository.Update(
        //          new SqlParameter("ID", RecordID) { SqlDbType = SqlDbType.Int },
        //          new SqlParameter("Name", txtfirstname.Text) { SqlDbType = SqlDbType.NVarChar },
        //          new SqlParameter("Description", txtlastname.Text) { SqlDbType = SqlDbType.NVarChar },
        //          new SqlParameter("Phone", txtphone.Text) { SqlDbType = SqlDbType.NVarChar}
        //        );
        //    }
        //    else
        //    {
        //        _repository.Insert(
        //          new SqlParameter("Name", txtfirstname.Text) { SqlDbType = SqlDbType.NVarChar },
        //          new SqlParameter("Description", txtlastname.Text) { SqlDbType = SqlDbType.NVarChar },
        //          new SqlParameter("Phone", txtphone.Text) { SqlDbType = SqlDbType.NVarChar }
        //        );
        //    }
        //}

        protected override bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtfirstname.Text))
            {
                MessageBox.Show("Please enter name");
                txtfirstname.Focus();
                return false;
            }
            return true;
        }
    }
}
