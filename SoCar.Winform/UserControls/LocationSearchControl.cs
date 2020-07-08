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
    public partial class LocationSearchControl : UserControl
    {
        public LocationSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? locationId = null;
            try
            {
                locationId = (int)cbbAddress.SelectedValue;
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
                if (locationId == null || locationId.Value < 1)
                    locationId = null;
            }

            OnSearchButtonClicked(locationId);
            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void LocationSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            bdsLocation.DataSource = DataRepository.Location.GetAll();
        }

        private void cbbLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsLocation.DataSource = DataRepository.Location.GetByCodeCategory((int)cbbLocation.SelectedValue);

        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? locationId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(locationId);
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
            public int? LocationId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? locationId)
            {
                LocationId = locationId;
            }
        }
        #endregion
    }
}
