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
    public partial class LocationDeleteControl : UserControl
    {
        public LocationDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            // CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OnLocationDeleteButtonClick();

        }
        #region LocationDeleteButtonClick event things for C# 3.0
        public event EventHandler<LocationDeleteButtonClickEventArgs> LocationDeleteButtonClick;

        protected virtual void OnLocationDeleteButtonClick(LocationDeleteButtonClickEventArgs e)
        {
            if (LocationDeleteButtonClick != null)
                LocationDeleteButtonClick(this, e);
        }

        private LocationDeleteButtonClickEventArgs OnLocationDeleteButtonClick()
        {
            LocationDeleteButtonClickEventArgs args = new LocationDeleteButtonClickEventArgs();
            OnLocationDeleteButtonClick(args);

            return args;
        }

        /*private LocationDeleteButtonClickEventArgs OnLocationDeleteButtonClickForOut()
        {
            LocationDeleteButtonClickEventArgs args = new LocationDeleteButtonClickEventArgs();
            OnLocationDeleteButtonClick(args);

            return args;
        }*/

        public class LocationDeleteButtonClickEventArgs : EventArgs
        {


            /*public LocationDeleteButtonClickEventArgs()
            {
            }

            public LocationDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}