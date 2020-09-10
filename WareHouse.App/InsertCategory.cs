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
using System.Data.SqlClient;
namespace WareHouse.App
{
  public partial class InsertCategory : Form
  {
    public InsertCategory()
    {
      InitializeComponent();
    }

    private void AddCategory_Load(object sender, EventArgs e)
    {

    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      CategoriesRepository categories = new CategoriesRepository();
      try
      {
        categories.Insert(
          new SqlParameter("Name", txtName.Text) { SqlDbType = SqlDbType.NVarChar },
          new SqlParameter("Description", txtDecription.Text) { SqlDbType = SqlDbType.NVarChar }
        );
        DialogResult = DialogResult.OK;
      }
      catch(Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
