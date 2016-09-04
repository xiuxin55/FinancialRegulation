using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using FundsRegulatoryClient.JG_PaymentSrv;
using System.Collections;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using System.Collections.ObjectModel;
using FundsRegulatoryClient.RegulatorySrv;

namespace FinancialRegulation.Page.ProtocolManage
{
    public class ProtocolPamentVM : NotificationObject
    {
        public ProtocolPamentVM(string xybh)
        {
            this.xybh = xybh;
            GetPaMentDetail();
        }

        #region 属性

        private Hashtable ht;
        List<FundsRegulatoryClient.JG_PaymentSrv.DictionaryEntry> lst;
        public string xybh { get; set; }

        private ObservableCollection<JG_PaymentInfo> _jpInfo;

        public ObservableCollection<JG_PaymentInfo> JpInfo
        {
            get { return _jpInfo; }
            set
            {
                _jpInfo = value;
                this.RaisePropertyChanged("JpInfo");
            }
        }
        
        #endregion

        public ICommand GetPamentDetailDelegate { get; set; }

        #region 命令

        #endregion

        #region 方法

        /// <summary>
        /// 根据协议编号获取存款列表
        /// </summary>
        public void GetPaMentDetail()
        {
            ht = new Hashtable();
            lst = new List<FundsRegulatoryClient.JG_PaymentSrv.DictionaryEntry>();
            ht.Add("xybh", xybh);

            FundsRegulatoryClient.JG_PaymentSrv.DictionaryEntry de;

            foreach (string key in ht.Keys)
            {

                de = new FundsRegulatoryClient.JG_PaymentSrv.DictionaryEntry();

                de.Key = key;

                de.Value = ht[key];

                lst.Add(de);

            }
            //JpInfo = FundsRegulatoryClient.JG_PaymentClient.Instance.SelectThePaymentInfoByInterval(lst.ToArray());
        }

        #endregion
    }
}