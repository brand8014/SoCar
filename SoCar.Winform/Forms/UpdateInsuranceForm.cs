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
            bdsCodeForCompany.DataSource = DataRepository.Code.GetByCodeCategoryId(5);
            lueCompanyCode.Text = Convert.ToString(_insurance.CompanyCode);
            txeGoods.Text = Convert.ToString(_insurance.GoodsCode);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txeGoods.Text == "")
            {
                MessageBox.Show("보험상품을 입력하세요");
                return;
            }
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
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void WriteToEntity()
        {
            _insurance.CompanyCode = int.Parse(lueCompanyCode.Text);
            _insurance.GoodsCode = int.Parse(txeGoods.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
