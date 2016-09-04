using System;
using System.Collections.Generic;
using System.Transactions;

namespace FinancialRegulation.ViewModel
{
    public class AdjustAccountVM : BaseManageVM<object>, ISearch
    {
        /// <summary>
        /// 客户端访问对象
        /// </summary>
        public FundsRegulatoryClient.JG_AdjustClient client = FundsRegulatoryClient.JG_AdjustClient.Current;

        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
            //查询命令
            SearchCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(SearchExecute);
        }
        public override void LoadData()
        {
            FlushExecute();
        }
        #endregion 构造加载

        #region 变量属性
        /// <summary>
        /// 查询标志 调账状态
        /// </summary>
        public int SearchKey { get; set; }

        private System.Data.DataTable _models;

        /// <summary>
        /// 改掉父类的实体 获取到数据表格
        /// </summary>
        new public System.Data.DataTable Models
        {
            get { return _models; }
            set
            {
                _models = value;
                RaisePropertyChanged("Models");
            }
        }
        private System.Data.DataRowView _curModel;

        /// <summary>
        /// 改掉父类的实体 获取到数据表格
        /// </summary>
        new public System.Data.DataRowView CurModel
        {
            get { return _curModel; }
            set
            {
                _curModel = value;
                RaisePropertyChanged("CurModel");
            }
        }

        #endregion 变量属性

        #region 命令定义

        private Microsoft.Practices.Prism.Commands.DelegateCommand _searchCommand;

        public Microsoft.Practices.Prism.Commands.DelegateCommand SearchCommand
        {
            get
            {
                return _searchCommand;
            }
            set
            {
                _searchCommand = value;
                RaisePropertyChanged("SearchCommand");
            }
        }

        #endregion 命令定义

        #region 命令方法

        /// <summary>
        /// 添加方法
        /// </summary>
        public override void AddExecute()
        {
            if (this.CurModel==null||this.CurModel[0] == DBNull.Value||this.CurModel[0] == null) return;
            //TODO: 不能点击已调账
            AdjustAccountEditVM vm = new AdjustAccountEditVM();
            vm.CurrentObj = this.CurModel;
            Page.AdjustAccountEdit page = new Page.AdjustAccountEdit(vm);
            page.ShowDialog();
        }

        /// <summary>
        /// 刷新方法
        /// </summary>
        public override void FlushExecute()
        {
            Models = client.GetJG_AdjustX();
        }

        private string _state;
        /// <summary>
        /// 选择状态
        /// </summary>
        public string State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }
        /// <summary>
        /// 查询
        /// </summary>
        public void SearchExecute()
        {
            Models = Get(State);
        }
        /// <summary>
        /// 转换到状态
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private System.Data.DataTable Get(string key)
        {
            switch (key)
            {
                case "全部": return client.GetJG_AdjustA();
                case "未调账": return client.GetJG_AdjustX();
                case "已调账": return client.GetJG_AdjustO();
                default: return client.GetJG_AdjustA();
            }
        }
        #endregion 命令方法

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
        }
    }
}