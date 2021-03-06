﻿namespace SoCar.Winform.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonHome = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLocation = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonRent = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonInsurance = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEvent = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.uscBasic1 = new SoCar.Winform.UserControls.uscBasic();
            this.carDeleteControl1 = new SoCar.Winform.UserControls.CarDeleteControl();
            this.customerDeleteControl1 = new SoCar.Winform.UserControls.CustomerDeleteControl();
            this.eventDeleteControl1 = new SoCar.Winform.UserControls.EventDeleteControl();
            this.insuranceDeleteControl1 = new SoCar.Winform.UserControls.InsuranceDeleteControl();
            this.locationDeleteControl1 = new SoCar.Winform.UserControls.LocationDeleteControl();
            this.rentDeleteControl1 = new SoCar.Winform.UserControls.RentDeleteControl();
            this.insuranceSearchControl1 = new SoCar.Winform.UserControls.InsuranceSearchControl();
            this.customerSearchControl1 = new SoCar.Winform.UserControls.CustomerSearchControl();
            this.carSearchControl1 = new SoCar.Winform.UserControls.CarSearchControl();
            this.rentSearchControl1 = new SoCar.Winform.UserControls.RentSearchControl();
            this.locationSearchControl1 = new SoCar.Winform.UserControls.LocationSearchControl();
            this.eventSearchControl1 = new SoCar.Winform.UserControls.EventSearchControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonGroup1,
            this.barButtonHome,
            this.barButtonCustomer,
            this.barButtonLocation,
            this.barButtonCar,
            this.barButtonRent,
            this.barButtonInsurance,
            this.barButtonEvent});
            this.ribbonControl1.LargeImages = this.imageCollection1;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1198, 178);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 4;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonHome
            // 
            this.barButtonHome.Caption = "홈";
            this.barButtonHome.Id = 5;
            this.barButtonHome.ImageOptions.LargeImageIndex = 8;
            this.barButtonHome.Name = "barButtonHome";
            this.barButtonHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHome_ItemClick);
            // 
            // barButtonCustomer
            // 
            this.barButtonCustomer.Caption = "고객";
            this.barButtonCustomer.Id = 6;
            this.barButtonCustomer.ImageOptions.LargeImageIndex = 2;
            this.barButtonCustomer.Name = "barButtonCustomer";
            this.barButtonCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCustomer_ItemClick);
            // 
            // barButtonLocation
            // 
            this.barButtonLocation.Caption = "지역";
            this.barButtonLocation.Id = 7;
            this.barButtonLocation.ImageOptions.LargeImageIndex = 11;
            this.barButtonLocation.Name = "barButtonLocation";
            this.barButtonLocation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLocation_ItemClick);
            // 
            // barButtonCar
            // 
            this.barButtonCar.Caption = "차";
            this.barButtonCar.Id = 8;
            this.barButtonCar.ImageOptions.LargeImageIndex = 6;
            this.barButtonCar.Name = "barButtonCar";
            this.barButtonCar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCar_ItemClick);
            // 
            // barButtonRent
            // 
            this.barButtonRent.Caption = "대여";
            this.barButtonRent.Id = 9;
            this.barButtonRent.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonRent.ImageOptions.Image")));
            this.barButtonRent.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonRent.ImageOptions.LargeImage")));
            this.barButtonRent.ImageOptions.SvgImageSize = new System.Drawing.Size(100, 100);
            this.barButtonRent.Name = "barButtonRent";
            this.barButtonRent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRent_ItemClick);
            // 
            // barButtonInsurance
            // 
            this.barButtonInsurance.Caption = "보험";
            this.barButtonInsurance.Id = 11;
            this.barButtonInsurance.ImageOptions.LargeImageIndex = 13;
            this.barButtonInsurance.Name = "barButtonInsurance";
            this.barButtonInsurance.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonInsurance_ItemClick);
            // 
            // barButtonEvent
            // 
            this.barButtonEvent.Caption = "이벤트";
            this.barButtonEvent.Id = 12;
            this.barButtonEvent.ImageOptions.LargeImageIndex = 0;
            this.barButtonEvent.Name = "barButtonEvent";
            this.barButtonEvent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonEvent_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(35, 35);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "iconfinder_Events_751098 (1).png");
            this.imageCollection1.Images.SetKeyName(1, "iconfinder_setting_user_interface_app_option_preference_3832196.png");
            this.imageCollection1.Images.SetKeyName(2, "iconfinder_user_group_man_woman_2639943.png");
            this.imageCollection1.Images.SetKeyName(3, "iconfinder_Paper_4200478.png");
            this.imageCollection1.Images.SetKeyName(4, "iconfinder_Cab_3363563.png");
            this.imageCollection1.Images.SetKeyName(5, "iconfinder_20_2739101.png");
            this.imageCollection1.Images.SetKeyName(6, "iconfinder_car_2639905.png");
            this.imageCollection1.Images.SetKeyName(7, "iconfinder__52ui_2303157.png");
            this.imageCollection1.Images.SetKeyName(8, "iconfinder_home_1372383.png");
            this.imageCollection1.Images.SetKeyName(9, "iconfinder_00-ELASTOFONT-STORE-READY_map-maker2_2703073.png");
            this.imageCollection1.Images.SetKeyName(10, "iconfinder_house_384890.png");
            this.imageCollection1.Images.SetKeyName(11, "iconfinder_location_1585851.png");
            this.imageCollection1.Images.SetKeyName(12, "iconfinder___Location_1904662.png");
            this.imageCollection1.Images.SetKeyName(13, "iconfinder_health_protection_healthcare_medical_insurance_4951157.png");
            this.imageCollection1.Images.SetKeyName(14, "iconfinder_shield_security_protection_antivirus_insurance_3994405.png");
            this.imageCollection1.Images.SetKeyName(15, "iconfinder_266_car_hand_insurance_transport_safety_3957655.png");
            this.imageCollection1.Images.SetKeyName(16, "iconfinder_4_insurance_Finance_insurance_money_protection_4308069.png");
            this.imageCollection1.Images.SetKeyName(17, "iconfinder_calendar-80px_510932.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "메뉴";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonHome);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonLocation);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonCustomer, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonInsurance);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonRent);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonEvent);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // uscBasic1
            // 
            this.uscBasic1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscBasic1.Location = new System.Drawing.Point(0, 194);
            this.uscBasic1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uscBasic1.Name = "uscBasic1";
            this.uscBasic1.Size = new System.Drawing.Size(857, 545);
            this.uscBasic1.TabIndex = 1;
            this.uscBasic1.nbiViewLocationClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewLocationClickEventArgs>(this.uscBasic1_nbiViewLocationClick);
            this.uscBasic1.nbiViewCarClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewCarClickEventArgs>(this.uscBasic1_nbiViewCarClick);
            this.uscBasic1.nbiViewCustomerClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewCustomerClickEventArgs>(this.uscBasic1_nbiViewCustomerClick);
            this.uscBasic1.nbiViewInsuranceClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewInsuranceClickEventArgs>(this.uscBasic1_nbiViewInsuranceClick);
            this.uscBasic1.nbiViewEventClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewEventClickEventArgs>(this.uscBasic1_nbiViewEventClick);
            this.uscBasic1.nbiViewRentClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiViewRentClickEventArgs>(this.uscBasic1_nbiViewRentClick);
            this.uscBasic1.nbiDeleteLocationClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteLocationClickEventArgs>(this.uscBasic1_nbiDeleteLocationClick);
            this.uscBasic1.nbiDeleteCarClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteCarClickEventArgs>(this.uscBasic1_nbiDeleteCarClick);
            this.uscBasic1.nbiDeleteCustomerClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteCustomerClickEventArgs>(this.uscBasic1_nbiDeleteCustomerClick);
            this.uscBasic1.nbiDeleteInsuranceClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteInsuranceClickEventArgs>(this.uscBasic1_nbiDeleteInsuranceClick);
            this.uscBasic1.nbiDeleteRentClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteRentClickEventArgs>(this.uscBasic1_nbiDeleteRentClick);
            this.uscBasic1.nbiDeleteEventClick += new System.EventHandler<SoCar.Winform.UserControls.uscBasic.nbiDeleteEventClickEventArgs>(this.uscBasic1_nbiDeleteEventClick);
            // 
            // carDeleteControl1
            // 
            this.carDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.carDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.carDeleteControl1.Name = "carDeleteControl1";
            this.carDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.carDeleteControl1.TabIndex = 2;
            this.carDeleteControl1.CarDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.CarDeleteControl.CarDeleteButtonClickEventArgs>(this.carDeleteControl1_CarDeleteButtonClick);
            // 
            // customerDeleteControl1
            // 
            this.customerDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.customerDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerDeleteControl1.Name = "customerDeleteControl1";
            this.customerDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.customerDeleteControl1.TabIndex = 3;
            this.customerDeleteControl1.CustomerDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.CustomerDeleteControl.CustomerDeleteButtonClickEventArgs>(this.customerDeleteControl1_CustomerDeleteButtonClick);
            // 
            // eventDeleteControl1
            // 
            this.eventDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.eventDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventDeleteControl1.Name = "eventDeleteControl1";
            this.eventDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.eventDeleteControl1.TabIndex = 4;
            this.eventDeleteControl1.EventDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.EventDeleteControl.EventDeleteButtonClickEventArgs>(this.eventDeleteControl1_EventDeleteButtonClick);
            // 
            // insuranceDeleteControl1
            // 
            this.insuranceDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insuranceDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.insuranceDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insuranceDeleteControl1.Name = "insuranceDeleteControl1";
            this.insuranceDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.insuranceDeleteControl1.TabIndex = 5;
            this.insuranceDeleteControl1.InsuranceDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.InsuranceDeleteControl.InsuranceDeleteButtonClickEventArgs>(this.insuranceDeleteControl1_InsuranceDeleteButtonClick);
            // 
            // locationDeleteControl1
            // 
            this.locationDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.locationDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationDeleteControl1.Name = "locationDeleteControl1";
            this.locationDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.locationDeleteControl1.TabIndex = 6;
            this.locationDeleteControl1.LocationDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.LocationDeleteControl.LocationDeleteButtonClickEventArgs>(this.locationDeleteControl1_LocationDeleteButtonClick);
            // 
            // rentDeleteControl1
            // 
            this.rentDeleteControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentDeleteControl1.Location = new System.Drawing.Point(863, 194);
            this.rentDeleteControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rentDeleteControl1.Name = "rentDeleteControl1";
            this.rentDeleteControl1.Size = new System.Drawing.Size(316, 545);
            this.rentDeleteControl1.TabIndex = 7;
            this.rentDeleteControl1.RentDeleteButtonClick += new System.EventHandler<SoCar.Winform.UserControls.RentDeleteControl.RentDeleteButtonClickEventArgs>(this.rentDeleteControl1_RentDeleteButtonClick);
            // 
            // insuranceSearchControl1
            // 
            this.insuranceSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insuranceSearchControl1.Location = new System.Drawing.Point(863, 194);
            this.insuranceSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.insuranceSearchControl1.Name = "insuranceSearchControl1";
            this.insuranceSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.insuranceSearchControl1.TabIndex = 9;
            this.insuranceSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.InsuranceSearchControl.SearchButtonClickedEventArgs>(this.insuranceSearchControl1_SearchButtonClicked);
            // 
            // customerSearchControl1
            // 
            this.customerSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerSearchControl1.Location = new System.Drawing.Point(863, 194);
            this.customerSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerSearchControl1.Name = "customerSearchControl1";
            this.customerSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.customerSearchControl1.TabIndex = 10;
            this.customerSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.CustomerSearchControl.SearchButtonClickedEventArgs>(this.customerSearchControl1_SearchButtonClicked);
            // 
            // carSearchControl1
            // 
            this.carSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carSearchControl1.Location = new System.Drawing.Point(863, 193);
            this.carSearchControl1.Name = "carSearchControl1";
            this.carSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.carSearchControl1.TabIndex = 11;
            this.carSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.CarSearchControl.SearchButtonClickedEventArgs>(this.carSearchControl1_SearchButtonClicked);
            // 
            // rentSearchControl1
            // 
            this.rentSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rentSearchControl1.Location = new System.Drawing.Point(863, 194);
            this.rentSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rentSearchControl1.Name = "rentSearchControl1";
            this.rentSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.rentSearchControl1.TabIndex = 13;
            this.rentSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.RentSearchControl.SearchButtonClickedEventArgs>(this.rentSearchControl1_SearchButtonClicked);
            // 
            // locationSearchControl1
            // 
            this.locationSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationSearchControl1.Location = new System.Drawing.Point(863, 194);
            this.locationSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locationSearchControl1.Name = "locationSearchControl1";
            this.locationSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.locationSearchControl1.TabIndex = 15;
            this.locationSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.LocationSearchControl.SearchButtonClickedEventArgs>(this.locationSearchControl1_SearchButtonClicked);
            // 
            // eventSearchControl1
            // 
            this.eventSearchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventSearchControl1.Location = new System.Drawing.Point(863, 194);
            this.eventSearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventSearchControl1.Name = "eventSearchControl1";
            this.eventSearchControl1.Size = new System.Drawing.Size(316, 545);
            this.eventSearchControl1.TabIndex = 17;
            this.eventSearchControl1.SearchButtonClicked += new System.EventHandler<SoCar.Winform.UserControls.EventSearchControl.SearchButtonClickedEventArgs>(this.eventSearchControl1_SearchButtonClicked);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup8";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // imageSlider1
            // 
            this.imageSlider1.AllowLooping = true;
            this.imageSlider1.AnimationTime = 1000;
            this.imageSlider1.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imageSlider1.AutoSlideInterval = 2500;
            this.imageSlider1.CurrentImageIndex = 0;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
            this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
            this.imageSlider1.Location = new System.Drawing.Point(0, 178);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(1198, 574);
            this.imageSlider1.TabIndex = 21;
            this.imageSlider1.TabStop = false;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Font = new System.Drawing.Font("Expo M", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Appearance.Options.UseForeColor = true;
            this.label1.AppearancePressed.BackColor = System.Drawing.Color.Transparent;
            this.label1.AppearancePressed.Options.UseBackColor = true;
            this.label1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.label1.Location = new System.Drawing.Point(90, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "자동차 대여관리 프로그램";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Blackadder ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(150, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 37);
            this.label2.TabIndex = 25;
            this.label2.Text = "Car Rent Management Program";
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 752);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.eventSearchControl1);
            this.Controls.Add(this.locationSearchControl1);
            this.Controls.Add(this.rentSearchControl1);
            this.Controls.Add(this.carSearchControl1);
            this.Controls.Add(this.customerSearchControl1);
            this.Controls.Add(this.insuranceSearchControl1);
            this.Controls.Add(this.rentDeleteControl1);
            this.Controls.Add(this.locationDeleteControl1);
            this.Controls.Add(this.insuranceDeleteControl1);
            this.Controls.Add(this.uscBasic1);
            this.Controls.Add(this.customerDeleteControl1);
            this.Controls.Add(this.carDeleteControl1);
            this.Controls.Add(this.eventDeleteControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private UserControls.uscBasic uscBasic1;
        private UserControls.CarDeleteControl carDeleteControl1;
        private UserControls.CustomerDeleteControl customerDeleteControl1;
        private UserControls.EventDeleteControl eventDeleteControl1;
        private UserControls.InsuranceDeleteControl insuranceDeleteControl1;
        private UserControls.LocationDeleteControl locationDeleteControl1;
        private UserControls.RentDeleteControl rentDeleteControl1;
        private UserControls.InsuranceSearchControl insuranceSearchControl1;
        private UserControls.CustomerSearchControl customerSearchControl1;
        private UserControls.CarSearchControl carSearchControl1;
        private UserControls.RentSearchControl rentSearchControl1;
        private UserControls.LocationSearchControl locationSearchControl1;
        private UserControls.EventSearchControl eventSearchControl1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonCustomer;
        private DevExpress.XtraBars.BarButtonItem barButtonLocation;
        private DevExpress.XtraBars.BarButtonItem barButtonCar;
        private DevExpress.XtraBars.BarButtonItem barButtonRent;
        private DevExpress.XtraBars.BarButtonItem barButtonInsurance;
        private DevExpress.XtraBars.BarButtonItem barButtonEvent;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
       // private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;

        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}