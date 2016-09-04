using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using FundsRegulatoryClient.JG_SpvProtocolSrv;
using System.Collections.ObjectModel;
using Microsoft.Practices.Prism.Commands;
using System.Windows;
using System.Windows.Input; 

namespace FinancialRegulation.Page.ProtocolManage
{
    public class ProtocolManageVM : NotificationObject
    {
        public ProtocolManageVM()
        {
            SearchCommand = new DelegateCommand(Search);
            ResponsePage = new DelegateCommand(Response);
            ResponseDepositPageCommand = new DelegateCommand(ResponseDepositPage);
            ResponsePaymentPageCommand = new DelegateCommand(ResponsePaymentPage);
        }

        #region 属性
        private List<JG_SpvProtocol> protocolLst;

        public List<JG_SpvProtocol> ProtocolLst
        {
            get { return protocolLst; }
            set { protocolLst = value;
            this.RaisePropertyChanged("ProtocolLst");}
        }

        private JG_SpvProtocol currentProtocl;

        public JG_SpvProtocol CurrentProtocl
        {
            get { return currentProtocl; }
            set { currentProtocl = value;
            this.RaisePropertyChanged("CurrentProtocl");
            }
        }

        private string currentProtocolNo = null;

        public string CurrentProtocolNo
        {
            get { return currentProtocolNo; }
            set { currentProtocolNo = value;
            this.RaisePropertyChanged("CurrentProtocolNo");
            }
        }

        private string currentCorp = null;

        public string CurrentCorp
        {
            get { return currentCorp; }
            set { currentCorp = value;
            this.RaisePropertyChanged("CurrentCorp");
            }
        }

        private string currentItem = null;

        public string CurrentItem
        {
            get { return currentItem; }
            set
            {
                currentItem = value;
                this.RaisePropertyChanged("CurrentItem");
            }
        }
        #endregion

        #region 命令
        public DelegateCommand SearchCommand { get; set; }

        public DelegateCommand ResponsePage { get; set; }

        public ICommand ResponseDepositPageCommand { get; set; }

        public ICommand ResponsePaymentPageCommand { get; set; }

        #endregion

        #region 方法
        private void Search()
        {
            JG_SpvProtocol js = new JG_SpvProtocol() { SP_XYBH = CurrentProtocolNo, SP_CorpName = CurrentCorp, SP_ItemName = CurrentItem };
            ProtocolLst = FundsRegulatoryClient.JG_SpvProtocolClient.Instance.GetProtocolByCondition(js);
        }

        private void ResponseDepositPage()
        {
            if (string.IsNullOrEmpty(CurrentProtocl.SP_XYBH)) return;
            ProtocolDepositWindow pdw = new ProtocolDepositWindow(CurrentProtocl.SP_XYBH);
            pdw.ShowDialog();
        }

        private void ResponsePaymentPage()
        {
            if (string.IsNullOrEmpty(CurrentProtocl.SP_XYBH)) return;
            ProtocolPamentWindow ppw = new ProtocolPamentWindow(CurrentProtocl.SP_XYBH);
            ppw.ShowDialog();
        }

        private void Response()
        {
            //if (CurrentProtocl==null)
            //{
            //    MessageBox.Show("请选择要进行不明账款缴存的协议!");
            //    return;
            //}
            //Page.UnKnownInfoAdd ukInfo = new UnKnownInfoAdd(CurrentProtocl);
            //ukInfo.ShowDialog();
        }

        #endregion
    }
}
