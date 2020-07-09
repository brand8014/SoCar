using SoCar.Data;
using SoCar.Winform.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoCar.Winform.Forms
{
    public partial class MainForm : RootForm
    {
        private Dictionary<string, Control> controls { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controls = new Dictionary<string, Control>();
            MakeControls();
            DisableAllControls();
            label1.BackColor = Color.Transparent;
            label1.Parent = imageSlider1;
            label2.BackColor = Color.Transparent;
            label2.Parent = imageSlider1;
            //Text = LoginProxy.Login.UserName;
        }

        private void uscBasic1_Load(object sender, EventArgs e)
        {

        }

        private void uscBasic1_nbiDeleteLocationClick(object sender, UserControls.uscBasic.nbiDeleteLocationClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);        
        }
        private void uscBasic1_nbiDeleteCarClick(object sender, UserControls.uscBasic.nbiDeleteCarClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }
        private void uscBasic1_nbiDeleteCustomerClick(object sender, UserControls.uscBasic.nbiDeleteCustomerClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }
        private void uscBasic1_nbiDeleteInsuranceClick(object sender, UserControls.uscBasic.nbiDeleteInsuranceClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }
        private void uscBasic1_nbiDeleteRentClick(object sender, UserControls.uscBasic.nbiDeleteRentClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }
        private void uscBasic1_nbiDeleteEventClick(object sender, UserControls.uscBasic.nbiDeleteEventClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }



        private void MakeControls()
        {
            controls.Add("지역조회", locationSearchControl1);
            controls.Add("차조회", carSearchControl1);
            controls.Add("고객조회", customerSearchControl1);
            controls.Add("이벤트조회", eventSearchControl1);
            controls.Add("보험조회", insuranceSearchControl1);
            controls.Add("대여조회", rentSearchControl1);

            controls.Add("지역삭제", locationDeleteControl1);
            controls.Add("차삭제", carDeleteControl1);
            controls.Add("고객삭제", customerDeleteControl1);
            controls.Add("이벤트삭제", eventDeleteControl1);
            controls.Add("보험삭제", insuranceDeleteControl1);
            controls.Add("대여삭제", rentDeleteControl1);
        }
        private void DisableAllControls()
        {
            foreach (var control in controls)
            {
                control.Value.Visible = false;
                control.Value.Enabled = false;
            }
        }
        private void EnableOneControl(string tableName, string action)
        {
            controls[tableName + action].Enabled = true;
            controls[tableName + action].Visible = true;
        }





        private void rentSearchControl1_SearchButtonClicked(object sender, UserControls.RentSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchRent(e.CustomerId, e.LocationId, e.CarId, e.RentDay, e.ReturnDay);
        }
        private void eventSearchControl1_SearchButtonClicked(object sender, UserControls.EventSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchEvent(e.CodeId, e.Period);
        }

        private void locationSearchControl1_SearchButtonClicked(object sender, UserControls.LocationSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchLocation(e.CodeId,e.LocationId);
        }
        private void carSearchControl1_SearchButtonClicked(object sender, UserControls.CarSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchCar(e.CarId, e.CarTypeId, e.LocationId, e.IsRent);
        }
        private void customerSearchControl1_SearchButtonClicked(object sender, UserControls.CustomerSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchCustomer(e.CustomerId, e.Age, e.CellNumber, e.LisenceId);
 
        } private void insuranceSearchControl1_SearchButtonClicked(object sender, UserControls.InsuranceSearchControl.SearchButtonClickedEventArgs e)
        {
            uscBasic1.SearchInsurance(e.CompanyCode, e.GoodsCode); 
               
        }




        private void locationDeleteControl1_LocationDeleteButtonClick(object sender, UserControls.LocationDeleteControl.LocationDeleteButtonClickEventArgs e)
        {
            uscBasic1.DeleteOneLocation();
        }

        private void carDeleteControl1_CarDeleteButtonClick(object sender, UserControls.CarDeleteControl.CarDeleteButtonClickEventArgs e)
        {
            uscBasic1.DeleteOneCar();
        }

        private void customerDeleteControl1_CustomerDeleteButtonClick(object sender, UserControls.CustomerDeleteControl.CustomerDeleteButtonClickEventArgs e)
        {
            uscBasic1.DeleteOneCustomer();
        }

        private void eventDeleteControl1_EventDeleteButtonClick(object sender, UserControls.EventDeleteControl.EventDeleteButtonClickEventArgs e)
        {
            uscBasic1.deleteOneEvent();
        }

        private void insuranceDeleteControl1_InsuranceDeleteButtonClick(object sender, UserControls.InsuranceDeleteControl.InsuranceDeleteButtonClickEventArgs e)
        {
            uscBasic1.deleteOneInsurance();
        }

        private void rentDeleteControl1_RentDeleteButtonClick(object sender, UserControls.RentDeleteControl.RentDeleteButtonClickEventArgs e)
        {
            uscBasic1.deleteOneRent();
        }


        private void uscBasic1_nbiViewEventClick(object sender, UserControls.uscBasic.nbiViewEventClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void uscBasic1_nbiViewCarClick(object sender, UserControls.uscBasic.nbiViewCarClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void uscBasic1_nbiViewCustomerClick(object sender, UserControls.uscBasic.nbiViewCustomerClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void uscBasic1_nbiViewInsuranceClick(object sender, UserControls.uscBasic.nbiViewInsuranceClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void uscBasic1_nbiViewLocationClick(object sender, UserControls.uscBasic.nbiViewLocationClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void uscBasic1_nbiViewRentClick(object sender, UserControls.uscBasic.nbiViewRentClickEventArgs e)
        {
            DisableAllControls();
            EnableOneControl(e.TableName, e.Action);
        }

        private void barButtonCar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            uscBasic1.nbgCar.Expanded = true;
        }

        private void barButtonLocation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = false;
            uscBasic1.nbgLocation.Expanded = true;
        }

        private void barButtonCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = false;
            uscBasic1.nbgCustomer.Expanded = true;
        }

        private void barButtonInsurance_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = false;
            uscBasic1.nbgInsurance.Expanded = true;
        }

        private void barButtonRent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = false;
            uscBasic1.nbgRent.Expanded = true;
        }

        private void barButtonEvent_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = false;
            uscBasic1.nbgEvent.Expanded = true;
        }

        private void barButtonHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imageSlider1.Visible = true;

        }
        
       
    }
}
