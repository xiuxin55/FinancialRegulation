using System;
using System.Transactions;
namespace FinancialRegulation.ViewModel
{
    public class AdjustAccountEditVM : BaseEditVM<object>
    {
        /// <summary>
        /// 客户端帮助
        /// </summary>
        public FundsRegulatoryClient.JG_AdjustClient client = FundsRegulatoryClient.JG_AdjustClient.Current;

        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
        }

        #endregion 构造加载

        #region 变量属性

        private System.Data.DataRowView _currentObj;

        public System.Data.DataRowView CurrentObj
        {
            get
            {
                return _currentObj;
            }
            set { _currentObj = value; }
        }

        private decimal? fkfMoney;

        public decimal? FkfMoney
        {
            get { return fkfMoney; }
            set
            {
                fkfMoney = value;
                RaisePropertyChanged("FkfMoney");
            }
        }

        private decimal? skfMoney;

        public decimal? SkfMoney
        {
            get { return skfMoney; }
            set
            {
                skfMoney = value;
                RaisePropertyChanged("SkfMoney");
            }
        }

        #endregion 变量属性

        #region 命令定义

        #endregion 命令定义

        #region 命令方法
        TransactionScope tran;

        public override void OKExecute()
        {
            Time = VMHelp.NowTime;
            //事务处理
            using (tran = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions() { IsolationLevel = IsolationLevel.ReadCommitted }))
            {
                if (!AdjustOutFund()) return;//调账退款
                AdjustAccount();//调账
            }
        }
        string Time;
        /// <summary>
        /// 调账退款完成
        /// </summary>
        private bool AdjustOutFund()
        {
           /* Message.BaseMessageRequest msg = GetMessage("118");

            Message.Message018 response = SendMessage<Message.Message018>(msg);
            if (response != null && !string.IsNullOrEmpty(response.ExceptionCode) && response.ExceptionCode == Tools.PublicData.ResponseSuccess)
            {
                //添加支付
                if (FundsRegulatoryClient.JG_PaymentClient.Instance.AdjustAccountJG_Payment(
                    new FundsRegulatoryClient.JG_PaymentSrv.JG_PaymentInfo()
                    {
                        PA_ID = VMHelp.GUID,
                        PA_zfqrlsh = msg.SerialNo ,//支付确认流水号
                        PA_Person = VMHelp.Person,//支付操作人
                        PA_lc = Tools.PublicData.Payment_Ly,//流程
                        PA_yhzfrq = DateTime.Parse(Time),//银行支付日期
                    }))
                {
                    //注销存款为调账
                    if (FundsRegulatoryClient.JG_DepositClient.Instance.Update(new FundsRegulatoryClient.JG_DepositSrv.JG_DepositInfo()
                    {
                        _DE_ID = CurrentObj["ckid"].ToString(),
                        _DE_cklb = Tools.PublicData.Deposit_Laa
                    }))
                    {
                        return true;
                    }
                }
                return false;
            }
            else if (response.ExceptionCode != Tools.PublicData.ResponseSuccess)
            {
                VMHelp.ShowMessage(response.ExceptionMessage, false);
                return false;
            }
            else { return false; }*/
            return false;
        }

        /// <summary>
        /// 调账完成
        /// </summary>
        private void AdjustAccount()
        {
          /*  Message.BaseMessageRequest msg = GetMessage("120");

            Message.Message020 response = null;//= SendMessage<Message.Message020>(msg);
            if (response != null && !string.IsNullOrEmpty(response.ExceptionCode) && response.ExceptionCode == Tools.PublicData.ResponseSuccess)
            {
                //添加新的存款
                if (FundsRegulatoryClient.JG_DepositClient.Instance.Add(new FundsRegulatoryClient.JG_DepositSrv.DepositFund()
                {
                    _DE_ID = VMHelp.GUID,
                    _DE_xybh = CurrentObj["nxybh"].ToString(),//新协议编号
                    _DE_qybh = CurrentObj["htbah"].ToString(),//合同备案号
                    _DE_ckr = CurrentObj["ckr"].ToString(),//存款人
                    _DE_dwbh = CurrentObj["ckyh"].ToString().Substring(0,2),//银行提取前两位
                    _DE_ckxz = CurrentObj["jexz"].ToString(),//存款性质
                    _DE_ckrq = DateTime.Parse(Time),//存款日期
                    _DE_zhye = Convert.ToDecimal(CurrentObj["zhye"]),//账户余额
                    _DE_Person = CurrentObj["czr"].ToString(),//操作人
                    _DE_cklsh = msg.SerialNo,//存款流水号 这个新保存的存款流水号是发送过去的流水号
                    _DE_cklb = Tools.PublicData.Deposit_Laa,//存款类别
                    _DE_BankCode = CurrentObj["ckyh"].ToString(),//网点编号
                    _DE_ckje = Convert.ToDecimal(CurrentObj["fkje"]),//存款金额
                    //TODO:新的存款属性

                }))
                {
                    //变更调账 存款账号也应该变
                    if (client.Update(new FundsRegulatoryClient.JG_AdjustSrv.JG_AdjustInfo()
                    {
                        JA_Qrr = VMHelp.Person,
                        JA_LC = Tools.PublicData.AdjustAccount_Lf,
                        JA_QrTime = DateTime.Parse(Time),
                        JA_ID = CurrentObj["id"].ToString()
                    }))
                    {
                        tran.Complete();//完成整段事务
                        VMHelp.ShowMessage("调账成功", true);
                        if(windowClose!=null)windowClose();
                    }
                }

            }
            else if (response.ExceptionCode != Tools.PublicData.ResponseSuccess)
            {
                VMHelp.ShowMessage("错误信息:"+response.ExceptionMessage, false);
            }*/
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageID"></param>
        /// <returns></returns>
        private Message.BaseMessageRequest GetMessage(string messageID)
        {
            dynamic msg = null;

            if (messageID == "120")
            {
                msg = new Message.Message120();
            }
            else if (messageID == "118")
            {
                msg = new Message.Message118();
            }
            else
            {
                return null;
            }

            msg.BusinessCode = messageID;

            msg.BusinessTime = Time;
            msg.SerialNo = VMHelp.ServiceNo; //这个发送过去的流水号表示新的流水号

            msg.ContractRecordNo = CurrentObj["htbah"].ToString();//合同备案号
            msg.DepositNo = CurrentObj["cklsh"].ToString();//存款流水号
            msg.Money = Convert.ToDecimal(CurrentObj["fkje"]);//存款金额
            msg.NatureOfFunding = CurrentObj["jexz"].ToString();//资金性质
            msg.FromBbank = CurrentObj["ckyh"].ToString();//存款银行
            msg.Depositor = CurrentObj["ckr"].ToString();//存款人
            msg.ReceiveAccount = CurrentObj["tkzh"].ToString();//退款账号
            msg.PaymentAccount = CurrentObj["fkzh"].ToString();//付款账号

            msg.RABalances = FkfMoney.Value;
            msg.PABalances = SkfMoney.Value;
            msg.BankCode = VMHelp.BankCode;
            return msg;
        }

        #endregion 命令方法
    }
}