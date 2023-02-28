using BusinessLogic.ViewModels;

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