using System.Windows.Controls;
using System.Windows.Input;
namespace FinancialRegulation.Page
{
    /// <summary>
    /// FundInfoManage.xaml 的交互逻辑
    /// </summary>
    public partial class AccrualManage : BaseWindow
    {
        public AccrualManage()
        {
            InitializeComponent();
            ViewModel.AccrualManageVM vm = new ViewModel.AccrualManageVM();
            
            this.DataContext = vm;
            
        }

        /// <summary>
        /// 只能输入数字和小数点，且只能由一个小数点
        /// </summary>Blicae
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxNUMPeriod_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;

            //屏蔽非法按键
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Decimal || e.Key.ToString() == "Tab")
            {
                if (txt.Text.Contains(".") && e.Key == Key.Decimal)
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else if (((e.Key >= Key.D0 && e.Key <= Key.D9) || e.Key == Key.OemPeriod) && e.KeyboardDevice.Modifiers != ModifierKeys.Shift)
            {
                if (txt.Text.Contains(".") && e.Key == Key.OemPeriod)
                {
                    e.Handled = true;
                    return;
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}