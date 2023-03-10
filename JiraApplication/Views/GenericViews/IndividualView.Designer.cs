namespace JiraApplication.Views
{
    partial class IndividualView
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
            this.Login = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.usernameSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.IndividualViewTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Login.Appearance.Options.UseFont = true;
            this.Login.Location = new System.Drawing.Point(98, 109);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(39, 18);
            this.Login.TabIndex = 8;
            this.Login.Text = "Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(98, 198);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Description";
            // 
            // usernameSearchControl
            // 
            this.usernameSearchControl.Location = new System.Drawing.Point(98, 157);
            this.usernameSearchControl.Name = "usernameSearchControl";
            this.usernameSearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.usernameSearchControl.Properties.NullValuePrompt = "Username";
            this.usernameSearchControl.Size = new System.Drawing.Size(233, 20);
            this.usernameSearchControl.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(98, 144);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(256, 2);
            this.labelControl2.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(98, 190);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(256, 2);
            this.labelControl3.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(98, 263);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(256, 2);
            this.labelControl4.TabIndex = 13;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(98, 222);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.NullValuePrompt = "Username";
            this.searchControl1.Size = new System.Drawing.Size(233, 20);
            this.searchControl1.TabIndex = 14;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(46, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Save";
            // 
            // IndividualViewTitle
            // 
            this.IndividualViewTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 21.25F, System.Drawing.FontStyle.Bold);
            this.IndividualViewTitle.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.IndividualViewTitle.Appearance.Options.UseFont = true;
            this.IndividualViewTitle.Location = new System.Drawing.Point(98, 57);
            this.IndividualViewTitle.Name = "IndividualViewTitle";
            this.IndividualViewTitle.Size = new System.Drawing.Size(83, 34);
            this.IndividualViewTitle.TabIndex = 16;
            this.IndividualViewTitle.Text = "Name";
            // 
            // IndividualView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.IndividualViewTitle);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.usernameSearchControl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Login);
            this.Name = "IndividualView";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.IndividualView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected DevExpress.XtraEditors.LabelControl Login;
        protected DevExpress.XtraEditors.LabelControl labelControl1;
        protected DevExpress.XtraEditors.SearchControl usernameSearchControl;
        protected DevExpress.XtraEditors.LabelControl labelControl2;
        protected DevExpress.XtraEditors.LabelControl labelControl3;
        protected DevExpress.XtraEditors.LabelControl labelControl4;
        protected DevExpress.XtraEditors.SearchControl searchControl1;
        protected DevExpress.XtraEditors.SimpleButton simpleButton1;
        protected DevExpress.XtraEditors.LabelControl IndividualViewTitle;
    }
}
