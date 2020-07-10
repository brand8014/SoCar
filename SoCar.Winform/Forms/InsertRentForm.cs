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
        public InsertRentForm()
        {
            InitializeComponent();
            
        }
        private void InsertRentForm_Load(object sender, EventArgs e)
        {
            bdsLocation.DataSource = DataRepository.Location.GetAllWithProperties();
            enableIndex = 1;
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
            EnableByIndex(enableIndex);
        }

        private void EnableByIndex(int enableIndex)
        {
            for (int i = 0; i <= enableIndex; i++)
            {
                lookUpEdits[i].Enabled = true;
            }  
        }

        private void lueAddress_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex++;
            EnableByIndex(enableIndex);
            bdsCar.DataSource = DataRepository.Car.Search(null, null, (int)lueAddress.EditValue, true);
        }

        private void lueCar_EditValueChanged(object sender, EventArgs e)
        {
            enableIndex++;
            EnableByIndex(enableIndex);
            
        }

        private void lueCompany_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueGoods_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueEvent_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
