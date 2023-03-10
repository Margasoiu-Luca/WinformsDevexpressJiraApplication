using DevExpress.XtraBars;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JiraApplication.Views
{
    public partial class AllView : DevExpress.XtraEditors.XtraUserControl
    {
        public AllView()
        {
            InitializeComponent();

            //gridControl.DataSource = dataSource;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
    }
}
