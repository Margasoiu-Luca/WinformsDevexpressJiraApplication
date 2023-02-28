//using DevExpress.Mvvm;
//using DevExpress.Mvvm.DataAnnotations;
//using DevExpress.Mvvm.POCO;
//using System.Threading.Tasks;

//namespace BusinessLogic.ViewModels
//{
//    [POCOViewModel]
//    public class LoginViewModel
//    {
//        private readonly JuserService userService = new JuserService();

//        public LoginViewModel()
//        {
//            _user = new JUser { username="a",password="a"};
//        }


//        protected IMessageBoxService MessageBoxService
//        {
//            get { return this.GetService<IMessageBoxService>(); }
//        }
//        protected INavigationService NavigationService
//        {
//            get { return this.GetService<INavigationService>(); }
//        }

//        private JUser _user{get;set;}


//        public virtual string Username
//        {
//            get
//            {
//                return _user.username;
//            }
//            set
//            {
//                if (_user.username != value)
//                {
//                    _user.username = value;
//                    this.RaisePropertyChanged(x => x.Username);
//                }
//            }
//        }
//        public virtual string Password {
//            get
//            {
//                return _user.password;
//            }
//            set
//            {
//                if (_user.password != value)
//                {
//                    _user.password = value;
//                    this.RaisePropertyChanged(x => x.Password);
//                }
//            }
//        }
//        public async Task Login()
//        {
//            try
//            {

//                var y = await userService.Login(Username, Password);
//                var z = y as JUser;
//                if( y is null){

//                    MessageBoxService.ShowMessage("Incorrect Login");
//                }
//                else
//                NavigateToMainPage();
//            }
//            catch
//            {
//                MessageBoxService.ShowMessage("Incorrect Login");

//            }
//        }
//        public void NavigateToMainPage()
//        {
//            this.GetParentViewModel<AppNavViewModel>().IsLoginpage = true;
//            var document = NavigationService.Current as IDocument;
//            NavigationService.Navigate("MainBlankView", null, this, true);
//            this.Password = "";
//            this.Username = "";
//        }
//    }
//}