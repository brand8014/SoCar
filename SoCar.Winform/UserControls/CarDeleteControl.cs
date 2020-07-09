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
    public partial class CarDeleteControl : UserControl
    {
        public CarDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            //CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            OnCarDeleteButtonClick();
        }
        #region CarDeleteButtonClick event things for C# 3.0
        public event EventHandler<CarDeleteButtonClickEventArgs> CarDeleteButtonClick;

        protected virtual void OnCarDeleteButtonClick(CarDeleteButtonClickEventArgs e)
        {
            if (CarDeleteButtonClick != null)
                CarDeleteButtonClick(this, e);
        }

        private CarDeleteButtonClickEventArgs OnCarDeleteButtonClick()
        {
            CarDeleteButtonClickEventArgs args = new CarDeleteButtonClickEventArgs();
            OnCarDeleteButtonClick(args);

            return args;
        }

        /*private CarDeleteButtonClickEventArgs OnCarDeleteButtonClickForOut()
        {
            CarDeleteButtonClickEventArgs args = new CarDeleteButtonClickEventArgs();
            OnCarDeleteButtonClick(args);

            return args;
        }*/

        public class CarDeleteButtonClickEventArgs : EventArgs
        {


            /*public CarDeleteButtonClickEventArgs()
            {
            }

            public CarDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}