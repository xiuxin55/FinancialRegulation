namespace FinancialRegulation.Page
{
    /// <summary>
    /// PayAccrualManage.xaml 的交互逻辑
    /// </summary>
    public partial class PayAccrualManage : BaseWindow
    {
        public PayAccrualManage()
        {
            InitializeComponent();
            ViewModel.PayAccrualManageVM vm = new ViewModel.PayAccrualManageVM(Gridview2);
            this.DataContext = vm;
        }
    }
}