using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
namespace JiraApplicationBusinessLogic.ViewModels
{
    [POCOViewModel]
    public class MainBlankViewModel
    {
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
        public void ClosePage()
        {
            var document = NavigationService.Current as IDocument;
            NavigationService.GoBack();
        }
    }
}