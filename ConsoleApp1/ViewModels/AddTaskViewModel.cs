using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using BusinessLogic.Models;
using System.ComponentModel;
using BusinessLogic.Localdata;
using System.Threading.Tasks;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;

namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class AddTaskViewModel:BaseViewModel
    {
        private Event element{ get;set; }
        public bool exists
        {
            get
            {
                return UserId != null;
            }
        }

        public string Name 
        
        {
            get
            {
                return element.name;
            } set 
            
            {
                element.name = value;
                this.RaisePropertyChanged(x => x.Name);
            } 
        }
        public string Description

        {
            get
            {
                return element.description;
            }
            set

            {
                element.description = value;
                this.RaisePropertyChanged(x => x.Description);
            }
        }
        public DateTime? DueDate

        {
            get
            {
                return element.dueDate;
            }
            set

            {
                element.dueDate = value;
                this.RaisePropertyChanged(x => x.DueDate);
            }
        }
        public int? UserId
        {
            get
            {
                return element.user.id;
            }
            set
            {
                if (element.user == null)
                {
                    element.user=new User();
                }
                element.user.id = value;
            }
        }
        public AddTaskViewModel()
        {
            var x = CurrentEventRepository.Get();
            if (x != null)
            {
                this.element = x;
            }
            else CreateNewItem();
            CurrentEventRepository.Delete();
        }
        public string fromUser
        {
            get
            {
                if(element.user != null)
                return this.element.user.username;
                return "";
            }
        }

        public string GetTitle
        {
            get
            {
                if (element.id is null)
                {
                    return "New Task";
                }
                return $"Task {element.name}";
            }
        }

        internal int? EventId
        {
            get { return element?.id; }

        }

        public Event Event { get { return element; } }

        private async Task Update()
        {
            try
            {
                await EventService.Update(element);
                this.MessageBoxService.ShowMessage("Update worked.");
                this.RaisePropertyChanged(x => x.GetTitle);
            }
            catch
            {
                this.MessageBoxService.ShowMessage("Error in update");
            }

        }

        private async Task<Event> Create()
        {
            UserId = CurrentUserRepository.Get().id;
            Event ServiceResponse = await EventService.Create(Event);
            this.MessageBoxService.ShowMessage("Task added!");
            this.element = ServiceResponse;
            this.RaisePropertyChanged(x => x.exists);
            this.RaisePropertyChanged(x => x.fromUser);
            this.RaisePropertyChanged(x => x.GetTitle);
            return Event;
        }

        public void CreateNewItem()
        {
            this.element = new Event();
            this.element.user = new User();
            this.element.openBy = DateTime.Now;
            this.RaisePropertyChanged(x => x.exists);
            this.RaisePropertyChanged(x => x.fromUser);
            this.RaisePropertyChanged(x => x.Name);
            this.RaisePropertyChanged(x => x.Description);
            this.RaisePropertyChanged(x => x.DueDate);
        }

        public async Task SaveChanges()
        {
            try
            {
                if (EventId != null)
                {
                    await Update();
                }
                else
                {
                    this.element = await Create();
                }
                UserId = CurrentUserRepository.Get().id;

            }
            catch(Exception ex)
            {
                this.MessageBoxService.ShowMessage("Error! Check the data!");
            }
        }
    }
}