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
    public partial class InsuranceSearchControl : UserControl
    {
        public InsuranceSearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            int? insuranceId = null;
            try
            {
                insuranceId = (int)cbbInsuranceId.SelectedValue;
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
                if (insuranceId == null || insuranceId.Value < 1)
                    insuranceId = null;
            }

            string company = null;
            try
            {
                company = (string)cbbCompany.SelectedValue;
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
                if (string.IsNullOrEmpty(company))
                    company = null;
            }

            string goods = null;
            try
            {
                goods = (string)cbbGoods.SelectedValue;
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
                if (string.IsNullOrEmpty(goods))
                    goods = null;
            }
            OnSearchButtonClicked(insuranceId, company, goods);
            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbInsuranceId.SelectedItem = null;
            cbbCompany.SelectedItem = null;
            cbbGoods.SelectedItem = null;
        }

        private void InsuranceSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsInsurance.DataSource = DataRepository.Insurance.GetAll();
        }

        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? insuranceId, string company, string goods)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(insuranceId, company, goods);
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
            public int? InsuranceId { get; set; }
            public string Company { get; set; }
            public string Goods { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? insuranceId, string company, string goods)
            {
                InsuranceId = insuranceId;
                Company = company;
                Goods = goods;
            }
        }
        #endregion
    }
}
