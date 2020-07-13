using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using SoCar.Data;
using SoCar.Winform.BaseForms;

namespace SoCar.Winform.Forms
{
    public partial class InsertCustomerForm : ChildRootForm
    {
        private Customer _customer;
        public InsertCustomerForm()
        {
            InitializeComponent();
        }


        private void InsertCustomerForm_Load(object sender, EventArgs e)
        {
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(7);
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txeName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요");
                return;
            }
            if(txeCellNumber.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
                return;
            }
            if (txeBirth.Text == "")
            {
                MessageBox.Show("생년월일을 입력하세요.");
                return;
            }

            _customer = new Customer();
            WriteToEntity();
            try
            {
                DataRepository.Customer.Insert(_customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("등록되었습니다.");
            Close();
        }

        private void WriteToEntity()
        {
            _customer.Name = txeName.Text;
            _customer.CellNumber = txeCellNumber.Text;
            _customer.Age = int.Parse(txeAge.Text);
            _customer.Birthday = DateTime.ParseExact(txeBirth.Text, "yyyyMMdd", null);
            _customer.LisenceCode = (int)cbbLicense.SelectedValue;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeCellNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeCellNumber);
        }

        private void txeBirth_Leave(object sender, EventArgs e)
        {         
            txeAge.Text = Helpers.InputConstraint.DateConstraintAndCalculateAge(txeBirth);

        }

        private void txeBirth_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            
        }

        private void txeBirth_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeBirth);

        }
    }
}
