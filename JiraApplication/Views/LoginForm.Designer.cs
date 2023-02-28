using JiraApplication.Properties;
using System.Drawing;

namespace JiraApplication.Views
{
    public partial class LoginForm
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
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.headerPane = new DevExpress.Utils.Layout.TablePanel();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.PasswordSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.usernameSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toggleShowAll = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Login = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Appearance.FontSizeDelta = 4;
            this.titleLabel.Appearance.Options.UseFont = true;
            this.titleLabel.Appearance.Options.UseTextOptions = true;
            this.titleLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 19);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Login";
            // 
            // headerPane
            // 
            this.headerPane.AutoSize = true;
            this.headerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.headerPane.Controls.Add(this.titleLabel);
            this.headerPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPane.Location = new System.Drawing.Point(20, 2);
            this.headerPane.Margin = new System.Windows.Forms.Padding(0);
            this.headerPane.Name = "headerPane";
            this.headerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.headerPane.Size = new System.Drawing.Size(1531, 0);
            this.headerPane.TabIndex = 5;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            // 
            // btnNew
            // 
            this.btnNew.AllowFocus = false;
            this.btnNew.ImageOptions.Image = global::JiraApplication.Properties.Resources.ArrowPNG;
            this.btnNew.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnNew.Location = new System.Drawing.Point(641, 277);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.Size = new System.Drawing.Size(242, 147);
            this.btnNew.TabIndex = 3;
            // 
            // PasswordSearchControl
            // 
            this.PasswordSearchControl.Location = new System.Drawing.Point(230, 242);
            this.PasswordSearchControl.Name = "PasswordSearchControl";
            this.PasswordSearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.PasswordSearchControl.Properties.NullValuePrompt = "Password";
            this.PasswordSearchControl.Size = new System.Drawing.Size(1000, 20);
            this.PasswordSearchControl.TabIndex = 0;
            // 
            // usernameSearchControl
            // 
            this.usernameSearchControl.Location = new System.Drawing.Point(230, 163);
            this.usernameSearchControl.Name = "usernameSearchControl";
            this.usernameSearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.usernameSearchControl.Properties.NullValuePrompt = "Username";
            this.usernameSearchControl.Size = new System.Drawing.Size(1000, 20);
            this.usernameSearchControl.TabIndex = 1;
            this.usernameSearchControl.SelectedIndexChanged += new System.EventHandler(this.searchControl_SelectedIndexChanged);
            // 
            // toggleShowAll
            // 
            this.toggleShowAll.Location = new System.Drawing.Point(0, 0);
            this.toggleShowAll.Name = "toggleShowAll";
            this.toggleShowAll.Properties.OffText = "Off";
            this.toggleShowAll.Properties.OnText = "On";
            this.toggleShowAll.Size = new System.Drawing.Size(95, 18);
            this.toggleShowAll.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(-15, -15);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.Appearance.FontSizeDelta = 20;
            this.Login.Appearance.Options.UseFont = true;
            this.Login.Location = new System.Drawing.Point(685, 59);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(91, 46);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.PasswordSearchControl);
            this.Controls.Add(this.usernameSearchControl);
            this.Controls.Add(this.headerPane);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 2, 20, 12);
            this.Size = new System.Drawing.Size(1571, 486);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraEditors.SearchControl usernameSearchControl;
        internal System.Windows.Forms.BindingSource todoItemBindingSource;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.ToggleSwitch toggleShowAll;
        private DevExpress.Utils.Layout.TablePanel headerPane;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SearchControl PasswordSearchControl;
        private DevExpress.XtraEditors.SimpleButton Submit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl Login;
    }


}
