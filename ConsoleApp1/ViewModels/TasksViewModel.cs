using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using BusinessLogic.Models;
using System.Collections.Generic;
using BusinessLogic.Localdata;
using BusinessLogic.Services;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using System.Security.Principal;

namespace BusinessLogic.ViewModels
{
    [POCOViewModel]
    public class TasksViewModel: BaseViewModel
    {
        public List<int> a;

        private Event _selectedEvent;

        private BindingList<Event> _events;


        public IList<Event> Events
        {
            get
            {
                return _events;
            }
            set
            {

            }
        }
        public Event SelectedEvent
        {
            get { return _selectedEvent; }
            set
            {
                _selectedEvent = value;
            }
        }
        public async void GetData()
        {
            var response = await this.EventService.GetAll();
            Events.Clear();
            foreach (Event item in response)
            {
                Events.Add(item);
            }

        }
        public async void Delete()
        {
            if((MessageBoxService.ShowMessage("Are you sure you want to delete this?", "Alert", MessageButton.YesNo, MessageIcon.Information) == MessageResult.Yes))
            {
                var response = await this.EventService.Delete((int)SelectedEvent.id);
                Events.Remove(SelectedEvent);
                this.MessageBoxService.ShowMessage("Successfully deleted");
            }

        }

        public void GoToIndividualMember()
        {
            this.CurrentEventRepository.Set(_selectedEvent);
            this.NavigationService.Navigate("AddTaskView", null, this, true);
        }


            public TasksViewModel()
        {
            _events = new BindingList<Event>();
        }
    }
}