using DevExpress.Data.Async;
using DevExpress.Data.Helpers;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.MVVM.Services;
using JiraApplication.Models;
using JiraApplication.Services;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using JiraApplication.Interfaces;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace JiraApplication.ViewModels
{
    [POCOViewModel]
    public class LoginViewModel 
    {
        private readonly DB_LMEntities1 dbContext = new DB_LMEntities1();
        private readonly JuserService userService = new JuserService();

        protected IMessageBoxService MessageBoxService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }
        protected INavigationService NavigationService
        {
            get { return this.GetService<INavigationService>(); }
        }

        public virtual String Username
        {
            get;
            set;
        }
        public virtual String Password {
            get;
            set;
        }
        public async Task Login()
        {
            try
            {

                var y = await userService.Login(Username, Password);
                var z = y as JUser;
                //var temp = (userService.GetOne(1));
                //var result = await temp;
                if( y is null){

                    MessageBoxService.ShowMessage("Incorrect Login");
                }
                else
                MessageBoxService.ShowMessage("Good Login");
                NavigateToMainPage();
            }
            catch
            {
                MessageBoxService.ShowMessage("Incorrect Login");

            }
        }
        public void NavigateToMainPage()
        {
            var document = NavigationService.Current as IDocument;
            NavigationService.Navigate("MainBlankView", null, this, true);
            this.Password = "";
            this.Username = "";
        }
        public void Close()
        {
            // TODO: we will uncomment these item in complete application
            // var document = NavigationService.Current as IDocument;
            // NavigationService.GoBack();
            // if(document != null)
            //    document.Close(true);
        }
    }
}