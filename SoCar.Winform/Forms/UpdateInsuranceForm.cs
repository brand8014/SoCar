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
    public partial class UpdateInsuranceForm : ChildRootForm
    {
        private readonly Insurance _insurance;
        public UpdateInsuranceForm()
        {
            InitializeComponent();
        }
        public UpdateInsuranceForm(Insurance insurance) : this()
        {
            _insurance = insurance;
        }

        private void UpdateInsuranceForm_Load(object sender, EventArgs e)
        {
            txeCompany.Text = _insurance.Company;
            txeGoods.Text = _insurance.Goods;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            try
            {
                DataRepository.Insurance.Update(_insurance);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("test");
                MessageBox.Show(ex.Message);
            }

            Close();
        }

        private void WriteToEntity()
        {
            _insurance.Company = txeCompany.Text;
            _insurance.Goods = txeGoods.Text;
        }
    }
}
