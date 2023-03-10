using BusinessLogic.ViewModels;
using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace JiraApplication.Views
{
    public partial class TasksView : JiraApplication.Views.AllView
    {
        public TasksView()
        {

            InitializeComponent(); 
            if (!DesignMode)
                InitializeBindings();
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<TasksViewModel>();
            fluent.WithEvent(bbiRefresh, "ItemClick").EventToCommand(x => x.GetData);
            fluent.SetBinding(gridControl, gControl => gControl.DataSource, x => x.Events);
            fluent.WithEvent(bbiDelete, "ItemClick").EventToCommand(x=>x.Delete);
            fluent.WithEvent(bbiEdit, "ItemClick").EventToCommand(x => x.GoToIndividualMember);
            fluent.WithEvent<ColumnView, FocusedRowObjectChangedEventArgs>(gridView, "FocusedRowObjectChanged")
            .SetBinding(x => x.SelectedEvent,
                args => args.Row as Event,
                (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            //fluent.WithEvent<RowClickEventArgs>(gridView, "RowClick")
            //    .EventToCommand(
            //        x => x.Edit, x => x.SelectedEvent,
            //        args => (args.Clicks == 2) && (args.Button == MouseButtons.Left));
        }

    }
    public class MyRecord
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public MyRecord(int id, string name, string country)
        {
            ID = id;
            Name = name;
            Country = country;
        }
    }
}
