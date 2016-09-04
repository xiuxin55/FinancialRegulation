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
using FundsRegulatoryClient.JG_DepositSrv;
using FinancialRegulation.Page.Other;
using System.Windows.Forms;
using System.Collections;

namespace FinancialRegulation.Page.ProtocolManage
{
    public class ProtocolDepositVM : NotificationObject
    {
        public ProtocolDepositVM()
        {
            ResponsePageCommand = new DelegateCommand(ResponsePage);
            GetDepositDetailDelegate = new DelegateCommand(GetDepositDetail);
            //LoadData();
        }

        #region 属性

        private string qybh;
        private string ckr;
        private DateTime? begain = null;
        private DateTime? end = null;
        public string xybh { get; set; }

        List<FundsRegulatoryClient.JG_DepositSrv.DictionaryEntry> lst;

        public ICommand GetDepositDetailDelegate { get; set; }
        public ICommand ResponsePageCommand { get; set; }

        private List<DepositFund> _jdInfo;

        public List<DepositFund> JdInfo
        {
            get
            {
                return _jdInfo;
            }
            set
            {
                _jdInfo = value;
                this.RaisePropertyChanged("JdInfo");
            }
        }

        #endregion

        #region 命令

        #endregion

        #region 方法


        private void ResponsePage()
        {
            QueryWindow qw = new QueryWindow();
            if (true == qw.ShowDialog())
            {
                qybh = qw.CondationDS.Tables[0].Rows[0]["dtQybh"].ToString();
                ckr = qw.CondationDS.Tables[0].Rows[0]["dtCkr"].ToString();
                if (qw.CondationDS.Tables[0].Rows[0]["dtBegin"].ToString() == "" || qw.CondationDS.Tables[0].Rows[0]["dtBegin"] == null)
                {
                    begain = null;
                    end = null;
                }
                else
                {
                    begain = Convert.ToDateTime(qw.CondationDS.Tables[0].Rows[0]["dtBegin"]);
                    end = Convert.ToDateTime(qw.CondationDS.Tables[0].Rows[0]["dtEnd"].ToString());
                }
                GetDepositDetail();
            }
        }

        private void LoadData()
        {
            GetDepositDetail();
        }

        /// <summary>
        /// 根据协议编号获取存款列表
        /// </summary>
        public void GetDepositDetail()
        {
            Hashtable ht = new Hashtable();

            ht.Add("xybh", xybh);
            ht.Add("Qybh", qybh);
            ht.Add("Ckr", ckr);
            ht.Add("StartDate", begain);
            ht.Add("EndDate", end);

            lst = new List<FundsRegulatoryClient.JG_DepositSrv.DictionaryEntry>();

            FundsRegulatoryClient.JG_DepositSrv.DictionaryEntry de;

            foreach (string key in ht.Keys)
            {

                de = new FundsRegulatoryClient.JG_DepositSrv.DictionaryEntry();

                de.Key = key;

                de.Value = ht[key];

                lst.Add(de);

            }
            JdInfo = FundsRegulatoryClient.JG_DepositClient.Instance.SelectDepositInfoList(lst.ToArray());
        }

        #endregion
    }
}