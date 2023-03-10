using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {

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