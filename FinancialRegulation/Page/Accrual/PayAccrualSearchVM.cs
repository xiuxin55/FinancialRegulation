using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialRegulation.ViewModel
{
    /// <summary>
    /// 利息支付检索 返回104信息 检索数据库
    /// </summary>
    public class PayAccrualSearchVM : BaseEditVM<object>
    {
        /// <summary>
        /// 客户端帮助
        /// </summary>
        public object client;

        #region 构造加载
        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {

        }
        #endregion

        #region 变量属性
        //TODO:在此定义命令和属性
        #endregion

        #region 命令定义
        //TODO:在此定义命令
        #endregion

        #region 命令方法

        public override void OKExecute()
        {
            windowClose();
            //TODO:实现确认按钮
        }
        #endregion

    }
}
