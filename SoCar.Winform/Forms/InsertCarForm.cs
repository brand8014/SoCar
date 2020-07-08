using DevExpress.XtraEditors;
using SoCar.Data;
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
            bdsLocation.DataSource = DataRepository.Location.GetAll();
        }




        private void btnInsert_Click(object sender, EventArgs e)
        {
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

            Close();
        }

        private void WriteToEntity()
        {
            _car.Price = int.Parse(txePrice.Text);
            _car.LocationId = (int)cbbLocation.SelectedValue;
            _car.CarTypeId = (int)cbbCarType.SelectedValue;
            _car.Number = txeCarNum.Text;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}
