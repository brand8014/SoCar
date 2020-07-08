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
    public partial class CustomerDeleteControl : UserControl
    {
        public CustomerDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            // CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OnCustomerDeleteButtonClick();

        }
        #region CustomerDeleteButtonClick event things for C# 3.0
        public event EventHandler<CustomerDeleteButtonClickEventArgs> CustomerDeleteButtonClick;

        protected virtual void OnCustomerDeleteButtonClick(CustomerDeleteButtonClickEventArgs e)
        {
            if (CustomerDeleteButtonClick != null)
                CustomerDeleteButtonClick(this, e);
        }

        private CustomerDeleteButtonClickEventArgs OnCustomerDeleteButtonClick()
        {
            CustomerDeleteButtonClickEventArgs args = new CustomerDeleteButtonClickEventArgs();
            OnCustomerDeleteButtonClick(args);

            return args;
        }

        /*private CustomerDeleteButtonClickEventArgs OnCustomerDeleteButtonClickForOut()
        {
            CustomerDeleteButtonClickEventArgs args = new CustomerDeleteButtonClickEventArgs();
            OnCustomerDeleteButtonClick(args);

            return args;
        }*/

        public class CustomerDeleteButtonClickEventArgs : EventArgs
        {


            /*public CustomerDeleteButtonClickEventArgs()
            {
            }

            public CustomerDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}