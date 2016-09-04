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
using System.Windows.Shapes;

namespace FinancialRegulation.Page.ProtocolManage
{
    /// <summary>
    /// ProtocolDepositWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ProtocolPamentWindow : Window
    {
        public ProtocolPamentWindow(string xybh)
        {
            InitializeComponent();
            ProtocolPamentVM vm = new ProtocolPamentVM(xybh);
            this.DataContext = vm;
        }
    }
}
