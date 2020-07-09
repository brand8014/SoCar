using DevExpress.XtraEditors;
using SoCar.Data;
using SoCar.Winform.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform.Forms
{
    public partial class LoginForm : XtraForm
    {

        bool IsDone = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txbPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<Login> items = DataRepository.Login.GetAll();

            //로그인 성공시
            if (items.Any(x => x.UserName == txbName.Text && x.Password == txbPW.Text))
            {
               
                
                MainForm mainform1 = new MainForm();
               
                mainform1.Show();

                Close();
                
            }

            //로그인 실패시
            else
                MessageBox.Show("※ 아이디와 비밀번호를 확인해주세요 ※");
        }

        public static new bool IsActive()
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            return login.IsDone ? true : false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            IsDone = false;
            Close();
        }
    }
}
