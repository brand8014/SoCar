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


    }
}
