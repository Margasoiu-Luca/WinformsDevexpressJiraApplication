using BusinessLogic.Interfaces;
using BusinessLogic.Localdata;
using BusinessLogic.Models;
using BusinessLogic.Services;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class BaseViewModel
    {
        protected IMessageBoxService MessageBoxService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }
        protected IRepository<User> CurrentUserRepository
        {
            get { return this.GetRequiredService<IRepository<User>>(); }
        }
        internal IUserService UserService
        {
            get { return this.GetService<IUserService>(); }
        }
        internal IEventService EventService
        {
            get { return this.GetService<IEventService>(); }
        }
        internal IRepository<Event> CurrentEventRepository
        {
            get { return this.GetRequiredService<IRepository<Event>>(); }
        }
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }
    }
}