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
    public partial class EventDeleteControl : UserControl
    {
        public EventDeleteControl()
        {
            InitializeComponent();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            //CustomerId.EditValue = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            OnEventDeleteButtonClick();

        }
        #region EventDeleteButtonClick event things for C# 3.0
        public event EventHandler<EventDeleteButtonClickEventArgs> EventDeleteButtonClick;

        protected virtual void OnEventDeleteButtonClick(EventDeleteButtonClickEventArgs e)
        {
            if (EventDeleteButtonClick != null)
                EventDeleteButtonClick(this, e);
        }

        private EventDeleteButtonClickEventArgs OnEventDeleteButtonClick()
        {
            EventDeleteButtonClickEventArgs args = new EventDeleteButtonClickEventArgs();
            OnEventDeleteButtonClick(args);

            return args;
        }

        /*private EventDeleteButtonClickEventArgs OnEventDeleteButtonClickForOut()
        {
            EventDeleteButtonClickEventArgs args = new EventDeleteButtonClickEventArgs();
            OnEventDeleteButtonClick(args);

            return args;
        }*/

        public class EventDeleteButtonClickEventArgs : EventArgs
        {


            /*public EventDeleteButtonClickEventArgs()
            {
            }

            public EventDeleteButtonClickEventArgs()
            {

            }*/
        }
        #endregion
    }
}