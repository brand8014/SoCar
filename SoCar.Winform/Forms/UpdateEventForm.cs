using SoCar.Data;
using SoCar.Winform.BaseForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform.Forms
{
    public partial class UpdateEventForm : ChildRootForm
    {
        private readonly Event _event;
        public UpdateEventForm()
        {
            InitializeComponent();
        }
        public UpdateEventForm(Event @event) : this()
        {
            _event = @event;
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(2);
            bdsRent.DataSource = DataRepository.Rent.GetAll();
        }

        private void UpdateEventForm_Load(object sender, EventArgs e)
        {
            cbbEventTypeId.SelectedValue = _event.EventTypeCode;
            cbbRentId.SelectedValue = _event.RentId;
            txeRateOfDiscount.Text = _event.RateOfDiscount.ToString();
            txePeriod.Text = _event.Period.Year.ToString() 
                + (_event.Period.Month>=10?_event.Period.Month.ToString(): "0" 
                + _event.Period.Month.ToString()) 
                + ((_event.Period.Day)>=10? _event.Period.Day.ToString() : "0"
                + _event.Period.Day.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            WriteToEntity();

            try
            {
                DataRepository.Event.Update(_event);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("수정되었습니다.");
            Close();
        }

        private void WriteToEntity()
        {
            _event.Period = DateTime.ParseExact(txePeriod.Text, "yyyyMMdd", null);
            _event.RateOfDiscount = int.Parse( txeRateOfDiscount.Text);
            _event.EventTypeCode = (int)cbbEventTypeId.SelectedValue;
            _event.RentId = (int)cbbRentId.SelectedValue;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeRateOfDiscount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeRateOfDiscount);
        }

        private void txePeriod_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.DateConstraint(txePeriod);
        }
    }
}
