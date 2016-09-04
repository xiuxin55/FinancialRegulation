using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace FinancialRegulation.Page
{
    /// <summary>
    /// O1.xaml 的交互逻辑
    /// </summary>
    public partial class ReadCongEdit : BaseWindow
    {
        public ReadCongEdit(FundsRegulatoryClient.JG_DepositSrv.DepositFund model)
        {
            InitializeComponent();
            ViewModel.ReadCongEditVM vm = new ViewModel.ReadCongEditVM();
            vm.CurrentObj = model;
            vm.windowClose = CloseWindow;
            this.DataContext = vm;
        }
    }
}