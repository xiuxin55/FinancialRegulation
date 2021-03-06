﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace FundsRegulatoryClient.DutyManageSrv {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DutyManageSrvSoap", Namespace="http://tempuri.org/")]
    public partial class DutyManageSrv : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsertDutyOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllDutyOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteDutyByIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateDutyOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DutyManageSrv() {
            this.Url = global::FundsRegulatoryClient.Properties.Settings.Default.HSIS_Client_DutyManageSrv_DutyManageSrv;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event InsertDutyCompletedEventHandler InsertDutyCompleted;
        
        /// <remarks/>
        public event GetAllDutyCompletedEventHandler GetAllDutyCompleted;
        
        /// <remarks/>
        public event DeleteDutyByIDCompletedEventHandler DeleteDutyByIDCompleted;
        
        /// <remarks/>
        public event UpdateDutyCompletedEventHandler UpdateDutyCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsertDuty", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string InsertDuty(Duty duty) {
            object[] results = this.Invoke("InsertDuty", new object[] {
                        duty});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertDutyAsync(Duty duty) {
            this.InsertDutyAsync(duty, null);
        }
        
        /// <remarks/>
        public void InsertDutyAsync(Duty duty, object userState) {
            if ((this.InsertDutyOperationCompleted == null)) {
                this.InsertDutyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertDutyOperationCompleted);
            }
            this.InvokeAsync("InsertDuty", new object[] {
                        duty}, this.InsertDutyOperationCompleted, userState);
        }
        
        private void OnInsertDutyOperationCompleted(object arg) {
            if ((this.InsertDutyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertDutyCompleted(this, new InsertDutyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllDuty", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAllDuty() {
            object[] results = this.Invoke("GetAllDuty", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllDutyAsync() {
            this.GetAllDutyAsync(null);
        }
        
        /// <remarks/>
        public void GetAllDutyAsync(object userState) {
            if ((this.GetAllDutyOperationCompleted == null)) {
                this.GetAllDutyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllDutyOperationCompleted);
            }
            this.InvokeAsync("GetAllDuty", new object[0], this.GetAllDutyOperationCompleted, userState);
        }
        
        private void OnGetAllDutyOperationCompleted(object arg) {
            if ((this.GetAllDutyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllDutyCompleted(this, new GetAllDutyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteDutyByID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteDutyByID(string DutyID) {
            object[] results = this.Invoke("DeleteDutyByID", new object[] {
                        DutyID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteDutyByIDAsync(string DutyID) {
            this.DeleteDutyByIDAsync(DutyID, null);
        }
        
        /// <remarks/>
        public void DeleteDutyByIDAsync(string DutyID, object userState) {
            if ((this.DeleteDutyByIDOperationCompleted == null)) {
                this.DeleteDutyByIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteDutyByIDOperationCompleted);
            }
            this.InvokeAsync("DeleteDutyByID", new object[] {
                        DutyID}, this.DeleteDutyByIDOperationCompleted, userState);
        }
        
        private void OnDeleteDutyByIDOperationCompleted(object arg) {
            if ((this.DeleteDutyByIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteDutyByIDCompleted(this, new DeleteDutyByIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateDuty", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateDuty(Duty duty) {
            object[] results = this.Invoke("UpdateDuty", new object[] {
                        duty});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateDutyAsync(Duty duty) {
            this.UpdateDutyAsync(duty, null);
        }
        
        /// <remarks/>
        public void UpdateDutyAsync(Duty duty, object userState) {
            if ((this.UpdateDutyOperationCompleted == null)) {
                this.UpdateDutyOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateDutyOperationCompleted);
            }
            this.InvokeAsync("UpdateDuty", new object[] {
                        duty}, this.UpdateDutyOperationCompleted, userState);
        }
        
        private void OnUpdateDutyOperationCompleted(object arg) {
            if ((this.UpdateDutyCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateDutyCompleted(this, new UpdateDutyCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Duty {
        
        private string dutyIDField;
        
        private string dutyCodeField;
        
        private string dutyNameField;
        
        private string describeField;
        
        /// <remarks/>
        public string DutyID {
            get {
                return this.dutyIDField;
            }
            set {
                this.dutyIDField = value;
            }
        }
        
        /// <remarks/>
        public string DutyCode {
            get {
                return this.dutyCodeField;
            }
            set {
                this.dutyCodeField = value;
            }
        }
        
        /// <remarks/>
        public string DutyName {
            get {
                return this.dutyNameField;
            }
            set {
                this.dutyNameField = value;
            }
        }
        
        /// <remarks/>
        public string Describe {
            get {
                return this.describeField;
            }
            set {
                this.describeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void InsertDutyCompletedEventHandler(object sender, InsertDutyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertDutyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertDutyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void GetAllDutyCompletedEventHandler(object sender, GetAllDutyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllDutyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllDutyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void DeleteDutyByIDCompletedEventHandler(object sender, DeleteDutyByIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteDutyByIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteDutyByIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void UpdateDutyCompletedEventHandler(object sender, UpdateDutyCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateDutyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateDutyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591