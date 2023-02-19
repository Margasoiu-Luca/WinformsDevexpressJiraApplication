using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Threading.Tasks;

namespace JiraApplication.ViewModels
{
    [POCOViewModel]
    public class AppNavViewModel
    {
        // This is ViewModel for our Application
        public AppNavViewModel()
        {
            Title = "Getting started witn MVVM - Todo App";
        }
        public string Title
        {
            get;
            private set;
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
    }


}