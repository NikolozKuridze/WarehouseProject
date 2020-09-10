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

namespace WareHouse.App
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
#if DEBUG
      txtUsername.Text = "User2";
      txtPassword.Text = "Paswword2";
#endif
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      UserRepository user = new UserRepository();
      if (user.Login(txtUsername.Text, txtPassword.Text))
        DialogResult = DialogResult.OK;
      else
        MessageBox.Show("Login Failed");
    }
  }
}
