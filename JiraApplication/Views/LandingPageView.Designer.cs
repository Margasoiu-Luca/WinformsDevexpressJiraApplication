namespace JiraApplication.Views
{
    partial class LandingPageView
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
            this.greetLabel = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // greetLabel
            // 
            this.greetLabel.AllowHtmlString = true;
            this.greetLabel.Appearance.Options.UseTextOptions = true;
            this.greetLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.greetLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.greetLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.greetLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.greetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greetLabel.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.greetLabel.ImageOptions.SvgImageSize = new System.Drawing.Size(128, 128);
            this.greetLabel.IndentBetweenImageAndText = 24;
            this.greetLabel.Location = new System.Drawing.Point(0, 0);
            this.greetLabel.Name = "greetLabel";
            this.greetLabel.Padding = new System.Windows.Forms.Padding(24);
            this.greetLabel.Size = new System.Drawing.Size(396, 436);
            this.greetLabel.TabIndex = 0;
            this.greetLabel.Text = "{Greeting}";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(JiraApplication.ViewModels.LandingPageViewModel);
            // 
            // LandingPageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.greetLabel);
            this.Name = "LandingPageView";
            this.Size = new System.Drawing.Size(396, 436);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.XtraEditors.LabelControl greetLabel;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
    }


}