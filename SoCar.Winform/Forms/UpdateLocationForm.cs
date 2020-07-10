using SoCar.Data;
using SoCar.Winform.BaseForms;
//using SoCar.Winform.BaseForms;
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
    public partial class UpdateLocationForm : ChildRootForm
    {
        private readonly Location _location;
        private UpdateLocationForm()
        {
            InitializeComponent();
        }
        public UpdateLocationForm(Location location) : this()
        {        
            _location = location;           
        }

        public void UpdateForm_Load(object sender, EventArgs e)
        {
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            txeAddress.Text = _location.Address;
            cbbLocation.SelectedValue = _location.LocationCode;
        }


        private void WriteToEntity()
        {          
            _location.Address = txeAddress.Text;
            _location.LocationCode = (int)cbbLocation.SelectedValue;       
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            WriteToEntity();

            try
            {
                DataRepository.Location.Update(_location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
