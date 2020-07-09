namespace SoCar.Winform.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.chkrememberLoginName = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Location = new System.Drawing.Point(138, 109);
            this.txbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(156, 26);
            this.txbName.TabIndex = 0;
            // 
            // txbPW
            // 
            this.txbPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPW.Location = new System.Drawing.Point(138, 143);
            this.txbPW.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPW.Name = "txbPW";
            this.txbPW.PasswordChar = '*';
            this.txbPW.Size = new System.Drawing.Size(156, 26);
            this.txbPW.TabIndex = 1;
            this.txbPW.TextChanged += new System.EventHandler(this.txbPW_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(49, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "UserName :";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.ForeColor = System.Drawing.Color.Black;
            this.lblPW.Location = new System.Drawing.Point(50, 145);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(79, 18);
            this.lblPW.TabIndex = 3;
            this.lblPW.Text = "Password :";
            // 
            // chkrememberLoginName
            // 
            this.chkrememberLoginName.AutoSize = true;
            this.chkrememberLoginName.ForeColor = System.Drawing.Color.Black;
            this.chkrememberLoginName.Location = new System.Drawing.Point(122, 191);
            this.chkrememberLoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkrememberLoginName.Name = "chkrememberLoginName";
            this.chkrememberLoginName.Size = new System.Drawing.Size(121, 22);
            this.chkrememberLoginName.TabIndex = 4;
            this.chkrememberLoginName.Text = "Save Login ID";
            this.chkrememberLoginName.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(97, 243);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOk.Location = new System.Drawing.Point(183, 243);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 31);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Login";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 354);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkrememberLoginName);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbPW);
            this.Controls.Add(this.txbName);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginForm.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbPW;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.CheckBox chkrememberLoginName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
    }
}