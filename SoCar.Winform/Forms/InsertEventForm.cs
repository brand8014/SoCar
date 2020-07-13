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
            if(txePeriod.Text == "")
            {
                MessageBox.Show("기간을 입력하세요");
                return;
            }
            if (txeRateOfDiscount.Text == "")
            {
                MessageBox.Show("할인율을 입력하세요");
                return;
            }
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
            MessageBox.Show("등록되었습니다.");
        }


        private void WriteToEntity()
        {
            _event.EventTypeCode = (int)cbbEventTypeCode.SelectedValue;
            _event.RateOfDiscount = int.Parse(txeRateOfDiscount.Text);
            _event.Period = DateTime.ParseExact(txePeriod.Text, "yyyyMMdd", null);



        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txeRateOfDiscount_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            Helpers.InputConstraint.OnlyIntConstraint(txeRateOfDiscount);
        }

        private void txePeriod_Leave(object sender, EventArgs e)
        {
            Helpers.InputConstraint.DateConstraint(txePeriod);
        }
    }
}
