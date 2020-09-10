using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.App.Dialogs;
using WareHouse.Repository;

namespace WareHouse.App
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btnInsertcategory_Click(object sender, EventArgs e)
    {
      CategoryDetailsForm form = new CategoryDetailsForm(101);
      if (form.ShowDialog() == DialogResult.OK)
      {
        //DialogResult = DialogResult.OK;
      }
    }
    
    private void btnInsertproduct_Click(object sender, EventArgs e)
    {

    }

     private void btnInsertEmployees_Click(object sender, EventArgs e)
     {
            EmployeeDetailsForm form = new EmployeeDetailsForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }

    }
}
