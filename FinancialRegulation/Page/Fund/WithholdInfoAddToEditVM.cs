using System;

namespace FinancialRegulation.ViewModel
{
    public class WithholdInfoAddToEditVM : BaseEditVM<Message.Message109>
    {
        /// <summary>
        /// 客户端帮助
        /// </summary>
        public FundsRegulatoryClient.JG_PaymentClient client = FundsRegulatoryClient.JG_PaymentClient.Instance;

        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
        }

        #endregion 构造加载

        #region 变量属性

        //TODO:在此定义命令和属性

        #endregion 变量属性

        #region 命令定义

        //TODO:在此定义命令

        #endregion 命令定义

        #region 命令方法

        public override void OKExecute()
        {
            try
            {
                if (Check() && VMHelp.AskMessage("是否要进行扣款!"))
                {
                    string Time = VMHelp.NowTime;
                    CurrentObj.BusinessCode = "109";//交易代码
                    CurrentObj.PactNo = "";//协议编号  应该去一个协议编号  2013年10月22日10:46:42 没有协议编号
                    CurrentObj.SerialNo = VMHelp.ServiceNo;//流水号
                    CurrentObj.Account = VMHelp.SYSCONFIG.JGAccount;//监管账户
                    CurrentObj.BusinessTime = Time;//交易时间
                    CurrentObj.Time = Time;//扣款时间

                    Message.Message009 response = null;// SendMessage<Message.Message009>(CurrentObj);
                    if (response != null && response.ExceptionCode != null && response.ExceptionCode == Tools.PublicData.ResponseSuccess)
                    {
                        //FundsRegulatoryClient.JG_PaymentSrv.JG_PaymentInfo model = new FundsRegulatoryClient.JG_PaymentSrv.JG_PaymentInfo();
                        //model.PA_ID = VMHelp.GUID;
                        //model.PA_Person = VMHelp.Person;
                        //model.PA_fkfzh = CurrentObj.Account;//付款方账户
                        //model.PA_fkBank = VMHelp.SYSCONFIG.BankCode;//付款张银行
                        //model.PA_zfje = CurrentObj.Money;//支付金额
                        //model.PA_Remark = CurrentObj.Reason;//原因
                        //model.PA_zfrq = DateTime.Parse(Time);//支付时间
                        //model.PA_zhye = CurrentObj.Balances;
                        //model.PA_zflb = Tools.PublicData.Payment_lw;//支付类别 3 扣款
                        //model.PA_BankCode = VMHelp.PointCode;
                        //if (client.Add(model))
                        //{
                        //    VMHelp.ShowMessage("扣款成功", true);
                        //}
                        //else
                        //{
                        //    VMHelp.ShowMessage("扣款失败", false);
                        //}
                    }
                    else if (response != null && response.ExceptionCode != null && response.ExceptionCode != Tools.PublicData.ResponseSuccess)
                    {
                        VMHelp.ShowMessage(response.ExceptionMessage, false);
                    }
                }
            }
            catch (Exception ex)
            {
                VMHelp.ShowMessage(ex.Message, false);
            }
        }
        public override bool Check()
        {
            CheckHelper.CustomerCheck<decimal>(CurrentObj.Money, "扣款金额不能小于1", (i) => i > 0);
            //CheckHelper.CustomerCheck<decimal>(CurrentObj.Balances, "账户余额不能小于1", (i) => i > 0);
            return true;
        }
        #endregion 命令方法
    }
}