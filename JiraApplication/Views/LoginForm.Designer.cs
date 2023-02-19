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
            this.todoItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.titleLabel = new DevExpress.XtraEditors.LabelControl();
            this.toggleShowAll = new DevExpress.XtraEditors.ToggleSwitch();
            this.footerPane = new DevExpress.Utils.Layout.TablePanel();
            this.headerPane = new DevExpress.Utils.Layout.TablePanel();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.PasswordSearchControl = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).BeginInit();
            this.footerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).BeginInit();
            this.headerPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSearchControl.Properties)).BeginInit();
            this.SuspendLayout();
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
            // titleLabel
            // 
            this.titleLabel.Appearance.FontSizeDelta = 4;
            this.titleLabel.Appearance.Options.UseFont = true;
            this.titleLabel.Appearance.Options.UseTextOptions = true;
            this.titleLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.titleLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.titleLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.headerPane.SetColumn(this.titleLabel, 0);
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.titleLabel.Name = "titleLabel";
            this.headerPane.SetRow(this.titleLabel, 0);
            this.titleLabel.Size = new System.Drawing.Size(1511, 19);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Login";
            // 
            // toggleShowAll
            // 
            this.footerPane.SetColumn(this.toggleShowAll, 0);
            this.toggleShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleShowAll.EditValue = true;
            this.toggleShowAll.Location = new System.Drawing.Point(0, 8);
            this.toggleShowAll.Margin = new System.Windows.Forms.Padding(0);
            this.toggleShowAll.Name = "toggleShowAll";
            this.toggleShowAll.Properties.AllowFocused = false;
            this.toggleShowAll.Properties.AutoWidth = true;
            this.toggleShowAll.Properties.OffText = " Show All Tasks";
            this.toggleShowAll.Properties.OnText = " Show All Tasks";
            this.footerPane.SetRow(this.toggleShowAll, 0);
            this.toggleShowAll.Size = new System.Drawing.Size(126, 26);
            this.toggleShowAll.TabIndex = 3;
            // 
            // footerPane
            // 
            this.footerPane.AutoSize = true;
            this.footerPane.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.footerPane.Controls.Add(this.toggleShowAll);
            this.footerPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPane.Location = new System.Drawing.Point(20, 440);
            this.footerPane.Margin = new System.Windows.Forms.Padding(0);
            this.footerPane.Name = "footerPane";
            this.footerPane.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.footerPane.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.footerPane.Size = new System.Drawing.Size(1531, 34);
            this.footerPane.TabIndex = 4;
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
            this.headerPane.Size = new System.Drawing.Size(1531, 19);
            this.headerPane.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.AllowFocus = false;
            this.btnNew.ImageOptions.Image = global::JiraApplication.Properties.Resources.ArrowPNG;
            this.btnNew.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.btnNew.Location = new System.Drawing.Point(639, 265);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.Size = new System.Drawing.Size(242, 147);
            this.btnNew.TabIndex = 3;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.PasswordSearchControl);
            this.Controls.Add(this.usernameSearchControl);
            this.Controls.Add(this.headerPane);
            this.Controls.Add(this.footerPane);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 2, 20, 12);
            this.Size = new System.Drawing.Size(1571, 486);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.todoItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleShowAll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footerPane)).EndInit();
            this.footerPane.ResumeLayout(false);
            this.footerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerPane)).EndInit();
            this.headerPane.ResumeLayout(false);
            this.headerPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordSearchControl.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private DevExpress.XtraEditors.SearchControl usernameSearchControl;
        internal System.Windows.Forms.BindingSource todoItemBindingSource;
        private DevExpress.XtraEditors.LabelControl titleLabel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraEditors.ToggleSwitch toggleShowAll;
        private DevExpress.Utils.Layout.TablePanel footerPane;
        private DevExpress.Utils.Layout.TablePanel headerPane;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraEditors.SearchControl PasswordSearchControl;
        private DevExpress.XtraEditors.SimpleButton Submit;
    }


}
