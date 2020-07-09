using DevExpress.XtraEditors;
using SoCar.Data;
using SoCar.Winform.BaseForms;
using SoCar.Winform.Helpers;
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
    public partial class LoginForm : RootForm
    {

       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txbPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txbName.Text = Properties.Settings.Default.LoginIdSave;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Login login = DataRepository.Login.Get(txbName.Text, txbPW.Text);
            //로그인 성공시
            if (login != null)
            {
                LoginProxy.Login = login;

                MainForm mainform1 = new MainForm();

                if (chkrememberLoginName.Checked)
                {
                    // 로그인 OK 버튼 실행할 때 저장
                    Properties.Settings.Default.LoginIdSave = txbName.Text;
                    Properties.Settings.Default.Save();
                }

                //this.Visible = false;
                mainform1.Show();
                
                //close();
            }

            //로그인 실패시
            else
            {
                MessageBox.Show("※ 아이디와 비밀번호를 확인해주세요 ※");
                
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        
        
    }
}
