using DevExpress.XtraEditors.Filtering;
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
    public partial class InsertLocationForm : ChildRootForm
    {
        private  Location _location;
        public InsertLocationForm()
        {
            InitializeComponent();
        }

        private void InsertLocationForm_Load(object sender, EventArgs e)
        {
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
        }

        private void btnInsertLocation_Click(object sender, EventArgs e)
        {
            _location = new Location();
            WriteToEntity();
            try
            {
                DataRepository.Location.Insert(_location);
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
            _location.Address = txeAddress.Text.Replace(" ","");
            _location.LocationCode = (int)cbbLocation.SelectedValue;
        }

        //private void ReadFromEntity()
        //{
        //    txbAddress.EditValue = _location.Address.ToString();
        //    cbbLocation.SelectedValue = _location.LocationCode;
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
