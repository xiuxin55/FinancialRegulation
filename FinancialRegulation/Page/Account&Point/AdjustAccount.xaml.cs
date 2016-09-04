namespace FinancialRegulation.Page
{
    /// <summary>
    /// AdjustAccount.xaml 的交互逻辑
    /// </summary>
    public partial class AdjustAccount : BaseWindow
    {
        public AdjustAccount()
        {
            InitializeComponent();
            ViewModel.AdjustAccountVM vm = new ViewModel.AdjustAccountVM();
            this.DataContext = vm; 
        }
    }
}