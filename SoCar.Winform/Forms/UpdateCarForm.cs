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
    public partial class UpdateCarForm : ChildRootForm
    {
        private readonly Car _car;
        public UpdateCarForm()
        {
            InitializeComponent();
        }
        public UpdateCarForm(Car car) : this()
        {
            _car = car;
            bdsCarType.DataSource = DataRepository.CarType.GetAll();
            bdsLocation.DataSource = DataRepository.Location.GetLocationFullName();

            txePrice.Text = car.Price.ToString();
            txeNumber.Text = car.Number;
            
            cbbLocationId.Text = car.LocationId.ToString();
            cbbCarType.Text = car.CarTypeId.ToString();
            txeAccident.Text = car.Accident.ToString();
            txeMilage.Text = car.Mileage.ToString();
            cbbIsRent.Text = car.IsRent.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txePrice.Text=="")
            {
                MessageBox.Show("가격을 입력하세요");
                return;
            }
            if(txeNumber.Text=="")
            {
                MessageBox.Show("차번호를 입력하세요");
                return;
            }
            if(txeMilage.Text=="")
            {
                MessageBox.Show("주행거리를 입력하세요");
                return;
            }
            if(txeAccident.Text=="")
            {
                MessageBox.Show("사고횟수를 입력하세요");
            }
            WriteToEntity();
            try
            {
                DataRepository.Car.Update(_car);
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
            _car.Price = int.Parse(txePrice.Text);
            _car.Number = txeNumber.Text.Replace(" ","");
            _car.LocationId = int.Parse(cbbLocationId.SelectedValue.ToString());
            _car.CarTypeId = int.Parse(cbbCarType.SelectedValue.ToString());
            _car.Accident = int.Parse(txeAccident.Text);
            _car.Mileage = int.Parse(txeMilage.Text);
            _car.IsRent = cbbIsRent.Text == "True" ? true : false;

        }

        private void txePrice_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txePrice);
        }

        private void txeMilage_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeMilage);
        }

        private void txeAccident_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeAccident);
        }
    }
}
