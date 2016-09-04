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
using System.Data;

namespace FinancialRegulation.Page.Other
{
    /// <summary>
    /// QueryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class QueryWindow : Window
    {
        public QueryWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetCondation();
        }

        private DataSet condationDS;
        public DataSet CondationDS
        {
            get { SetCondation(); return condationDS; }
        }

        private void SetCondation()
        {
            condationDS = new DataSet();
            DataTable dt = new DataTable("Condition");
            condationDS.Tables.Add(dt);

            dt.Columns.Add("dtQybh");
            dt.Columns.Add("dtCkr");
            dt.Columns.Add("dtBegin");
            dt.Columns.Add("dtEnd");
            dt.Rows.Add(dt.NewRow());
            this.condationDS.Tables["Condition"].Rows[0]["dtQybh"] = txtQybh.Text.ToString().Trim();
            this.condationDS.Tables["Condition"].Rows[0]["dtCkr"] = txtCkr.Text.ToString().Trim();
            if (cbxCheck.IsChecked == true)
            {
                this.condationDS.Tables["Condition"].Rows[0]["dtBegin"] = dtBegin.Text.ToString();
                this.condationDS.Tables["Condition"].Rows[0]["dtEnd"] = dtEnd.Text.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
