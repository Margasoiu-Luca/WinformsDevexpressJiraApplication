using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JiraApplicationBusinessLogic.ViewModels
{
    [POCOViewModel]
    public class AppNavViewModel
    {
        // This is ViewModel for our Application
        public AppNavViewModel()
        {
            Title = "JiraApplica1tion";
            _isLoginPage = true;
        }
        public string Title
        {
            get;
            private set;
        }

        private bool _isLoginPage { get; set; }

        public bool IsLoginpage {
            get {return _isLoginPage; }
            set
            {
                if (_isLoginPage != value)
                {
                    _isLoginPage = value;
                    this.RaisePropertyChanged(x => x.IsLoginpage);
                }
            }
            
        }
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
        public async Task OnShown()
        {
            IsLoginpage = true;
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
                NavigationService.GoBack();
                var document = (NavigationService.Current as IDocument).Content.GetParentViewModel<AppNavViewModel>();
                document.IsLoginpage = false;
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