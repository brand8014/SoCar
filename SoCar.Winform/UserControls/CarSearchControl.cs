using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SoCar.Data;

namespace SoCar.Winform.UserControls
{
    public partial class CarSearchControl : XtraUserControl
    {
        public CarSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            

            int? carId = null;

            try
            {
                carId = (int?)cbbNumber.SelectedValue;
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
                if (carId == null || carId.Value < 1)
                    carId = null;
            }

            int? carTypeId = null;
            try
            {
                carTypeId = (int?)cbbCarType.SelectedValue;
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
                if (carTypeId == null || carTypeId.Value < 1)
                    carTypeId = null;
            }

            int? location = null;
            try
            {
                location = (int?)cbbLocation.SelectedValue;
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
                if (location == null || location.Value < 1)
                    location = null;
            }

            bool? isRent = null;
            try
            {
                if ((string)cbbIsRent.SelectedItem == "true")
                    isRent = true;
                else if ((string)cbbIsRent.SelectedItem == "false")
                    isRent = false;
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
                if (isRent == null)
                    isRent = null;
            }


            OnSearchButtonClicked(carId, carTypeId, location, isRent);
            Cursor = Cursors.Arrow;
        }

        private void CarSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsCarType.DataSource = DataRepository.CarType.GetAll();
            bdsCar.DataSource = DataRepository.Car.GetAll();
            bdsLocation.DataSource = DataRepository.Location.GetAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCarType.SelectedItem = null;
            cbbNumber.SelectedItem = null;
            cbbLocation.SelectedItem = null;
            cbbIsRent.SelectedItem = null;
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? carId, int? carTypeId, int? locationId, bool? isRent)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(carId, carTypeId, locationId, isRent);
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
            public int? CarId { get; set; }
            public int? CarTypeId { get; set; }
            public int? LocationId { get; set; }
            public bool? IsRent { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? carId, int? carTypeId, int? locationId, bool? isRent)
            {
                CarId = carId;
                CarTypeId = carTypeId;
                LocationId = locationId;
                IsRent = isRent;
            }
        }
        #endregion
    }
}
