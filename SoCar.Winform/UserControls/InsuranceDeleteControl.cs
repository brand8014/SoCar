using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoCar.Data;


namespace SoCar.Winform.UserControls
{
    public partial class InsuranceDeleteControl : UserControl
    {
        public InsuranceDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            //CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OnInsuranceDeleteButtonClick();

        }
        #region InsuranceDeleteButtonClick event things for C# 3.0
        public event EventHandler<InsuranceDeleteButtonClickEventArgs> InsuranceDeleteButtonClick;

        protected virtual void OnInsuranceDeleteButtonClick(InsuranceDeleteButtonClickEventArgs e)
        {
            if (InsuranceDeleteButtonClick != null)
                InsuranceDeleteButtonClick(this, e);
        }

        private InsuranceDeleteButtonClickEventArgs OnInsuranceDeleteButtonClick()
        {
            InsuranceDeleteButtonClickEventArgs args = new InsuranceDeleteButtonClickEventArgs();
            OnInsuranceDeleteButtonClick(args);

            return args;
        }

        /*private InsuranceDeleteButtonClickEventArgs OnInsuranceDeleteButtonClickForOut()
        {
            InsuranceDeleteButtonClickEventArgs args = new InsuranceDeleteButtonClickEventArgs();
            OnInsuranceDeleteButtonClick(args);

            return args;
        }*/

        public class InsuranceDeleteButtonClickEventArgs : EventArgs
        {


            /*public InsuranceDeleteButtonClickEventArgs()
            {
            }

            public InsuranceDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}