namespace SoCar.Winform.Forms
{
    partial class InsertRentForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueLocationCode = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsLocation = new System.Windows.Forms.BindingSource(this.components);
            this.lueLocationId = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueCarId = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsCar = new System.Windows.Forms.BindingSource(this.components);
            this.lueCompanyCode = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsInsurance = new System.Windows.Forms.BindingSource(this.components);
            this.lueGoodsCode = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lueEventId = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsEvent = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocationCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocationId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCarId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompanyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInsurance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGoodsCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEventId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueEventId);
            this.layoutControl1.Controls.Add(this.lueGoodsCode);
            this.layoutControl1.Controls.Add(this.lueCompanyCode);
            this.layoutControl1.Controls.Add(this.lueCarId);
            this.layoutControl1.Controls.Add(this.lueLocationId);
            this.layoutControl1.Controls.Add(this.lueLocationCode);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(478, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(218, 411);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 27);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "button";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 27);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫기(&C)";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(478, 450);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 399);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(206, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(458, 259);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(332, 399);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(126, 31);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.simpleButton1;
            this.layoutControlItem7.Location = new System.Drawing.Point(206, 399);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // lueLocationCode
            // 
            this.lueLocationCode.Location = new System.Drawing.Point(67, 12);
            this.lueLocationCode.Name = "lueLocationCode";
            this.lueLocationCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLocationCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 106, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueLocationCode.Properties.DataSource = this.bdsLocation;
            this.lueLocationCode.Properties.DisplayMember = "LocationName";
            this.lueLocationCode.Properties.ValueMember = "LocationCode";
            this.lueLocationCode.Size = new System.Drawing.Size(399, 24);
            this.lueLocationCode.StyleController = this.layoutControl1;
            this.lueLocationCode.TabIndex = 11;
            this.lueLocationCode.EditValueChanged += new System.EventHandler(this.lueLocationCode_EditValueChanged);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueLocationCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem2.Text = "시/군/구";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsLocation
            // 
            this.bdsLocation.DataSource = typeof(SoCar.Data.Location);
            // 
            // lueLocationId
            // 
            this.lueLocationId.Location = new System.Drawing.Point(67, 40);
            this.lueLocationId.Name = "lueLocationId";
            this.lueLocationId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLocationId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 106, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cars", "Cars", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueLocationId.Properties.DataSource = this.bdsLocation;
            this.lueLocationId.Properties.DisplayMember = "Address";
            this.lueLocationId.Properties.ValueMember = "LocationId";
            this.lueLocationId.Size = new System.Drawing.Size(399, 24);
            this.lueLocationId.StyleController = this.layoutControl1;
            this.lueLocationId.TabIndex = 12;
            this.lueLocationId.EditValueChanged += new System.EventHandler(this.lueLocationId_EditValueChanged);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueLocationId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem3.Text = "상세주소";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // lueCarId
            // 
            this.lueCarId.Location = new System.Drawing.Point(67, 68);
            this.lueCarId.Name = "lueCarId";
            this.lueCarId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCarId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Price", "Price", 39, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsRent", "Is Rent", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Number", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarName", "Car Name", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueCarId.Properties.DataSource = this.bdsCar;
            this.lueCarId.Properties.DisplayMember = "CarName";
            this.lueCarId.Properties.ValueMember = "CarId";
            this.lueCarId.Size = new System.Drawing.Size(399, 24);
            this.lueCarId.StyleController = this.layoutControl1;
            this.lueCarId.TabIndex = 13;
            this.lueCarId.EditValueChanged += new System.EventHandler(this.lueCarId_EditValueChanged);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueCarId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem1.Text = "차";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsCar
            // 
            this.bdsCar.DataSource = typeof(SoCar.Data.Car);
            // 
            // lueCompanyCode
            // 
            this.lueCompanyCode.Location = new System.Drawing.Point(67, 96);
            this.lueCompanyCode.Name = "lueCompanyCode";
            this.lueCompanyCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompanyCode.Properties.DataSource = this.bdsInsurance;
            this.lueCompanyCode.Properties.DisplayMember = "CompanyName";
            this.lueCompanyCode.Properties.ValueMember = "CompanyCode";
            this.lueCompanyCode.Size = new System.Drawing.Size(182, 24);
            this.lueCompanyCode.StyleController = this.layoutControl1;
            this.lueCompanyCode.TabIndex = 14;
            this.lueCompanyCode.EditValueChanged += new System.EventHandler(this.lueCompanyCode_EditValueChanged);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueCompanyCode;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(241, 28);
            this.layoutControlItem4.Text = "보험";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsInsurance
            // 
            this.bdsInsurance.DataSource = typeof(SoCar.Data.Insurance);
            // 
            // lueGoodsCode
            // 
            this.lueGoodsCode.Location = new System.Drawing.Point(253, 96);
            this.lueGoodsCode.Name = "lueGoodsCode";
            this.lueGoodsCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueGoodsCode.Properties.DataSource = this.bdsInsurance;
            this.lueGoodsCode.Properties.DisplayMember = "GoodsName";
            this.lueGoodsCode.Properties.ValueMember = "GoodsCode";
            this.lueGoodsCode.Size = new System.Drawing.Size(213, 24);
            this.lueGoodsCode.StyleController = this.layoutControl1;
            this.lueGoodsCode.TabIndex = 15;
            this.lueGoodsCode.EditValueChanged += new System.EventHandler(this.lueGoodsCode_EditValueChanged);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueGoodsCode;
            this.layoutControlItem5.Location = new System.Drawing.Point(241, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(217, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lueEventId
            // 
            this.lueEventId.Enabled = false;
            this.lueEventId.Location = new System.Drawing.Point(67, 124);
            this.lueEventId.Name = "lueEventId";
            this.lueEventId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEventId.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EventName", "Event Name", 90, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RateOfDiscount", "Rate Of Discount", 120, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Period", "Period", 48, DevExpress.Utils.FormatType.DateTime, "yyyy-MM-dd", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lueEventId.Properties.DataSource = this.bdsEvent;
            this.lueEventId.Properties.DisplayMember = "EventName";
            this.lueEventId.Properties.ValueMember = "EventId";
            this.lueEventId.Size = new System.Drawing.Size(399, 24);
            this.lueEventId.StyleController = this.layoutControl1;
            this.lueEventId.TabIndex = 16;
            this.lueEventId.EditValueChanged += new System.EventHandler(this.lueEventId_EditValueChanged);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lueEventId;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem8.Text = "이벤트";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(52, 18);
            // 
            // bdsEvent
            // 
            this.bdsEvent.DataSource = typeof(SoCar.Data.Event);
            // 
            // InsertRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "InsertRentForm";
            this.Text = "제목";
            this.Load += new System.EventHandler(this.InsertRentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocationCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocationId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCarId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompanyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInsurance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueGoodsCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEventId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsEvent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit lueEventId;
        private System.Windows.Forms.BindingSource bdsEvent;
        private DevExpress.XtraEditors.LookUpEdit lueGoodsCode;
        private System.Windows.Forms.BindingSource bdsInsurance;
        private DevExpress.XtraEditors.LookUpEdit lueCompanyCode;
        private DevExpress.XtraEditors.LookUpEdit lueCarId;
        private System.Windows.Forms.BindingSource bdsCar;
        private DevExpress.XtraEditors.LookUpEdit lueLocationId;
        private System.Windows.Forms.BindingSource bdsLocation;
        private DevExpress.XtraEditors.LookUpEdit lueLocationCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}