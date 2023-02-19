using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM.Services;
using System;
namespace JiraApplication.ViewModels
{
    [POCOViewModel]
    public class LandingPageViewModel
    {
        protected IMessageBoxService MessageBoxService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
        public void SayHello()
        {
            MessageBoxService.ShowMessage("Hello!");
            var document = NavigationService.Current as IDocument;
            NavigationService.Navigate("LoginForm", null, this, false);
            if (document != null)
                document.Close(true);
        }

        public string Greeting
        {
            get
            {
                // Read this count from DB
                return "Hello!";

            }
        }

    }
}