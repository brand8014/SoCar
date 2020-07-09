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

    public partial class InsertEventForm : ChildRootForm
    {
        private Event _event;
        public InsertEventForm()
        {
            InitializeComponent();
            _event = new Event();

        }


        private void InsertEventForm_Load(object sender, EventArgs e)
        {
            bdsEventTypeCode.DataSource = DataRepository.Event.GetAll();
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(2);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            WriteToEntity();
            try
            {
                DataRepository.Event.Insert(_event);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Close();
        }


        private void WriteToEntity()
        {
            _event.EventTypeCode = (int)cbbEventTypeCode.SelectedValue;
            _event.RentId = (int)cbbCustomer.SelectedValue;
            _event.RateOfDiscount = int.Parse(txeRateOfDiscount.Text);
            _event.Period = DateTime.ParseExact(txePeriod.Text, "yyyyMMdd", null);



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
