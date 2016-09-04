using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FundsRegulatoryClient.JG_DepositSrv;
namespace FinancialRegulation.ViewModel
{
    public class AccrualManageVM : BaseManageVM<FundsRegulatoryClient.JG_DepositSrv.DepositFund>
    {
        /// <summary>
        /// 客户端访问对象
        /// </summary>
      /*  public FundsRegulatoryClient.JG_DepositClient client = FundsRegulatoryClient.JG_DepositClient.Instance;

        #region 构造加载
        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
        }
        public override void LoadData()
        {
            FlushExecute();
        }
        #endregion

        #region 变量属性

        private decimal? _accrualMoney;
        /// <summary>
        /// 结息金额
        /// </summary>
        public decimal? AccrualMoney
        {
            get { return _accrualMoney; }
            set
            {
                _accrualMoney = value;
                RaisePropertyChanged("AccrualMoney");
            }
        }
        private decimal? _balance;
        /// <summary>
        /// 账户余额
        /// </summary>
        public decimal? Balance
        {
            get { return _balance; }
            set
            {
                _balance = value;
                RaisePropertyChanged("Balance");
            }
        }


        #endregion

        #region 命令定义

        #endregion

        #region 命令方法

        /// <summary>
        /// 添加方法
        /// </summary>
        public override void AddExecute()
        {
            try
            {
                Base.Check.CheckHelp.Current.CustomerCheck<decimal?>(AccrualMoney, "结息金额不正确!", (i) => i.Value >= 0);
                Base.Check.CheckHelp.Current.CustomerCheck<decimal?>(Balance, "账户余额不正确!", (i) => i.Value >= 0);

                string time = VMHelp.NowTime;
                Message.Message108 request = new Message.Message108();
                request.Money = AccrualMoney.Value;
                request.Time = time;
                request.Balances = Balance.Value;
                request.PactNo = "";//协议编号 为空
                request.SerialNo = VMHelp.ServiceNo;
                request.Account = VMHelp.SYSCONFIG.JGAccount;//监管账户 结息账户
                request.BusinessCode = "108";
                request.BusinessTime = time;
                Message.Message008 msg=null;// = SendMessage<Message.Message008>(request);

                if (msg != null && msg.ExceptionCode != null && msg.ExceptionCode == Tools.PublicData.ResponseSuccess)
                {
                    if (CurrentObj != null) CurrentObj = null; //创建一个新的对象
                    CurrentObj._DE_ID = Guid.NewGuid().ToString();
                    CurrentObj._DE_dwbh = VMHelp.SYSCONFIG.BankCode;//银行代码
                    CurrentObj._DE_ckje = AccrualMoney;//存款金额
                    CurrentObj._DE_ckrq = DateTime.Parse(time);//存款日期
                    CurrentObj._DE_Person = VMHelp.Person;
                    CurrentObj._DE_cklsh = VMHelp.ServiceNo;//存款流水
                    CurrentObj._DE_BankCode = VMHelp.PointCode;//网点代码
                    CurrentObj._DE_zhye = Balance;//账户余额
                    bool result = client.PayAccrual(CurrentObj);
                    VMHelp.ShowMessage("结息" + (result ? "成功" : "失败"), result);
                    FlushExecute();
                }
                else if (msg != null && msg.ExceptionCode != null && msg.ExceptionCode != Tools.PublicData.ResponseSuccess)
                {
                    VMHelp.ShowMessage(msg.ExceptionMessage, false);
                }
            }
            catch (FinancialRegulation.ClientException.CheckException ex)
            {
                VMHelp.ShowMessage(ex.Message, false);
            }
            catch (Exception ex)
            {
                SendExcetpion(ex);
            }
        }
        /// <summary>
        /// 刷新方法
        /// </summary>
        public override void FlushExecute()
        {
            Models = client.SelectPayAccrual();
            Models.Sort((left, right) =>
            {
                if (left._DE_ckrq > right._DE_ckrq)
                    return -1;
                else if (left._DE_ckrq == right._DE_ckrq)
                    return 0;
                else
                    return 1;
            });

        }
        #endregion


        public override void ModifyExecute()
        {
            throw new NotImplementedException();
        }

        public override void DeleteExecute()
        {
            throw new NotImplementedException();
        }

        public override void DestroyAccountExecute()
        {
            throw new NotImplementedException();
        }*/
        public override void LoadCommand()
        {
            throw new NotImplementedException();
        }
    }
}
