using DevExpress.XtraBars;
using JiraApplication.ViewModels;
using System;
using System.Linq;


namespace JiraApplication.Views
{
    public partial class MainBlankView : DevExpress.XtraEditors.XtraUserControl
    {
        public MainBlankView()
        {
            InitializeComponent();
            // Initializing bindings only at runtime    
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
         }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ToolbarForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<MainBlankViewModel>();
            fluent.BindCommand(btnClose, x => x.ClosePage);
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {

        }
    }
}