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
using DevExpress.XtraEditors;

namespace SoCar.Winform.UserControls
{
    public partial class LocationSearchControl : XtraUserControl
    {
        public LocationSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            
            OnSearchButtonClicked((int?)lueAddress.EditValue, (int?)lueAddress.EditValue);
            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void LocationSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsAddress.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            bdsLocation.DataSource = DataRepository.Location.GetAll();
        }

        private void cbbLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsLocation.DataSource = DataRepository.Location.GetByCodeCategory((int)lueAddress.EditValue);

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
