using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoCar.Winform.Forms;

namespace SoCar.Winform
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        bool IsDone = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtpsw_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                txtName.Select();
                return;
            }
            if (txtpsw.Text == string.Empty)
            {
                txtpsw.Select();
                return;
            }
            IsDone = txtName.Text != "" && txtName.Text == "hussain" &&
                txtpsw.Text != "" && txtpsw.Text == "123" ? true : false;
            if (IsDone)
            {
                XtraMessageBox.Show("Error in your information", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Hide();

            MainForm mainform1 = new MainForm();
            mainform1.Show();
            
        }

        public static new bool IsActive()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            return login.IsDone ? true : false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            IsDone = false;
            Close();
        }


    }
}