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

            int? codeId = null;
            try
            {
                codeId = int.Parse(lueLocation.SelectedText);
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

            int? locationId = null;
            try
            {
                locationId = int.Parse(lueAddress.SelectedText);
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

            OnSearchButtonClicked(codeId,locationId);
            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void LocationSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsLocation.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            bdsAddress.DataSource = DataRepository.Location.GetAll();
        }

        private void cbbLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            
            int? a = int.Parse(lueLocation.SelectedText);
            bdsLocation.DataSource = DataRepository.Location.GetByCodeCategory(a);
            
        }
        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? codeId, int? locationId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(codeId, locationId);
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
            public int? LocationId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? codeId, int? locationId)
            {
                CodeId = codeId;
                LocationId = locationId;
            }
        }
        #endregion
    }
}
