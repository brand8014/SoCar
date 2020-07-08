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
using SoCar.Winform.Forms;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraPrinting.Native;

namespace SoCar.Winform.UserControls
{
    public partial class uscBasic : UserControl
    {
        public uscBasic()
        {
            InitializeComponent();

        }


        private void nbiViewLocation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetLocationToGrid();
            OnnbiViewLocationClick(nbgLocation.Caption, nbiViewLocation.Caption);
        }
        private void nbiViewCar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetCarToGrid();
            OnnbiViewCarClick(nbgCar.Caption, nbiViewCar.Caption);
        }
        private void nbiViewCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetCustomerToGrid();
            OnnbiViewCustomerClick(nbgCustomer.Caption, nbiViewCustomer.Caption);
        }
        private void nbiViewEvent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetEventToGrid();
            OnnbiViewEventClick(nbgEvent.Caption, nbiViewEvent.Caption);
        }
        private void nbiViewInsurance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetInsuranceToGrid();
            OnnbiViewInsuranceClick(nbgInsurance.Caption, nbiViewInsurance.Caption);
        }
        private void nbiViewRent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            GetRentToGrid();
            OnnbiViewRentClick(nbgRent.Caption, nbiViewRent.Caption);
        }



        internal void SearchLocation(int? codeId ,int? locationId)
        {
            bdsLocation.DataSource = DataRepository.Location.Search(codeId,locationId);
            gridControl.MainView = gvLocation;
            gridControl.DataSource = bdsLocation;
        }
        internal void SearchCar(int? carTypeId, string number, int? location, bool? isRent)
        {
            bdsCar.DataSource = DataRepository.Car.Search(carTypeId, number, location, isRent);
            gridControl.MainView = gvCar;
            gridControl.DataSource = bdsCar;
        }
        internal void SearchCustomer(int? customerId, int? age, string cellNumber, string lisence)
        {
            bdsCustomer.DataSource = DataRepository.Customer.Search(customerId,age, cellNumber, lisence);
            gridControl.MainView = gvCustomer;
            gridControl.DataSource = bdsCustomer;
        }
        internal void SearchEvent(int? codeId, DateTime? period)
        {
            bdsEvent.DataSource = DataRepository.Event.Search(codeId, period);
            gridControl.MainView = gvEvent;
            gridControl.DataSource = bdsEvent;
        }
        internal void SearchRent(int? customerId, int? locationId, int? carId, DateTime? rentDay, DateTime? returnDay)
        {
            bdsRent.DataSource = DataRepository.Rent.Search(customerId, locationId, carId, rentDay, returnDay);
            gridControl.MainView = gvRent;
            gridControl.DataSource = bdsRent;
        }
        internal void SearchInsurance(int? insuranceId, string company, string goods)
        {
            bdsInsurance.DataSource = DataRepository.Insurance.Search(insuranceId, company, goods);
            gridControl.MainView = gvInsurance;
            gridControl.DataSource = bdsInsurance;
        }





        private void GetLocationToGrid()
        {
            bdsCode.DataSource = DataRepository.Code.GetByCodeCategoryId(1);
            bdsLocation.DataSource = DataRepository.Location.GetAll();
            gridControl.MainView = gvLocation;
            gridControl.DataSource = bdsLocation;
        }
        private void GetRentToGrid()
        {
            bdsRent.DataSource = DataRepository.Rent.GetAll();
            gridControl.DataSource = bdsRent;
            gridControl.MainView = gvRent;
        }
        private void GetInsuranceToGrid()
        {
            bdsInsurance.DataSource = DataRepository.Insurance.GetAll();
            gridControl.DataSource = bdsInsurance;
            gridControl.MainView = gvInsurance;
        }
        private void GetEventToGrid()
        {
            bdsEvent.DataSource = DataRepository.Event.GetAll();
            gridControl.DataSource = bdsEvent;
            gridControl.MainView = gvEvent;
        }
        private void GetCustomerToGrid()
        {
            bdsCustomer.DataSource = DataRepository.Customer.GetAll();
            gridControl.DataSource = bdsCustomer;
            gridControl.MainView = gvCustomer;
        }



        private void GetCarToGrid()
        {
            bdsCar.DataSource = DataRepository.Car.GetAll();
            gridControl.MainView = gvCar;
            gridControl.DataSource = bdsCar;
        }



        private void nbiInsertLocation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InsertLocationForm form = new InsertLocationForm();
            form.ShowDialog();           
        }
        private void nbiInsertCar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InsertCarForm form = new InsertCarForm();
            form.ShowDialog();
        }
        private void nbiInsertCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InsertCustomerForm form = new InsertCustomerForm();
            form.ShowDialog();
        }
        private void nbiInsertInsurance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InsertInsuranceForm form = new InsertInsuranceForm();
            form.ShowDialog();
        }
        private void nbiInsertEvent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            InsertEventForm form = new InsertEventForm();
            form.ShowDialog();
        }


        private void gvLocation_DoubleClick(object sender, EventArgs e)
        {
            Location location = bdsLocation.Current as Location;
            if (location == null)
                return;
            UpdateLocationForm form = new UpdateLocationForm(location);
            form.ShowDialog();
        }
        private void gvCar_DoubleClick(object sender, EventArgs e)
        {
            Car car = bdsCar.Current as Car;
            if (car == null)
                return;
            UpdateCarForm form = new UpdateCarForm(car);
            form.ShowDialog();
        }
        private void gvCustomer_DoubleClick(object sender, EventArgs e)
        {
            
            Customer customer = bdsCustomer.Current as Customer;
            if (customer == null)
                return;
            UpdateCustomerForm form = new UpdateCustomerForm(customer);
            form.ShowDialog();
        }
        private void gvEvent_DoubleClick(object sender, EventArgs e)
        {
            Event @event = bdsEvent.Current as Event;
            if (@event == null)
                return;
            UpdateEventForm form = new UpdateEventForm(@event);
            form.ShowDialog();
        }
        private void gvInsurance_DoubleClick(object sender, EventArgs e)
        {
            Insurance insurance = bdsInsurance.Current as Insurance;
            if (insurance == null)
                return;
            UpdateInsuranceForm form = new UpdateInsuranceForm(insurance);
            form.ShowDialog();                 
        }
        private void gvRent_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("대여는 수정할 수 없습니다.");
        }



        private void nbgLocation_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;           
           // GetLocationToGrid();
            //OnnbiViewLocationClick(nbgLocation.Caption, nbiViewLocation.Caption);
        }
        private void nbgCar_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;
           // GetCarToGrid();
            //OnnbiViewCarClick(nbgCar.Caption, nbiViewCar.Caption);
        }
        private void nbgCustomer_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;
            //GetCustomerToGrid();
           // OnnbiViewCustomerClick(nbgCustomer.Caption, nbiViewCustomer.Caption);
        }
        private void nbgInsurance_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;
            //GetInsuranceToGrid();
            //OnnbiViewInsuranceClick(nbgInsurance.Caption, nbiViewInsurance.Caption);
        }
        private void nbgRent_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;
            //GetRentToGrid();
            //OnnbiViewRentClick(nbgRent.Caption, nbiViewRent.Caption);
        }
        private void nbgEvent_CalcGroupClientHeight(object sender, DevExpress.XtraNavBar.NavBarCalcGroupClientHeightEventArgs e)
        {
            if (DesignMode) return;
            //GetEventToGrid();
            //OnnbiViewEventClick(nbgEvent.Caption, nbiViewEvent.Caption);
        }



        private void nbiDeleteLocation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteLocationClick(nbgLocation.Caption,nbiDeleteLocation.Caption);
        }
        private void nbiDeleteCar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteCarClick(nbgLocation.Caption, nbiDeleteCar.Caption);
        }
        private void nbiDeleteCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteCustomerClick(nbgCustomer.Caption, nbiDeleteCustomer.Caption);
        }
        private void nbiDeleteInsurance_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteInsuranceClick(nbgInsurance.Caption, nbiDeleteInsurance.Caption);
        }
        private void nbiDeleteRent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteRentClick(nbgInsurance.Caption, nbiDeleteInsurance.Caption);
        }
        private void nbiDeleteEvent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OnnbiDeleteEventClick(nbgEvent.Caption, nbiDeleteEvent.Caption);
        }



        internal void DeleteOneLocation() 
        {
            Location location = bdsLocation.Current as Location;
            if (location == null)
                return;
            if(Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Location.Delete(location);

            bdsLocation.Remove(location);
        }
        internal void DeleteOneCar()
        {
            Car car = bdsCar.Current as Car;
            if (car == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Car.Delete(car);

            bdsCar.Remove(car);
        }
        internal void DeleteOneCustomer()
        {
            Customer customer = bdsCustomer.Current as Customer;
            if (customer == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;

            DataRepository.Customer.Delete(customer);

            bdsCustomer.Remove(customer);
        }
        internal void deleteOneEvent()
        {
            Event @event = bdsEvent.Current as Event;
            if (@event == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;
            DataRepository.Event.Delete(@event);
            bdsEvent.Remove(@event);
        }
        internal void deleteOneInsurance()
        {
            Insurance insurance = bdsInsurance.Current as Insurance;
            if (insurance == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;
            DataRepository.Insurance.Delete(insurance);
            bdsInsurance.Remove(insurance);
        }
        internal void deleteOneRent()
        {
            Rent rent = bdsRent.Current as Rent;
            if (rent == null)
                return;
            if (Helpers.Helper.SureToDelete() == false)
                return;
            DataRepository.Rent.Delete(rent);
            bdsRent.Remove(rent);
        }



        #region nbiViewLocationClick event things for C# 3.0
        public event EventHandler<nbiViewLocationClickEventArgs> nbiViewLocationClick;

        protected virtual void OnnbiViewLocationClick(nbiViewLocationClickEventArgs e)
        {
            if (nbiViewLocationClick != null)
                nbiViewLocationClick(this, e);
        }

        private nbiViewLocationClickEventArgs OnnbiViewLocationClick(string tableName, string action)
        {
            nbiViewLocationClickEventArgs args = new nbiViewLocationClickEventArgs(tableName, action);
            OnnbiViewLocationClick(args);

            return args;
        }

        private nbiViewLocationClickEventArgs OnnbiViewLocationClickForOut()
        {
            nbiViewLocationClickEventArgs args = new nbiViewLocationClickEventArgs();
            OnnbiViewLocationClick(args);

            return args;
        }

        public class nbiViewLocationClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewLocationClickEventArgs()
            {
            }

            public nbiViewLocationClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiViewCarClick event things for C# 3.0
        public event EventHandler<nbiViewCarClickEventArgs> nbiViewCarClick;

        protected virtual void OnnbiViewCarClick(nbiViewCarClickEventArgs e)
        {
            if (nbiViewCarClick != null)
                nbiViewCarClick(this, e);
        }

        private nbiViewCarClickEventArgs OnnbiViewCarClick(string tableName, string action)
        {
            nbiViewCarClickEventArgs args = new nbiViewCarClickEventArgs(tableName, action);
            OnnbiViewCarClick(args);

            return args;
        }

        private nbiViewCarClickEventArgs OnnbiViewCarClickForOut()
        {
            nbiViewCarClickEventArgs args = new nbiViewCarClickEventArgs();
            OnnbiViewCarClick(args);

            return args;
        }

        public class nbiViewCarClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewCarClickEventArgs()
            {
            }

            public nbiViewCarClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiViewCustomerClick event things for C# 3.0
        public event EventHandler<nbiViewCustomerClickEventArgs> nbiViewCustomerClick;

        protected virtual void OnnbiViewCustomerClick(nbiViewCustomerClickEventArgs e)
        {
            if (nbiViewCustomerClick != null)
                nbiViewCustomerClick(this, e);
        }

        private nbiViewCustomerClickEventArgs OnnbiViewCustomerClick(string tableName, string action)
        {
            nbiViewCustomerClickEventArgs args = new nbiViewCustomerClickEventArgs(tableName, action);
            OnnbiViewCustomerClick(args);

            return args;
        }

        private nbiViewCustomerClickEventArgs OnnbiViewCustomerClickForOut()
        {
            nbiViewCustomerClickEventArgs args = new nbiViewCustomerClickEventArgs();
            OnnbiViewCustomerClick(args);

            return args;
        }

        public class nbiViewCustomerClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewCustomerClickEventArgs()
            {
            }

            public nbiViewCustomerClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiViewInsuranceClick event things for C# 3.0
        public event EventHandler<nbiViewInsuranceClickEventArgs> nbiViewInsuranceClick;

        protected virtual void OnnbiViewInsuranceClick(nbiViewInsuranceClickEventArgs e)
        {
            if (nbiViewInsuranceClick != null)
                nbiViewInsuranceClick(this, e);
        }

        private nbiViewInsuranceClickEventArgs OnnbiViewInsuranceClick(string tableName, string action)
        {
            nbiViewInsuranceClickEventArgs args = new nbiViewInsuranceClickEventArgs(tableName, action);
            OnnbiViewInsuranceClick(args);

            return args;
        }

        private nbiViewInsuranceClickEventArgs OnnbiViewInsuranceClickForOut()
        {
            nbiViewInsuranceClickEventArgs args = new nbiViewInsuranceClickEventArgs();
            OnnbiViewInsuranceClick(args);

            return args;
        }

        public class nbiViewInsuranceClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewInsuranceClickEventArgs()
            {
            }

            public nbiViewInsuranceClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiViewEventClick event things for C# 3.0
        public event EventHandler<nbiViewEventClickEventArgs> nbiViewEventClick;

        protected virtual void OnnbiViewEventClick(nbiViewEventClickEventArgs e)
        {
            if (nbiViewEventClick != null)
                nbiViewEventClick(this, e);
        }

        private nbiViewEventClickEventArgs OnnbiViewEventClick(string tableName, string action)
        {
            nbiViewEventClickEventArgs args = new nbiViewEventClickEventArgs(tableName, action);
            OnnbiViewEventClick(args);

            return args;
        }

        private nbiViewEventClickEventArgs OnnbiViewEventClickForOut()
        {
            nbiViewEventClickEventArgs args = new nbiViewEventClickEventArgs();
            OnnbiViewEventClick(args);

            return args;
        }

        public class nbiViewEventClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewEventClickEventArgs()
            {
            }

            public nbiViewEventClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiViewRentClick event things for C# 3.0
        public event EventHandler<nbiViewRentClickEventArgs> nbiViewRentClick;

        protected virtual void OnnbiViewRentClick(nbiViewRentClickEventArgs e)
        {
            if (nbiViewRentClick != null)
                nbiViewRentClick(this, e);
        }

        private nbiViewRentClickEventArgs OnnbiViewRentClick(string tableName, string action)
        {
            nbiViewRentClickEventArgs args = new nbiViewRentClickEventArgs(tableName, action);
            OnnbiViewRentClick(args);

            return args;
        }

        private nbiViewRentClickEventArgs OnnbiViewRentClickForOut()
        {
            nbiViewRentClickEventArgs args = new nbiViewRentClickEventArgs();
            OnnbiViewRentClick(args);

            return args;
        }

        public class nbiViewRentClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiViewRentClickEventArgs()
            {
            }

            public nbiViewRentClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion

        #region nbiDeleteLocationClick event things for C# 3.0
        public event EventHandler<nbiDeleteLocationClickEventArgs> nbiDeleteLocationClick;

        protected virtual void OnnbiDeleteLocationClick(nbiDeleteLocationClickEventArgs e)
        {
            if (nbiDeleteLocationClick != null)
                nbiDeleteLocationClick(this, e);
        }

        private nbiDeleteLocationClickEventArgs OnnbiDeleteLocationClick(string tableName, string action)
        {
            nbiDeleteLocationClickEventArgs args = new nbiDeleteLocationClickEventArgs(tableName, action);
            OnnbiDeleteLocationClick(args);

            return args;
        }

        private nbiDeleteLocationClickEventArgs OnnbiDeleteLocationClickForOut()
        {
            nbiDeleteLocationClickEventArgs args = new nbiDeleteLocationClickEventArgs();
            OnnbiDeleteLocationClick(args);

            return args;
        }

        public class nbiDeleteLocationClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteLocationClickEventArgs()
            {
            }

            public nbiDeleteLocationClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiDeleteCarClick event things for C# 3.0
        public event EventHandler<nbiDeleteCarClickEventArgs> nbiDeleteCarClick;

        protected virtual void OnnbiDeleteCarClick(nbiDeleteCarClickEventArgs e)
        {
            if (nbiDeleteCarClick != null)
                nbiDeleteCarClick(this, e);
        }

        private nbiDeleteCarClickEventArgs OnnbiDeleteCarClick(string tableName, string action)
        {
            nbiDeleteCarClickEventArgs args = new nbiDeleteCarClickEventArgs(tableName, action);
            OnnbiDeleteCarClick(args);

            return args;
        }

        private nbiDeleteCarClickEventArgs OnnbiDeleteCarClickForOut()
        {
            nbiDeleteCarClickEventArgs args = new nbiDeleteCarClickEventArgs();
            OnnbiDeleteCarClick(args);

            return args;
        }

        public class nbiDeleteCarClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteCarClickEventArgs()
            {
            }

            public nbiDeleteCarClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }
        #endregion
        #region nbiDeleteCustomerClick event things for C# 3.0
        public event EventHandler<nbiDeleteCustomerClickEventArgs> nbiDeleteCustomerClick;

        protected virtual void OnnbiDeleteCustomerClick(nbiDeleteCustomerClickEventArgs e)
        {
            if (nbiDeleteCustomerClick != null)
                nbiDeleteCustomerClick(this, e);
        }

        private nbiDeleteCustomerClickEventArgs OnnbiDeleteCustomerClick(string tableName, string action)
        {
            nbiDeleteCustomerClickEventArgs args = new nbiDeleteCustomerClickEventArgs(tableName, action);
            OnnbiDeleteCustomerClick(args);

            return args;
        }

        private nbiDeleteCustomerClickEventArgs OnnbiDeleteCustomerClickForOut()
        {
            nbiDeleteCustomerClickEventArgs args = new nbiDeleteCustomerClickEventArgs();
            OnnbiDeleteCustomerClick(args);

            return args;
        }

        public class nbiDeleteCustomerClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteCustomerClickEventArgs()
            {
            }

            public nbiDeleteCustomerClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }

        #endregion
        #region nbiDeleteInsuranceClick event things for C# 3.0
        public event EventHandler<nbiDeleteInsuranceClickEventArgs> nbiDeleteInsuranceClick;

        protected virtual void OnnbiDeleteInsuranceClick(nbiDeleteInsuranceClickEventArgs e)
        {
            if (nbiDeleteInsuranceClick != null)
                nbiDeleteInsuranceClick(this, e);
        }

        private nbiDeleteInsuranceClickEventArgs OnnbiDeleteInsuranceClick(string tableName, string action)
        {
            nbiDeleteInsuranceClickEventArgs args = new nbiDeleteInsuranceClickEventArgs(tableName, action);
            OnnbiDeleteInsuranceClick(args);

            return args;
        }

        private nbiDeleteInsuranceClickEventArgs OnnbiDeleteInsuranceClickForOut()
        {
            nbiDeleteInsuranceClickEventArgs args = new nbiDeleteInsuranceClickEventArgs();
            OnnbiDeleteInsuranceClick(args);

            return args;
        }

        public class nbiDeleteInsuranceClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteInsuranceClickEventArgs()
            {
            }

            public nbiDeleteInsuranceClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }

        #endregion
        #region nbiDeleteRentClick event things for C# 3.0
        public event EventHandler<nbiDeleteRentClickEventArgs> nbiDeleteRentClick;

        protected virtual void OnnbiDeleteRentClick(nbiDeleteRentClickEventArgs e)
        {
            if (nbiDeleteRentClick != null)
                nbiDeleteRentClick(this, e);
        }

        private nbiDeleteRentClickEventArgs OnnbiDeleteRentClick(string tableName, string action)
        {
            nbiDeleteRentClickEventArgs args = new nbiDeleteRentClickEventArgs(tableName, action);
            OnnbiDeleteRentClick(args);

            return args;
        }

        private nbiDeleteRentClickEventArgs OnnbiDeleteRentClickForOut()
        {
            nbiDeleteRentClickEventArgs args = new nbiDeleteRentClickEventArgs();
            OnnbiDeleteRentClick(args);

            return args;
        }

        public class nbiDeleteRentClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteRentClickEventArgs()
            {
            }

            public nbiDeleteRentClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }

        #endregion
        #region nbiDeleteEventClick event things for C# 3.0
        public event EventHandler<nbiDeleteEventClickEventArgs> nbiDeleteEventClick;

        protected virtual void OnnbiDeleteEventClick(nbiDeleteEventClickEventArgs e)
        {
            if (nbiDeleteEventClick != null)
                nbiDeleteEventClick(this, e);
        }

        private nbiDeleteEventClickEventArgs OnnbiDeleteEventClick(string tableName, string action)
        {
            nbiDeleteEventClickEventArgs args = new nbiDeleteEventClickEventArgs(tableName, action);
            OnnbiDeleteEventClick(args);

            return args;
        }

        private nbiDeleteEventClickEventArgs OnnbiDeleteEventClickForOut()
        {
            nbiDeleteEventClickEventArgs args = new nbiDeleteEventClickEventArgs();
            OnnbiDeleteEventClick(args);

            return args;
        }

        public class nbiDeleteEventClickEventArgs : EventArgs
        {
            public string TableName { get; set; }
            public string Action { get; set; }

            public nbiDeleteEventClickEventArgs()
            {
            }

            public nbiDeleteEventClickEventArgs(string tableName, string action)
            {
                TableName = tableName;
                Action = action;
            }
        }

        #endregion

        private void gridControl_Click(object sender, EventArgs e)
        {

        }


    }
}
