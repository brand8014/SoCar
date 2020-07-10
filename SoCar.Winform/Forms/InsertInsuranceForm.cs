using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoCar.Data;
using SoCar.Winform.BaseForms;

namespace SoCar.Winform.Forms
{
    public partial class InsertInsuranceForm : ChildRootForm
    {
        private Insurance _insurance;
        public InsertInsuranceForm()
        {
            InitializeComponent();
            
            
        }
        private void InsertInsuranceForm_Load(object sender, EventArgs e)
        {
            bdsCodeForCompany.DataSource = DataRepository.Code.GetByCodeCategoryId(5);
            bdsCodeForGoods.DataSource = DataRepository.Code.GetByCodeCategoryId(6);
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _insurance = new Insurance();
            WriteToEntity();
            try
            {
                DataRepository.Insurance.Insert(_insurance);
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
            _insurance.CompanyCode = (int)cbbCompanyCode.SelectedValue;
            _insurance.GoodsCode = (int)cbbGoodsCode.SelectedValue;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
