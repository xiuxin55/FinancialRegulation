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
using Srv = BaseClient.BaseManageSrv;
using System.Xml;
using System.Reflection;
using AvalonDock;
using System.IO;
using FinancialRegulation;
using lgsv=BaseClient.LoginSrv;
using MahApps.Metro.Controls;


namespace MainFrame
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Action<lgsv.MenuItem> MenuDoubleClickAction;

        public lgsv.UserInfo ui  { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
      

            MenuDoubleClickAction = new Action<lgsv.MenuItem>(MenuDoubleClick);
            try
            {
                ui = (lgsv.UserInfo)Common.CommonData.GetInstance().ListCheckUesrInfo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void MenuDoubleClick(lgsv.MenuItem mi)
        {
            if (null == mi) return;
            if (null != mi.InvokingConfig && "" != mi.InvokingConfig)
            {
                ShowWindow(mi.InvokingConfig);
            }
        }

        private void ShowWindow(string xmlstr)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlstr);
            XmlNodeList xlist = xdoc.GetElementsByTagName("DSPUSERCONTROL");
            string dllPath = "";
            string dllName = "";

            try
            {
                //if (!IsOpenTab(xlist.Item(0).ChildNodes[1].InnerText))
                {
                    dllPath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
                    dllName = xlist.Item(0).ChildNodes[0].InnerText;
                    dllPath = System.IO.Path.Combine(dllPath, dllName + ".dll");
                    Assembly ass = Assembly.LoadFrom(dllPath);
                    Type t = ass.GetType(xlist.Item(0).ChildNodes[1].InnerText);

                    foreach (DockableContent obj in DocPane.Items)
                    {
                        if (obj.GetType()==t )
                        {
                            obj.ShowAsDocument();
                            return;
                        }
                    }
                    ConstructorInfo constructors = null;
                    Type[] ts = null;
                    object[] parms = null;
                    if (xlist.Item(0).ChildNodes[2].InnerText == "")
                    {
                        ts = new Type[] { };
                        parms = new object[] { };
                    }
                    else
                    {
                        string[] parmlist = xlist.Item(0).ChildNodes[2].InnerText.Split(new char[] { ',' });
                        ts = new Type[parmlist.Length];
                        parms = new object[parmlist.Length];
                        for (int i = 0; i < parmlist.Length; i++)
                        {
                            ts[i] = Type.GetType(parmlist[i].Split(new char[] { ':' })[1]);
                            parms[i] = Convert.ChangeType(parmlist[i].Split(new char[] { ':' })[2], ts[i]);
                        }
                    }
                    constructors = t.GetConstructor(ts);
                    DockableContent f = constructors.Invoke(parms) as DockableContent;
                    if (f is BaseWindow)
                    {
                        BaseWindow bw = f as BaseWindow;
                        bw.DKM = dockingManager;
                    }
                    if (!DocPane.Items.Contains(f.ToString()))
                    {
                        DocPane.Items.Add(f);
                    }
                    f.ShowAsDocument();
                }
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show("未找到" + dllPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            menuWindow.menuitem = ui.menuitem.ToList<lgsv.MenuItem>();
            menuWindow.MenuItemDoubleClick = MenuDoubleClickAction;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
