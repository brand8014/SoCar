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
    public partial class UpdateCustomerForm : ChildRootForm
    {
        private readonly Customer _customer;
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }
        public UpdateCustomerForm(Customer customer) : this()
        {
            _customer = customer;
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(7);
        }
        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            txeName.EditValue = _customer.Name;
            txeCellNumber.EditValue = _customer.CellNumber;
            cbbLisenceCode.SelectedItem = _customer.LisenceCode.ToString();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            try
            {
                DataRepository.Customer.Update(_customer);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("test");
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void WriteToEntity()
        {
            _customer.Name = txeName.Text;
            _customer.CellNumber = txeCellNumber.Text;
            _customer.LisenceCode = (int)cbbLisenceCode.SelectedValue;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeCellNumber_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeCellNumber);
        }
    }
}
