using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
namespace JiraApplication.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {

        // This is ViewModel for our Application
        public MainViewModel()
        {
            Title = "Getting started witn MVVM - Todo App";
        }
        public string Title
        {
            get;
            private set;
        }
    }

}