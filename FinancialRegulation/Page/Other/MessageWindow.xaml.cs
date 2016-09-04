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

namespace FinancialRegulation.Page
{
    /// <summary>
    /// 提示输入信息窗体 
    /// </summary>
    public partial class MessageWindow : Window
    {
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="o"></param>
        public MessageWindow()
        {
            InitializeComponent();
        }

        private object result;
        /// <summary>
        /// 返回值
        /// </summary>
        public object Result
        {
            get { return result; }
            set { result = value; }
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    //消息窗体  通知消息 填入消息 
}
