using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BusinessLogic.Localdata;
using BusinessLogic.Services;

namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class AppNavViewModel:BaseViewModel
    {
        public AppNavViewModel()
        {

            ServiceContainer.Default.RegisterService(new InMemmoryUser());
            ServiceContainer.Default.RegisterService(new InMemmoryTask());
            ServiceContainer.Default.RegisterService(new UserService("https://localhost:44394/api/users/"));
            ServiceContainer.Default.RegisterService(new EventService("https://localhost:44394/api/tasks/"));
            Title = "JiraApplica1tion";
            _isLoginPage = false;
        }
        public string Title
        {
            get;
            private set;
        }

        private bool _isLoginPage { get; set; }

        public bool IsLoginpage
        {
            get { return _isLoginPage; }
            set
            {
                if (_isLoginPage != value)
                {
                    _isLoginPage = value;
                    this.RaisePropertyChanged(x => x.IsLoginpage);
                }
            }

        }
        private IDocument getCurrentDocument()
        {
            return (NavigationService.Current as IDocument);
        }

        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
        public async Task OnShown()
        {
            // Wait some time (for demo purposes)
            await Task.Delay(1000);
            // Show AppLogo screen
            NavigationService.Navigate("LoginForm", null, this);
            // Wait some time before showing ItemsView
            await Task.Delay(1000);
            // TODO: we will uncomment these item in complete application
            // NavigationService.Navigate("ItemsView", null, this, true);
        }
        public void ClosePage()
        {
            try
            {
                getCurrentDocument().Close();
                NavigationService.GoBack();
                var document = getCurrentDocument().Content.GetParentViewModel<AppNavViewModel>();
                if (document is AppNavViewModel)
                {
                }

            }
            catch
            {
            }

        }
        public void NavigateToDestination(object Destination)
        {

            Destination = $"{Regex.Replace(Destination as string, @"\s+", "")}View";
            NavigationService.Navigate(Destination as string, null, this, true);

        }

    }
}