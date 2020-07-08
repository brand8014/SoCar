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
    public partial class EventSearchControl : UserControl
    {
        public EventSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? codeId = null;
            try
            {
                codeId = (int)cbbCodeId.SelectedValue;
            }
            //catch (InvalidCastException e)
            //{ e.
            //}
            catch //(Exception)<--가장큰 익셉션이라 맨밑에 둬야함
            {
                //int? artistId = null;
            }
            finally
            {
                if (codeId == null || codeId.Value < 1)
                    codeId = null;
            }

            int? rentId = null;
            try
            {
                rentId = (int)cbbRentId.SelectedValue;
            }
            //catch (InvalidCastException e)
            //{ e.
            //}
            catch //(Exception)<--가장큰 익셉션이라 맨밑에 둬야함
            {
                //int? artistId = null;
            }
            finally
            {
                if (rentId == null || rentId.Value < 1)
                    rentId = null;
            }

            DateTime? period = null;
            try
            {
                period = DateTime.ParseExact(txbPeriod.Text,"yyyyMMdd",null);
            }
            //catch (InvalidCastException e)
            //{ e.
            //}
            catch //(Exception)<--가장큰 익셉션이라 맨밑에 둬야함
            {
                //int? artistId = null;
            }
            finally
            {
                if (period == null)
                    period = null;
            }

            OnSearchButtonClicked(codeId,rentId,period);
            Cursor = Cursors.Arrow;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCodeId.SelectedItem = null;
            cbbRentId.SelectedItem = null;
            txbPeriod.Text = null;
        }

        private void EventSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            bdsCord.DataSource = DataRepository.Code.GetByCodeCategoryId(2);
            bdsEvent.DataSource = DataRepository.Event.GetAll();
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? codeId, int? rentId, DateTime? period)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(codeId, rentId, period);
            OnSearchButtonClicked(args);

            return args;
        }

        private SearchButtonClickedEventArgs OnSearchButtonClickedForOut()
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs();
            OnSearchButtonClicked(args);

            return args;
        }

        public class SearchButtonClickedEventArgs : EventArgs
        {
            public int? CodeId { get; set; }
            public int? RentId { get; set; }
            public DateTime? Period { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? codeId, int? rentId, DateTime? period)
            {
                CodeId = codeId;
                RentId = rentId;
                Period = period;
            }
        }
        #endregion
    }
}
