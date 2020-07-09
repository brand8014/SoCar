namespace SoCar.Winform.Forms
{
    partial class UpdateEventForm
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
            this.cbbRentId = new System.Windows.Forms.ComboBox();
            this.bdsRent = new System.Windows.Forms.BindingSource(this.components);
            this.cbbEventTypeId = new System.Windows.Forms.ComboBox();
            this.bdsCode = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txePeriod = new DevExpress.XtraEditors.TextEdit();
            this.txeRateOfDiscount = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeRateOfDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbRentId);
            this.layoutControl1.Controls.Add(this.cbbEventTypeId);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Controls.Add(this.txePeriod);
            this.layoutControl1.Controls.Add(this.txeRateOfDiscount);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(478, 244);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbRentId
            // 
            this.cbbRentId.DataSource = this.bdsRent;
            this.cbbRentId.DisplayMember = "RentId";
            this.cbbRentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRentId.FormattingEnabled = true;
            this.cbbRentId.Location = new System.Drawing.Point(85, 42);
            this.cbbRentId.Name = "cbbRentId";
            this.cbbRentId.Size = new System.Drawing.Size(381, 26);
            this.cbbRentId.TabIndex = 12;
            this.cbbRentId.ValueMember = "RentId";
            // 
            // bdsRent
            // 
            this.bdsRent.DataSource = typeof(SoCar.Data.Rent);
            // 
            // cbbEventTypeId
            // 
            this.cbbEventTypeId.DataSource = this.bdsCode;
            this.cbbEventTypeId.DisplayMember = "Item";
            this.cbbEventTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEventTypeId.FormattingEnabled = true;
            this.cbbEventTypeId.Location = new System.Drawing.Point(85, 12);
            this.cbbEventTypeId.Name = "cbbEventTypeId";
            this.cbbEventTypeId.Size = new System.Drawing.Size(381, 26);
            this.cbbEventTypeId.TabIndex = 11;
            this.cbbEventTypeId.ValueMember = "CodeId";
            // 
            // bdsCode
            // 
            this.bdsCode.DataSource = typeof(SoCar.Data.Code);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 27);
            this.btnUpdate.StyleController = this.layoutControl1;
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 27);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txePeriod
            // 
            this.txePeriod.Location = new System.Drawing.Point(85, 100);
            this.txePeriod.Name = "txePeriod";
            this.txePeriod.Size = new System.Drawing.Size(381, 24);
            this.txePeriod.StyleController = this.layoutControl1;
            this.txePeriod.TabIndex = 7;
            // 
            // txeRateOfDiscount
            // 
            this.txeRateOfDiscount.Location = new System.Drawing.Point(85, 72);
            this.txeRateOfDiscount.Name = "txeRateOfDiscount";
            this.txeRateOfDiscount.Size = new System.Drawing.Size(381, 24);
            this.txeRateOfDiscount.StyleController = this.layoutControl1;
            this.txeRateOfDiscount.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(478, 244);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.txeRateOfDiscount;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem3.Text = "할인율";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(70, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txePeriod;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 88);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(458, 28);
            this.layoutControlItem4.Text = "기간";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(70, 18);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 193);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(206, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 116);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(458, 77);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(332, 193);
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
            this.layoutControlItem7.Control = this.btnUpdate;
            this.layoutControlItem7.Location = new System.Drawing.Point(206, 193);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.cbbEventTypeId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(458, 30);
            this.layoutControlItem1.Text = "이벤트 타입";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(70, 18);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.cbbRentId;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(458, 30);
            this.layoutControlItem2.Text = "대여ID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(70, 18);
            // 
            // UpdateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.layoutControl1);
            this.Name = "UpdateEventForm";
            this.Text = "이벤트 수정";
            this.Load += new System.EventHandler(this.UpdateEventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeRateOfDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txeRateOfDiscount;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txePeriod;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.ComboBox cbbRentId;
        private System.Windows.Forms.ComboBox cbbEventTypeId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource bdsCode;
        private System.Windows.Forms.BindingSource bdsRent;
    }
}