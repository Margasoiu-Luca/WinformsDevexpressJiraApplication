using BusinessLogic.ViewModels;
using DevExpress.Utils.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JiraApplication.Views
{
    public partial class AddTaskView : JiraApplication.Views.IndividualView
    {
        public AddTaskView()
        {
            InitializeComponent();
            InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<AddTaskViewModel>();
            fluent.SetBinding(usernameSearchControl, c => c.EditValue, vm => vm.Name);
            fluent.SetBinding(searchControl1, c => c.EditValue, vm => vm.Description);
            fluent.SetBinding(dateEdit2, c => c.EditValue, vm => vm.DueDate);
            fluent.BindCommand(simpleButton1    , vm => vm.SaveChanges);
            fluent.SetBinding(simpleButton2, b => b.Visible, vm => vm.exists);
            fluent.SetBinding(labelControl5, b => b.Visible, vm => vm.exists);
            fluent.SetBinding(labelControl8, b => b.Visible, vm => vm.exists);
            fluent.SetBinding(labelControl8, b => b.Text, vm => vm.fromUser);
            fluent.SetBinding(IndividualViewTitle, b => b.Text, vm => vm.GetTitle);
            fluent.BindCommand(simpleButton2,vm=>vm.CreateNewItem);
        }
    }
}
