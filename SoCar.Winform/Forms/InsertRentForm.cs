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
    public partial class InsertRentForm : ChildRootForm
    {
        public int enableIndex { get; set; }
        public List<LookUpEdit> lookUpEdits{ get; set; }
        public Rent _rent { get; set; }
        public InsertRentForm()
        {
            InitializeComponent();
            
        }
        private void InsertRentForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Parse(teRentAt.EditValue.ToString()).TimeOfDay.ToString());
            //MessageBox.Show(DateTime.Parse(teRentAt.EditValue.ToString()).Day.ToString());
            //MessageBox.Show((DateTime.Parse(CalanderControl.EditValue.ToString()).Date + DateTime.Parse(teRentAt.EditValue.ToString()).TimeOfDay).ToString());
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            bdsLocation.DataSource = DataRepository.Location.GetAllWithProperties();
            
            lookUpEdits = new List<LookUpEdit>();
            lookUpEdits.Add(lueLocation);
            lookUpEdits.Add(lueAddress);
            lookUpEdits.Add(lueCar);
            lookUpEdits.Add(lueCompany);
            lookUpEdits.Add(lueGoods);
            lookUpEdits.Add(lueEvent);
        }

        private void lueLocation_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex = 2;
            EnableByIndex(enableIndex);
            bdsLocation.DataSource = DataRepository.Location.Search((int)lueLocation.EditValue, null);
        }

        private void EnableByIndex(int enableIndex)
        {
            for (int i = 0; i < enableIndex; i++)
            {
                lookUpEdits[i].Enabled = true;
            }
            for (int j = enableIndex; j < lookUpEdits.Count; j++)
            {
                lookUpEdits[j].Enabled = false;
            }
            
        }

        private void lueAddress_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex = 3;
            EnableByIndex(enableIndex);
            bdsCar.DataSource = DataRepository.Car.Search(null, null, (int)lueAddress.EditValue, false);
 
        }

        private void lueCar_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex = 4;
            EnableByIndex(enableIndex);
            bdsCompany.DataSource = DataRepository.Code.GetByCodeCategoryId(5);
        }

        private void lueCompany_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex = 5;
            EnableByIndex(enableIndex);
            bdsInsurance.DataSource = DataRepository.Insurance.Search(
                (int)lueCompany.EditValue, null);
        }

        private void lueGoods_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex = 6;
            EnableByIndex(enableIndex);
            bdsEvent.DataSource = DataRepository.Code.GetByCodeCategoryId(2);
        }

        private void lueEvent_EditValueChanged(object sender, EventArgs e)
        {

        }






        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void WriteToEntity()
        {
            _rent.CarId = (int)lueCar.EditValue;
            _rent.RentAt = DateTime.Parse(CalanderControl.EditValue.ToString()).Date + DateTime.Parse(teRentAt.EditValue.ToString()).TimeOfDay;
            _rent.ReturnTime = _rent.RentAt + DateTime.Parse(tseUseTime.EditValue.ToString()).TimeOfDay;
            _rent.LocationId = (int)lueLocation.EditValue;
            _rent.CustomerId = DataRepository.Customer.GetAll().Select(x=>x.CustomerId).FirstOrDefault();
            _rent.BookAt = DateTime.Now;
            _rent.Price = DataRepository.Car.Get((int)lueCar.EditValue).Price * int.Parse(DateTime.Parse(tseUseTime.EditValue.ToString()).Hour.ToString());

               
            //_insurance.CompanyCode = (int)cbbCompanyCode.SelectedValue;
            //_insurance.GoodsCode = (int)cbbGoodsCode.SelectedValue;


        }



        private void btnInsertRent_Click(object sender, EventArgs e)
        {
            _rent = new Rent();
            WriteToEntity();
            try
            {
                DataRepository.Rent.Insert(_rent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("등록되었습니다.");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
