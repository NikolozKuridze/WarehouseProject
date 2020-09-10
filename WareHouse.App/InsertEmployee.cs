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
    public partial class InsertEmployee : Form
    {
        public InsertEmployee()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeesRepository employees = new EmployeesRepository();
            try
            {
                employees.Insert(
                  new SqlParameter("FirstName", txtFirstname.Text) { SqlDbType = SqlDbType.NVarChar },
                  new SqlParameter("LastName", txtLastname.Text) { SqlDbType = SqlDbType.NVarChar },
                  new SqlParameter("Phone", txtPhone.Text) { SqlDbType= SqlDbType.NVarChar}
                );
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
