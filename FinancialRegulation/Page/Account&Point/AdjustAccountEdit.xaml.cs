using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace FinancialRegulation.Page
{
    /// <summary>
    /// O1.xaml 的交互逻辑
    /// </summary>
    public partial class AdjustAccountEdit : BaseWindow
    {
        public AdjustAccountEdit(FinancialRegulation.ViewModel.AdjustAccountEditVM vm)
        {
            InitializeComponent();
            vm.windowClose = CloseWindow;
            this.DataContext = vm;
        }
    }
}

