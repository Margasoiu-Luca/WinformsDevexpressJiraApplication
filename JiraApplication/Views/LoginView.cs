using System;
using System.Windows.Forms;
using BusinessLogic.ViewModels;


namespace JiraApplication.Views
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraUserControl
    {

        public LoginForm()
        {
            InitializeComponent();
            // Initializing bindings only at runtime    
            if (!mvvmContext.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext.OfType<LoginViewModel>();
            fluent.SetBinding(PasswordSearchControl, p => p.EditValue, x => x.Password);
            fluent.SetBinding(usernameSearchControl, p => p.EditValue, x => x.Username);
            fluent.BindCommand(btnNew, x => x.Login);
            fluent.WithKey(usernameSearchControl, Keys.Enter).KeyToCommand(x => x.Login);
            fluent.WithKey(PasswordSearchControl, Keys.Enter).KeyToCommand(x => x.Login);

            //fluent.WithEvent(btnNew, "Click").EventToCommand(x => x.DoSomethingAsync());

            // Initialize the Fluent API
            //// Bind the Title property to the label Text
            //fluent.SetBinding(titleLabel, lbl => lbl.Text, x => x.Title);
            //// Bind commands to buttons
            //fluent.BindCommand(btnBack, x => x.Close);
            //fluent.BindCommand(btnSave, x => x.Save);
            //fluent.BindCommand(btnDelete, x => x.Delete);
            //// Bind datasource to editors
            //fluent.SetObjectDataSourceBinding(todoItemBindingSource, x => x.Item, x => x.Update);
        }

        private void searchControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // LoginForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.Name = "LoginForm";
        //    this.Size = new System.Drawing.Size(622, 390);
        //    this.ResumeLayout(false);

        //}

    }
}

