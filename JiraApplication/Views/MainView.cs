using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JiraApplication.ViewModels;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraBars.Navigation;

namespace JiraApplication.Views
{
    public partial class MainView : DevExpress.XtraEditors.XtraForm
    {
        public MainView()
        {
            InitializeComponent();
            // Initializing bindings only at runtime   
            if (!mvvmContext.IsDesignMode)
            {
                InitializeNavigation();
                InitializeBindings();
            }
            void InitializeNavigation()
            {
                // creating the NavigationFrame as INavigationService
                var navigationService = NavigationService.Create(navigationFrame);
                // registering the service instance
                mvvmContext.RegisterService(navigationService);
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<AppNavViewModel>();
                // Bind the OnShown command to the Shown event
                fluent.WithEvent(this, "Shown")
                    .EventToCommand(x => x.OnShown);
            }

            void InitializeBindings()
            {
                // Initialize the Fluent API
                var fluent = mvvmContext.OfType<AppNavViewModel>();
                // Bind the Title property to the Text
                fluent.SetBinding(this, view => view.Text, x => x.Title);
            }
        }
    }
}