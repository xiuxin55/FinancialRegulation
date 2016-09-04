using System;

namespace FinancialRegulation.ViewModel
{
    public class ReadCongEditVM : BaseEditVM<FundsRegulatoryClient.JG_DepositSrv.DepositFund>
    {
        /// <summary>
        /// 客户端帮助
        /// </summary>
        public FundsRegulatoryClient.JG_DepositClient client = FundsRegulatoryClient.JG_DepositClient.Instance;

        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
        }

        public override void LoadData()
        {
        }

        #endregion 构造加载

        #region 变量属性

        //TODO:在此定义命令和属性

        #endregion 变量属性
        private decimal? _balances;
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal? Balances
        {
            get { return _balances; }
            set
            {
                _balances = value;
                RaisePropertyChanged("Balances");
            }
        }

        #region 命令定义

        //TODO:在此定义命令

        #endregion 命令定义

        #region 命令方法

        public override void OKExecute()
        {
            if (Check() && !VMHelp.AskMessage("是否进行红冲?")) return;

            Message.Message106 request = new Message.Message106();
            request.BankCode = VMHelp.BankCode;
            request.BusinessCode = "106";
            request.BusinessTime = VMHelp.NowTime;
            request.SerialNo = VMHelp.ServiceNo;
           // request.PactNo = CurrentObj._DE_xybh;
            //request.CorpCode = CurrentObj._DE_ckr;//企业名称 企业代码有问题，得去数据库联查哦
         //   request.DepositNo = CurrentObj._DE_cklsh;//存款流水号
         //   request.Money = CurrentObj._DE_ckje.Value;//存款金额
           // request.NatureOfFunding = CurrentObj._DE_ckxz;//资金性质
          //  request.Balances = Balances.Value;//账户余额
            //Message.NewMessage.Response.Response02 response = SendMessage<Message.NewMessage.Response.Response02>(request);
            //if (response != null && !string.IsNullOrEmpty(response) && response.ExceptionCode == Tools.PublicData.ResponseSuccess)
            //{
            //    CurrentObj._DE_cklb = Tools.PublicData.Deposit_Lrc;//存款类别变更
            //    CurrentObj._DE_BankCode = VMHelp.PointCode;
            //    if (client.Update(CurrentObj))//更新
            //    {
            //        VMHelp.ShowMessage("红冲成功!", true);
            //        windowClose();
            //    }
            //    else
            //    {
            //        VMHelp.ShowMessage("红冲失败", false);
            //    }
            //}
            //else if (response.ExceptionCode == "02")
            //{
            //    VMHelp.ShowMessage(response.ExceptionMessage, false);
            //}

        }
        public override bool Check()
        {
            CheckHelper.CustomerCheck<decimal?>(Balances, "账户余额不能是空或0", (i) => i != null && i > 0);
            return true;
        }

        #endregion 命令方法
    }
}