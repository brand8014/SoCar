namespace SoCar.Winform.UserControls
{
    partial class LocationSearchControl
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
            this.lueAddress = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsAddress = new System.Windows.Forms.BindingSource(this.components);
            this.lueLocation = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLocation = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueAddress);
            this.layoutControl1.Controls.Add(this.lueLocation);
            this.layoutControl1.Controls.Add(this.btnSearch);
            this.layoutControl1.Controls.Add(this.btnReset);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(320, 210);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueAddress
            // 
            this.lueAddress.Location = new System.Drawing.Point(41, 40);
            this.lueAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueAddress.Name = "lueAddress";
            this.lueAddress.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAddress.Properties.DataSource = this.bdsAddress;
            this.lueAddress.Properties.DisplayMember = "Item";
            this.lueAddress.Properties.ValueMember = "CodeId";
            this.lueAddress.Size = new System.Drawing.Size(267, 24);
            this.lueAddress.StyleController = this.layoutControl1;
            this.lueAddress.TabIndex = 9;
            // 
            // bdsAddress
            // 
            this.bdsAddress.DataSource = typeof(SoCar.Data.Code);
            // 
            // lueLocation
            // 
            this.lueLocation.Location = new System.Drawing.Point(41, 12);
            this.lueLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lueLocation.Name = "lueLocation";
            this.lueLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLocation.Properties.DataSource = this.bdsLocation;
            this.lueLocation.Properties.DisplayMember = "LocationName";
            this.lueLocation.Properties.ValueMember = "LocationId";
            this.lueLocation.Size = new System.Drawing.Size(267, 24);
            this.lueLocation.StyleController = this.layoutControl1;
            this.lueLocation.TabIndex = 8;
            // 
            // bdsLocation
            // 
            this.bdsLocation.DataSource = typeof(SoCar.Data.Location);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(62, 171);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 27);
            this.btnSearch.StyleController = this.layoutControl1;
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(187, 171);
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
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(320, 210);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnReset;
            this.layoutControlItem1.Location = new System.Drawing.Point(175, 159);
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
            this.layoutControlItem2.Location = new System.Drawing.Point(50, 159);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(125, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 56);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(300, 103);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 159);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(50, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.lueLocation;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem5.Text = "지점";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(26, 18);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem6.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem6.Control = this.lueAddress;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(300, 28);
            this.layoutControlItem6.Text = "주소";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(26, 18);
            // 
            // LocationSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "LocationSearchControl";
            this.Size = new System.Drawing.Size(320, 210);
            this.Load += new System.EventHandler(this.LocationSearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource bdsLocation;
        private System.Windows.Forms.BindingSource bdsAddress;
        private DevExpress.XtraEditors.LookUpEdit lueAddress;
        private DevExpress.XtraEditors.LookUpEdit lueLocation;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
