namespace SoCar.Winform.Forms
{
    partial class UpdateInsuranceForm
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
            this.bdsCodeForGoods = new System.Windows.Forms.BindingSource(this.components);
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.bdsCodeForCompany = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbCompanyCode = new System.Windows.Forms.ComboBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbbGoods = new System.Windows.Forms.ComboBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeForGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeForCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbbGoods);
            this.layoutControl1.Controls.Add(this.cbbCompanyCode);
            this.layoutControl1.Controls.Add(this.btnUpdate);
            this.layoutControl1.Controls.Add(this.btnClose);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(478, 238);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bdsCodeForGoods
            // 
            this.bdsCodeForGoods.DataSource = typeof(SoCar.Data.Code);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 27);
            this.btnUpdate.StyleController = this.layoutControl1;
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정(&U)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(344, 199);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 27);
            this.btnClose.StyleController = this.layoutControl1;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "닫기(&C)";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bdsCodeForCompany
            // 
            this.bdsCodeForCompany.DataSource = typeof(SoCar.Data.Code);
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
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(478, 238);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 187);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(206, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 60);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(458, 127);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnClose;
            this.layoutControlItem6.Location = new System.Drawing.Point(332, 187);
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
            this.layoutControlItem7.Location = new System.Drawing.Point(206, 187);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(126, 31);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // cbbCompanyCode
            // 
            this.cbbCompanyCode.DataSource = this.bdsCodeForCompany;
            this.cbbCompanyCode.DisplayMember = "Item";
            this.cbbCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCompanyCode.FormattingEnabled = true;
            this.cbbCompanyCode.Location = new System.Drawing.Point(67, 12);
            this.cbbCompanyCode.Name = "cbbCompanyCode";
            this.cbbCompanyCode.Size = new System.Drawing.Size(399, 26);
            this.cbbCompanyCode.TabIndex = 13;
            this.cbbCompanyCode.ValueMember = "CodeId";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem2.Control = this.cbbCompanyCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(458, 30);
            this.layoutControlItem2.Text = "보험사";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 18);
            // 
            // cbbGoods
            // 
            this.cbbGoods.DataSource = this.bdsCodeForGoods;
            this.cbbGoods.DisplayMember = "Item";
            this.cbbGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGoods.FormattingEnabled = true;
            this.cbbGoods.Location = new System.Drawing.Point(67, 42);
            this.cbbGoods.Name = "cbbGoods";
            this.cbbGoods.Size = new System.Drawing.Size(399, 26);
            this.cbbGoods.TabIndex = 14;
            this.cbbGoods.ValueMember = "CodeId";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem3.Control = this.cbbGoods;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(458, 30);
            this.layoutControlItem3.Text = "보험상품";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 18);
            // 
            // UpdateInsuranceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 238);
            this.Controls.Add(this.layoutControl1);
            this.Name = "UpdateInsuranceForm";
            this.Text = "보험 수정";
            this.Load += new System.EventHandler(this.UpdateInsuranceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeForGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCodeForCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource bdsCodeForCompany;
        private System.Windows.Forms.BindingSource bdsCodeForGoods;
        private System.Windows.Forms.ComboBox cbbGoods;
        private System.Windows.Forms.ComboBox cbbCompanyCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}