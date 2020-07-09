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

            int? carTypeId = null;
            try
            {
                carTypeId = (int)cbbCarType.SelectedValue;
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
            string number = null;

            try
            {
                number = (string)cbbNumber.Text;
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
                if (string.IsNullOrEmpty(number))
                    number = "";
            }

            int? location = null;
            try
            {
                location = (int)cbbLocation.SelectedValue;
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


            OnSearchButtonClicked(carTypeId, number, location, isRent);
            Cursor = Cursors.Arrow;
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? carTypeId, string number, int? location, bool? isRent)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(carTypeId, number, location, isRent);
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
            public int? CarTypeId { get; set; }
            public string Number { get; set; }
            public int? Location { get; set; }
            public bool? IsRent { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? carTypeId, string number, int? location, bool? isRent)
            {
                CarTypeId = carTypeId;
                Number = number;
                Location = location;
                IsRent = isRent;
            }
        }
        #endregion

        private void CarSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsCarType.DataSource = DataRepository.CarType.GetAll().Distinct();
            bdsCar.DataSource = DataRepository.Car.GetAll().Distinct();
            bdsLocation.DataSource = DataRepository.Location.GetAll().Distinct();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCarType.SelectedItem = null;
            cbbNumber.SelectedItem = null;
            cbbLocation.SelectedItem = null;
            cbbIsRent.SelectedItem = null;
        }
    }
}
