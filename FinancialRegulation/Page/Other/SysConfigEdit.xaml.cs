namespace FinancialRegulation.Page
{
    /// <summary>
    /// O1.xaml 的交互逻辑
    /// </summary>
    public partial class SysConfigEdit : BaseWindow
    {
        public SysConfigEdit()
        {
            InitializeComponent();
            ViewModel.SysConfigEditVM vm = new ViewModel.SysConfigEditVM();
            vm.windowClose = CloseWindow;
            this.DataContext = vm;
        }

    }
}