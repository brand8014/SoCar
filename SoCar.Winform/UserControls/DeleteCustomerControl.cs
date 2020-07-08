using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform.UserControls
{
    public partial class DeleteCustomerControl : UserControl
    {
        public DeleteCustomerControl()
        {
            InitializeComponent();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            OnDeleteCustomerButtonClick();
        }
        #region DeleteCustomerButtonClick event things for C# 3.0
        public event EventHandler<DeleteCustomerButtonClickEventArgs> DeleteCustomerButtonClick;

        protected virtual void OnDeleteCustomerButtonClick(DeleteCustomerButtonClickEventArgs e)
        {
            if (DeleteCustomerButtonClick != null)
                DeleteCustomerButtonClick(this, e);
        }

        private DeleteCustomerButtonClickEventArgs OnDeleteCustomerButtonClick()
        {
            DeleteCustomerButtonClickEventArgs args = new DeleteCustomerButtonClickEventArgs();
            OnDeleteCustomerButtonClick(args);

            return args;
        }

        /*private DeleteCustomerButtonClickEventArgs OnDeleteCustomerButtonClickForOut()
        {
            DeleteCustomerButtonClickEventArgs args = new DeleteCustomerButtonClickEventArgs();
            OnDeleteCustomerButtonClick(args);

            return args;
        }*/

        public class DeleteCustomerButtonClickEventArgs : EventArgs
        {


            /*public DeleteCustomerButtonClickEventArgs()
            {
            }

            public DeleteCustomerButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}
