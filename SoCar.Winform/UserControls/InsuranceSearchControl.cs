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


            int? companyCode = null;
            try
            {
                companyCode = (int)cbbCompany.SelectedValue;
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
                if (companyCode == null || companyCode.Value < 1)
                    companyCode = null;
            }

            int? goodsCode = null;
            try
            {
                goodsCode = int.Parse(cbbGoods.Text);
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
                if (goodsCode == null || goodsCode.Value < 1)
                    goodsCode = null;
            }
            OnSearchButtonClicked(companyCode, goodsCode);
            Cursor = Cursors.Arrow;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbbCompany.SelectedItem = null;
            cbbGoods.SelectedItem = null;
        }

        private void InsuranceSearchControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            bdsInsurance.DataSource = DataRepository.Insurance.GetWithoutRedundancy();
        }


        #region SearchButtonClicked event things for C# 3.0
        public event EventHandler<SearchButtonClickedEventArgs> SearchButtonClicked;

        protected virtual void OnSearchButtonClicked(SearchButtonClickedEventArgs e)
        {
            if (SearchButtonClicked != null)
                SearchButtonClicked(this, e);
        }

        private SearchButtonClickedEventArgs OnSearchButtonClicked(int? companyCode, int? goodsCode)
        {
            SearchButtonClickedEventArgs args = new SearchButtonClickedEventArgs(companyCode, goodsCode);
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
            public int? CompanyCode { get; set; }
            public int? GoodsCode { get; set; }

            public SearchButtonClickedEventArgs()
            {
            }

            public SearchButtonClickedEventArgs(int? companyCode, int? goodsCode)
            {
                CompanyCode = companyCode;
                GoodsCode = goodsCode;
            }
        }
        #endregion
    }
}
