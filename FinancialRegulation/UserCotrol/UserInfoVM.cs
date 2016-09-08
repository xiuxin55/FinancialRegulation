using AvalonDock;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using FinancialRegulation.ViewModel;
using System.Data;
using FundsRegulatoryClient;
using System.Windows;
using MahApps.Metro.Controls;
using FundsRegulatoryClient.JG_BranchesSrv;

namespace FinancialRegulation.UserCotrol
{
    /// <summary>
    ///新建或修改职责
    /// </summary>
    [System.Runtime.InteropServices.GuidAttribute("DEEF5BD6-8EB4-41E8-8849-48347844D170")]
    public class UserInfoVM : BaseManageVM<FundsRegulatoryClient.UserManageSrv.UserInfo>
    {
        /// <summary>
        /// 网点webservice
        /// </summary>
        public JG_BranchesClient WebsiteClient = JG_BranchesClient.Instance;

        #region 构造加载

        /// <summary>
        /// 加载命令
        /// </summary>
        public override void LoadCommand()
        {

            OKCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(OkExecute);
            DutyAllocateCommand = new Microsoft.Practices.Prism.Commands.DelegateCommand(DutyAllocateExecute);
            WebsiteList = WebsiteClient.Selects();
            
        }

        FundsRegulatoryClient.UserManageSrv.UserInfo _SelectUser;
        public FundsRegulatoryClient.UserManageSrv.UserInfo SelectUser
        {
            get
            {
                if (_SelectUser == null)
                {
                    _SelectUser = new FundsRegulatoryClient.UserManageSrv.UserInfo();
                }
                return _SelectUser;
            }
            set
            {
                _SelectUser = value;
                RaisePropertyChanged("SelectUser");
            }
        }

        #endregion 构造加载

        #region 变量属性
        private ObservableCollection<JG_BranchesInfo> websiteList;
        public ObservableCollection<JG_BranchesInfo> WebsiteList
        {
            get
            {
                return websiteList;
            }

            set
            {
                websiteList = value;
                RaisePropertyChanged("WebsiteList");
            }
        }
        public MetroWindow Owner { get; set; }

        private string repeatePassword;
        /// <summary>
        /// 重复的密码
        /// </summary>
        public string RepeatePassword
        {
            get
            {
                return repeatePassword;
            }

            set
            {
                repeatePassword = value;
                RaisePropertyChanged("RepeatePassword");
            }
        }

        ObservableCollection<DutyModel> _OwnDutyList;
        public ObservableCollection<DutyModel> OwnDutyList
        {
            get
            {
                return _OwnDutyList;
            }
            set
            {
                _OwnDutyList = value;
                RaisePropertyChanged("OwnDutyList");
            }

        }
        #endregion 变量属性

        #region 命令定义


        public Microsoft.Practices.Prism.Commands.DelegateCommand OKCommand { get; set; }
        /// <summary>
        /// 职责分配命令
        /// </summary>
        public Microsoft.Practices.Prism.Commands.DelegateCommand DutyAllocateCommand { get; set; }

       


        #endregion 命令定义

        #region 命令方法
        public void OkExecute()
        {
           //if(SelectUser != null)
           // {
           //     FundsRegulatoryClient.UserManageSrv.UserInfo ui = new FundsRegulatoryClient.UserManageSrv.UserInfo();
           //     dt.DutyID = SelectDuty.DutyId?? Guid.NewGuid().ToString();
           //     dt.DutyCode = SelectDuty.DutyCode;
           //     dt.DutyName = SelectDuty.DutyName;
           //     dt.Describe = SelectDuty.DutyDescribe;
           //     try
           //     {
           //         if (SelectDuty.DutyId != null)
           //         {
           //             if (DutyManageClient.Current.UpdateDuty(dt) == "1")
           //             {
           //                 MessageBox.Show("操作成功");
           //             }
           //         }
           //         else
           //         {
           //             if (DutyManageClient.Current.InsertDuty(dt) == "1")
           //             {
           //                 MessageBox.Show("操作成功");
           //             }
           //         }
           //         if(Owner!=null)
           //         {
           //             Owner.Close();
           //         }
           //     }
           //     catch (Exception ex)
           //     {
           //         throw new Exception(ex.ToString());
           //     }
           // }
        }
        private void DutyAllocateExecute()
        {
            DutySet  dl = new DutySet();
            dl.VM.UserID = SelectUser.UserId;
            dl.VM.InitialData();
            dl.ShowDialog();
        }
        #endregion 命令方法
        public  void LoadOwnDutyList()
        {
            DataSet ds = UserDutyManagerClient.Current.GetUserDutyByID(SelectUser.UserId);
            OwnDutyList = new ObservableCollection<DutyModel>(DataSetToModel.UserDutyToModel(ds,0));
        }

    }
}