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
  public partial class CategoryDetailsForm : BaseDetailForm<CategoriesRepository>
    {
        //private CategoriesRepository _repository;

        //public int RecordID { get; private set; }

        //public bool IsEditMode => RecordID != 0;


    public CategoryDetailsForm()
    {
      InitializeComponent();
      _repository = new CategoriesRepository();
    }

    public CategoryDetailsForm(int recordID) : this()
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
      txtName.Text = row["Name"].ToString();
      txtDescription.Text = row["Description"].ToString();
    }

    //private void SaveData()
    //{
    //  if (IsEditMode)
    //  {
    //    _repository.Update(
    //      new SqlParameter("ID", RecordID) { SqlDbType = SqlDbType.Int },
    //      new SqlParameter("Name", txtName.Text) { SqlDbType = SqlDbType.NVarChar },
    //      new SqlParameter("Description", txtDescription.Text) { SqlDbType = SqlDbType.NVarChar }
    //    );
    //  }
    //  else
    //  {
    //    _repository.Insert(
    //      new SqlParameter("Name", txtName.Text) { SqlDbType = SqlDbType.NVarChar },
    //      new SqlParameter("Description", txtDescription.Text) { SqlDbType = SqlDbType.NVarChar }
    //    );
    //  }
    //}

    protected override bool ValidateData()
    {
      if (string.IsNullOrWhiteSpace(txtName.Text))
      {
        MessageBox.Show("Please enter name");
        txtName.Focus();
        return false;
      }
      return true;
    }
  }
}
