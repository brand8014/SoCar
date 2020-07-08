namespace SoCar.Winform.UserControls
{
    partial class RentSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbReturnDay = new System.Windows.Forms.TextBox();
            this.txbRentDay = new System.Windows.Forms.TextBox();
            this.cbbCarTypeId = new System.Windows.Forms.ComboBox();
            this.bdsCar = new System.Windows.Forms.BindingSource(this.components);
            this.cbbLocationId = new System.Windows.Forms.ComboBox();
            this.bdsIocation = new System.Windows.Forms.BindingSource(this.components);
            this.cbbCustomerId = new System.Windows.Forms.ComboBox();
            this.bdsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txbPrice);
            this.layoutControl1.Controls.Add(this.txbReturnDay);
            this.layoutControl1.Controls.Add(this.txbRentDay);
            this.layoutControl1.Controls.Add(this.cbbCarTypeId);
            this.layoutControl1.Controls.Add(this.cbbLocationId);
            this.layoutControl1.Controls.Add(this.cbbCustomerId);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.btnReset);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(320, 324);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(54, 160);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(254, 25);
            this.txbPrice.TabIndex = 11;
            // 
            // txbReturnDay
            // 
            this.txbReturnDay.Location = new System.Drawing.Point(54, 131);
            this.txbReturnDay.Name = "txbReturnDay";
            this.txbReturnDay.Size = new System.Drawing.Size(254, 25);
            this.txbReturnDay.TabIndex = 10;
            // 
            // txbRentDay
            // 
            this.txbRentDay.Location = new System.Drawing.Point(54, 102);
            this.txbRentDay.Name = "txbRentDay";
            this.txbRentDay.Size = new System.Drawing.Size(254, 25);
            this.txbRentDay.TabIndex = 9;
            // 
            // cbbCarTypeId
            // 
            this.cbbCarTypeId.DataSource = this.bdsCar;
            this.cbbCarTypeId.DisplayMember = "Number";
            this.cbbCarTypeId.FormattingEnabled = true;
            this.cbbCarTypeId.Location = new System.Drawing.Point(54, 72);
            this.cbbCarTypeId.Name = "cbbCarTypeId";
            this.cbbCarTypeId.Size = new System.Drawing.Size(254, 23);
            this.cbbCarTypeId.TabIndex = 8;
            this.cbbCarTypeId.ValueMember = "CarId";
            // 
            // bdsCar
            // 
            this.bdsCar.DataSource = typeof(SoCar.Data.Car);
            // 
            // cbbLocationId
            // 
            this.cbbLocationId.DataSource = this.bdsIocation;
            this.cbbLocationId.DisplayMember = "Address";
            this.cbbLocationId.FormattingEnabled = true;
            this.cbbLocationId.Location = new System.Drawing.Point(54, 42);
            this.cbbLocationId.Name = "cbbLocationId";
            this.cbbLocationId.Size = new System.Drawing.Size(254, 23);
            this.cbbLocationId.TabIndex = 7;
            this.cbbLocationId.ValueMember = "LocationId";
            // 
            // bdsIocation
            // 
            this.bdsIocation.DataSource = typeof(SoCar.Data.Location);
            // 
            // cbbCustomerId
            // 
            this.cbbCustomerId.DataSource = this.bdsCustomer;
            this.cbbCustomerId.DisplayMember = "Name";
            this.cbbCustomerId.FormattingEnabled = true;
            this.cbbCustomerId.Location = new System.Drawing.Point(54, 12);
            this.cbbCustomerId.Name = "cbbCustomerId";
            this.cbbCustomerId.Size = new System.Drawing.Size(254, 23);
            this.cbbCustomerId.TabIndex = 6;
            this.cbbCustomerId.ValueMember = "CustomerId";
            // 
            // bdsCustomer
            // 
            this.bdsCustomer.DataSource = typeof(SoCar.Data.Customer);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(62, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 27);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(187, 285);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 27);
            this.btnReset.StyleController = this.layoutControl1;
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "초기화(&R)";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(320, 324);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnReset;
            this.layoutControlItem1.Location = new System.Drawing.Point(175, 273);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(125, 31);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(50, 273);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 273);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(50, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 177);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(300, 96);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbbCustomerId;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(300, 30);
            this.layoutControlItem3.Text = "회원";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbbLocationId;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(300, 30);
            this.layoutControlItem4.Text = "지점";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbbCarTypeId;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(300, 30);
            this.layoutControlItem5.Text = "차량";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txbRentDay;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(300, 29);
            this.layoutControlItem6.Text = "예약일";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txbReturnDay;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(300, 29);
            this.layoutControlItem7.Text = "반납일";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(39, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txbPrice;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(300, 29);
            this.layoutControlItem8.Text = "가격";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(39, 18);
            // 
            // RentSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "RentSearchControl";
            this.Size = new System.Drawing.Size(320, 324);
            this.Load += new System.EventHandler(this.RentSearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsIocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbReturnDay;
        private System.Windows.Forms.TextBox txbRentDay;
        private System.Windows.Forms.ComboBox cbbCarTypeId;
        private System.Windows.Forms.ComboBox cbbLocationId;
        private System.Windows.Forms.BindingSource bdsIocation;
        private System.Windows.Forms.ComboBox cbbCustomerId;
        private System.Windows.Forms.BindingSource bdsCustomer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource bdsCar;
    }
}
