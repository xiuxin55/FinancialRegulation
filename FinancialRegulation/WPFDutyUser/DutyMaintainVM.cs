using AvalonDock;
using System;
using System.Linq;
using System.Collections.Generic;
using FundsRegulatoryClient.JG_DepositSrv;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using FinancialRegulation.Page.Fund;
using FinancialRegulation.ViewModel;

namespace FinancialRegulation.WPFDutyUser
{
    /// <summary>
    ///z资金缴存信息
    /// </summary>
    [System.Runtime.InteropServices.GuidAttribute("DEEF5BD6-8EB4-41E8-8849-48347844D170")]
    public class DutyMaintainVM : BaseManageVM<DutyModel>
    {


        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {
            AddCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(AddExecute);
            ModifyCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(ModifyExecute);
            SearchCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(SearchExecute);
            DeleteCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(DeleteExecute);
            AuthorizeCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(AuthorizeExecute);
            NewFlushCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(LoadData);
        }
        ObservableCollection<DutyModel> _DutyMaintainList;
        public  ObservableCollection<DutyModel> DutyMaintainList
        {
            get
            {
                return _DutyMaintainList;
            }
            set
            {
                _DutyMaintainList = value;
                RaisePropertyChanged("DutyMaintainList");
            }
        }
        public override void LoadData()
        {
            
        }

        #endregion 构造加载

        #region 变量属性

        private string _condition;

        /// <summary>
        /// 查询条件
        /// </summary>
        public string Condition
        {
            get { return _condition; }
            set
            {
                _condition = value;
                RaisePropertyChanged("Condition");
            }
        }

        private ComboBoxItem jkzh;

        

        #endregion 变量属性

        #region 命令定义

   
        private Microsoft.Practices.Prism.Commands.DelegateCommand _searchCommand;
        private Microsoft.Practices.Prism.Commands.DelegateCommand _authorizeCommand;//授权命令
        private Microsoft.Practices.Prism.Commands.DelegateCommand newFlushCommand;//新的刷新命令

        public Microsoft.Practices.Prism.Commands.DelegateCommand NewFlushCommand
        {
            get { return newFlushCommand; }
            set { newFlushCommand = value; this.RaisePropertyChanged("NewFlushCommand"); }
        }
        

        /// <summary>
        /// 授权命令
        /// </summary>
        public Microsoft.Practices.Prism.Commands.DelegateCommand AuthorizeCommand
        {
            get { return _authorizeCommand; }
            set { _authorizeCommand = value; }
        }

       
        /// <summary>
        /// 查询筛选
        /// </summary>
        public Microsoft.Practices.Prism.Commands.DelegateCommand SearchCommand
        {
            get
            {
                return _searchCommand;
            }
            set
            {
                _searchCommand = value;
            }
        }

        #endregion 命令定义

        #region 命令方法
        public override void AddExecute()
        {
           
        }
        public override void ModifyExecute()
        {

        }
        public override void DeleteExecute()
        {

        }
        private void SearchExecute()
        {

        }
        private void AuthorizeExecute()
        {

        }
        #endregion 命令方法

        
    }

    public class DutyModel
    {
        public string DutyId { get; set; }
        public string DutyCode { get; set; }
        public string DutyName { get; set; }
        public string DutyDescribe { get; set; }
    }
}