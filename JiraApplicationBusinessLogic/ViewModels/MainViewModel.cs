using DevExpress.Mvvm.DataAnnotations;
namespace JiraApplicationBusinessLogic.ViewModels
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