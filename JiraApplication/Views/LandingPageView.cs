using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JiraApplication.ViewModels;

namespace JiraApplication.Views
{
    public partial class LandingPageView : DevExpress.XtraEditors.XtraUserControl
    {
        public LandingPageView()
        {
            InitializeComponent();
            // Initializing bindings only at runtime   
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings()
        {
            // Initialize the Fluent API
            var fluent = mvvmContext.OfType<LandingPageViewModel>();
            // Bind the Greeting property to the label Text
            fluent.SetBinding(greetLabel, lbl => lbl.Text, x => x.Greeting);
            fluent.WithEvent(greetLabel, "MouseUp").EventToCommand(x => x.SayHello());
        }
    }
    }