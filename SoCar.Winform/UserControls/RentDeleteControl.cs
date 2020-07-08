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
    public partial class RentDeleteControl : UserControl
    {
        public RentDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            //CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OnRentDeleteButtonClick();

        }
        #region RentDeleteButtonClick event things for C# 3.0
        public event EventHandler<RentDeleteButtonClickEventArgs> RentDeleteButtonClick;

        protected virtual void OnRentDeleteButtonClick(RentDeleteButtonClickEventArgs e)
        {
            if (RentDeleteButtonClick != null)
                RentDeleteButtonClick(this, e);
        }

        private RentDeleteButtonClickEventArgs OnRentDeleteButtonClick()
        {
            RentDeleteButtonClickEventArgs args = new RentDeleteButtonClickEventArgs();
            OnRentDeleteButtonClick(args);

            return args;
        }

        /*private RentDeleteButtonClickEventArgs OnRentDeleteButtonClickForOut()
        {
            RentDeleteButtonClickEventArgs args = new RentDeleteButtonClickEventArgs();
            OnRentDeleteButtonClick(args);

            return args;
        }*/

        public class RentDeleteButtonClickEventArgs : EventArgs
        {


            /*public RentDeleteButtonClickEventArgs()
            {
            }

            public RentDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}