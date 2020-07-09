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
    public partial class RentSearchControl : UserControl
    {
        public RentSearchControl()
        {
            InitializeComponent();
        }

        private void RentSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            
            bdsCustomer.DataSource = DataRepository.Customer.GetAll();
            bdsLocation.DataSource = DataRepository.Location.GetAll();
            bdsCar.DataSource = DataRepository.Car.GetAll();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? customerId = null;
            try
            {
                customerId = (int)cbbCustomerId.SelectedValue;
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
                if (customerId == null || customerId.Value < 1)
                    customerId = null;
            }

            int? locationId = null;
            try
            {
                locationId = (int)cbbLocationId.SelectedValue;
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

            int? carId = null;
            try
            {
                carId = (int)cbbCarTypeId.SelectedValue;
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

            DateTime? rentDay = null;
            try
            {
                rentDay = DateTime.ParseExact(txbRentDay.Text, "yyyyMMdd", null);
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
                if (rentDay == null)
                    rentDay = null;
            }


            DateTime? returnDay = null;

            try
            {
                returnDay = DateTime.ParseExact(txbReturnDay.Text, "yyyyMMdd", null);
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
                if (returnDay == null)
                    returnDay = null;
            }

            int? price = null;

            try
            {
                price = int.Parse(txbPrice.Text);
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
                if (price == null)
                    price = null;
            }
            OnSearchButtonClicked(customerId, locationId, carId, rentDay, returnDay);

            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCarTypeId.SelectedItem = null;
            cbbCustomerId.SelectedItem = null;
            cbbLocationId.SelectedItem = null;
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? customerId, int? locationId, int? carId, DateTime? rentDay, DateTime? returnDay)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(customerId, locationId, carId, rentDay, returnDay);
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
            public int? CustomerId { get; set; }
            public int? LocationId { get; set; }
            public int? CarId { get; set; }
            public DateTime? RentDay { get; set; }
            public DateTime? ReturnDay { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? customerId, int? locationId, int? carId, DateTime? rentDay, DateTime? returnDay)
            {
                CustomerId = customerId;
                LocationId = locationId;
                CarId = carId;
                RentDay = rentDay;
                ReturnDay = returnDay;
            }
        }
        #endregion
    }
}
