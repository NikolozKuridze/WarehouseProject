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
    public partial class InsertProducts : Form
    {
        public InsertProducts()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ProductsRepository pr = new ProductsRepository();
            if (pr.Insert(new SqlParameter("Name", txtName.Text) { SqlDbType = SqlDbType.NVarChar },
                new SqlParameter("Description", txtDescription.Text) { SqlDbType = SqlDbType.NVarChar }) == 1){
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Such product already exists");
            }
        }
    }
}
