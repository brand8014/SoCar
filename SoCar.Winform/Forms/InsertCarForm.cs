using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.XtraEditors;
using SoCar.Data;
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
    public partial class InsertCarForm : RootForm
    {
        private Car _car;
        public InsertCarForm()
        {
            InitializeComponent();
        }


        private void InsertCarForm_Load(object sender, EventArgs e)
        {
            bdsCarType.DataSource = DataRepository.CarType.GetAll();
            bdsLocation.DataSource = DataRepository.Location.GetLocationFullName();
            txeMilage.Text = "0";
            txeAccident.Text = "0";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(txePrice.Text == "")
            {
                MessageBox.Show("가격을 입력하세요.");
                return;
            }
            if(txeCarNum.Text == "")
            {
                MessageBox.Show("차 번호를 입력하세요.");
                return;
            }
            if(txeMilage.Text =="")
            {
                MessageBox.Show("주행거리를 입력하세요");
                return;
            }
            if(txeAccident.Text == "")
            {
                MessageBox.Show("사고횟수를 입력하세요");
                return;
            }

            _car = new Car();
            WriteToEntity();
            try
            {
                DataRepository.Car.Insert(_car);
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
            _car.Price = int.Parse(txePrice.Text);
            _car.LocationId = (int)cbbLocation.SelectedValue;
            _car.CarTypeId = (int)cbbCarType.SelectedValue;
            _car.Number = txeCarNum.Text.Replace(" ","");
            _car.Accident = int.Parse(txeAccident.Text);
            _car.Mileage = int.Parse(txeMilage.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
