using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Threading.Tasks;
using BusinessLogic.Services;
using BusinessLogic.Models;
using BusinessLogic.Localdata;

namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class LoginViewModel:BaseViewModel
    {
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
        public LoginViewModel()
        {
            _user = new User();
        }



        private User _user { get; set; }


        public virtual string Username
        {
            get
            {
                return _user.username;
            }
            set
            {
                if (_user.username != value)
                {
                    _user.username = value;
                    this.RaisePropertyChanged(x => x.Username);
                }
            }
        }
        public virtual string Password
        {
            get
            {
                return _user.password;
            }
            set
            {
                if (_user.password != value)
                {
                    _user.password = value;
                    this.RaisePropertyChanged(x => x.Password);
                }
            }
        }
        public Nullable<int> Id
        {
            get { return _user.id; }
            set
            {
                if (_user.id != value) _user.id = value;
            }
        }


        public async Task Login()
        {
            try
            {

                User userFoundInDatabase = (await UserService.Login(new User(Username, Password))).getDbElement();
                if (userFoundInDatabase is null)
                {

                    MessageBoxService.ShowMessage("Incorrect Login");
                }
                else
                {
                    CurrentUserRepository.Delete();
                    CurrentUserRepository.Set(userFoundInDatabase);
                    NavigateToMainPage();
                }

            }
            catch
            {
                MessageBoxService.ShowMessage("Incorrect Login");

            }
        }
        public void NavigateToMainPage()
        {
            this.GetParentViewModel<AppNavViewModel>().IsLoginpage = true;
            var document = NavigationService.Current as IDocument;
            NavigationService.Navigate("MainBlankView", null, this, true);
            this.Password = "";
            this.Username = "";
        }
    }
}