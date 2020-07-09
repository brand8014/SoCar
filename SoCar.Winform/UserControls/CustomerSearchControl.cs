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
    public partial class CustomerSearchControl : UserControl
    {
        public CustomerSearchControl()
        {
            InitializeComponent();
        }


        private void CustomerSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsCustomer.DataSource = DataRepository.Customer.GetAll();
            bdsLisence.DataSource = DataRepository.Code.GetByCodeCategoryId(7);

            Init();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? customerId = null;
            try
            {
                customerId = (int)cbbCustomer.SelectedValue;
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

            Cursor = Cursors.WaitCursor;

            int? age = null;
            try
            {
                age = int.Parse(txbAge.SelectedText);
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
                if (age == null || age.Value < 1)
                    age = null;
            }

            Cursor = Cursors.WaitCursor;

            string cellNumber = null;
            try
            {
                cellNumber = txbNumber.SelectedText;
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
                if (cellNumber == null)
                    cellNumber = null;
            }

            Cursor = Cursors.WaitCursor;

            int? lisenceId = null;
            try
            {
                lisenceId = (int)cbbLisence.SelectedValue;
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
                if (lisenceId == null)
                    lisenceId = null;
            }

            OnSearchButtonClicked(customerId, age, cellNumber, lisenceId);
            Cursor = Cursors.Arrow;



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
            
        }

        private void Init()
        {
            cbbCustomer.SelectedItem = null;
            cbbLisence.SelectedItem = null;
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? customerId, int? age, string cellNumber, int? lisenceId)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(customerId, age, cellNumber, lisenceId);
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
            public int? Age { get; set; }
            public string CellNumber { get; set; }
            public int? LisenceId { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? customerId, int? age, string cellNumber, int? lisenceId)
            {
                CustomerId = customerId;
                Age = age;
                CellNumber = cellNumber;
                LisenceId = lisenceId;
            }
        }
        #endregion
    }
}
