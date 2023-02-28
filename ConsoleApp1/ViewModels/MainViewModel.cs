using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {

        // This is ViewModel for our Application
        public MainViewModel()
        {
            Title = "JiraApplication";
        }
        public string Title
        {
            get;
            private set;
        }
    }
}