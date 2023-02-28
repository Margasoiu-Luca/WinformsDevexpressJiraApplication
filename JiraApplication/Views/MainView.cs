using System.Windows.Forms;
using BusinessLogic.ViewModels;
using DevExpress.XtraBars;
using DevExpress.Utils.MVVM.Services;

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
                fluent.SetBinding(mainMenu, p => p.Visible, x => x.IsLoginpage);
                fluent.SetBinding(btnClose, p => p.Visible, x => x.IsLoginpage);
                fluent.BindCommand(btnClose, x => x.ClosePage);
                object parameter = 5;
                for (int i=0; i < this.mainMenuManager.Items.Count-1;i++)
                {
                    if (mainMenuManager.Items[i].GetType().Name== "BarButtonItem" && !(mainMenuManager.Items[i] is BarSubItem))
                    {
                        object temp = mainMenuManager.Items[i].Caption;
                        fluent.WithEvent<MouseEventArgs>(mainMenuManager.Items[i] as BarButtonItem, "ItemClick")
                            .EventToCommand(x => x.NavigateToDestination,args => temp,null);

                    }
                }
            }
        }


        class Parameters
        {
            public string Parameter1 { get; set; }
}

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}