﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace LifetimeIntegration.LifetimeApplications {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ApplicationManagementServiceSoap", Namespace="http://LifeTimeServices/ApplicationManagementService/")]
    public partial class ApplicationManagementService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback Application_ListOperationCompleted;
        
        private System.Threading.SendOrPostCallback Application_SetTag_BulkOperationCompleted;
        
        private System.Threading.SendOrPostCallback Solution_PackAndDownloadOperationCompleted;
        
        private System.Threading.SendOrPostCallback ApplicationPermissionLevel_ListOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ApplicationManagementService() {
            this.Url = global::LifetimeIntegration.Properties.Settings.Default.LifetimeIntegration_LifeTimeApplications_ApplicationManagementService;
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
        public event Application_ListCompletedEventHandler Application_ListCompleted;
        
        /// <remarks/>
        public event Application_SetTag_BulkCompletedEventHandler Application_SetTag_BulkCompleted;
        
        /// <remarks/>
        public event Solution_PackAndDownloadCompletedEventHandler Solution_PackAndDownloadCompleted;
        
        /// <remarks/>
        public event ApplicationPermissionLevel_ListCompletedEventHandler ApplicationPermissionLevel_ListCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://LifeTimeServices/ApplicationManagementService/Application_List", RequestNamespace="http://www.outsystems.com", ResponseNamespace="http://www.outsystems.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("Applications")]
        public ApplicationInfo[] Application_List(WebServiceSimpleAuthentication Authentication, out APIStatus Status, out bool Success) {
            object[] results = this.Invoke("Application_List", new object[] {
                        Authentication});
            Status = ((APIStatus)(results[1]));
            Success = ((bool)(results[2]));
            return ((ApplicationInfo[])(results[0]));
        }
        
        /// <remarks/>
        public void Application_ListAsync(WebServiceSimpleAuthentication Authentication) {
            this.Application_ListAsync(Authentication, null);
        }
        
        /// <remarks/>
        public void Application_ListAsync(WebServiceSimpleAuthentication Authentication, object userState) {
            if ((this.Application_ListOperationCompleted == null)) {
                this.Application_ListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplication_ListOperationCompleted);
            }
            this.InvokeAsync("Application_List", new object[] {
                        Authentication}, this.Application_ListOperationCompleted, userState);
        }
        
        private void OnApplication_ListOperationCompleted(object arg) {
            if ((this.Application_ListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Application_ListCompleted(this, new Application_ListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://LifeTimeServices/ApplicationManagementService/Application_SetTag_Bulk", RequestNamespace="http://www.outsystems.com", ResponseNamespace="http://www.outsystems.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Status")]
        public APIStatus Application_SetTag_Bulk(WebServiceSimpleAuthentication Authentication, EnvironmentApplicationTagList EnvironmentApplicationsForTag, out bool Success) {
            object[] results = this.Invoke("Application_SetTag_Bulk", new object[] {
                        Authentication,
                        EnvironmentApplicationsForTag});
            Success = ((bool)(results[1]));
            return ((APIStatus)(results[0]));
        }
        
        /// <remarks/>
        public void Application_SetTag_BulkAsync(WebServiceSimpleAuthentication Authentication, EnvironmentApplicationTagList EnvironmentApplicationsForTag) {
            this.Application_SetTag_BulkAsync(Authentication, EnvironmentApplicationsForTag, null);
        }
        
        /// <remarks/>
        public void Application_SetTag_BulkAsync(WebServiceSimpleAuthentication Authentication, EnvironmentApplicationTagList EnvironmentApplicationsForTag, object userState) {
            if ((this.Application_SetTag_BulkOperationCompleted == null)) {
                this.Application_SetTag_BulkOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplication_SetTag_BulkOperationCompleted);
            }
            this.InvokeAsync("Application_SetTag_Bulk", new object[] {
                        Authentication,
                        EnvironmentApplicationsForTag}, this.Application_SetTag_BulkOperationCompleted, userState);
        }
        
        private void OnApplication_SetTag_BulkOperationCompleted(object arg) {
            if ((this.Application_SetTag_BulkCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Application_SetTag_BulkCompleted(this, new Application_SetTag_BulkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://LifeTimeServices/ApplicationManagementService/Solution_PackAndDownload", RequestNamespace="http://www.outsystems.com", ResponseNamespace="http://www.outsystems.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("Status")]
        public APIStatus Solution_PackAndDownload(WebServiceSimpleAuthentication Authentication, string EnvironmentKey, ApplicationTag[] ApplicationTagInfo, string SolutionName, string SolutionDescription, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] out byte[] ApplicationSolutionBinary, out string ApplicationSolutionSize, out bool Success) {
            object[] results = this.Invoke("Solution_PackAndDownload", new object[] {
                        Authentication,
                        EnvironmentKey,
                        ApplicationTagInfo,
                        SolutionName,
                        SolutionDescription});
            ApplicationSolutionBinary = ((byte[])(results[1]));
            ApplicationSolutionSize = ((string)(results[2]));
            Success = ((bool)(results[3]));
            return ((APIStatus)(results[0]));
        }
        
        /// <remarks/>
        public void Solution_PackAndDownloadAsync(WebServiceSimpleAuthentication Authentication, string EnvironmentKey, ApplicationTag[] ApplicationTagInfo, string SolutionName, string SolutionDescription) {
            this.Solution_PackAndDownloadAsync(Authentication, EnvironmentKey, ApplicationTagInfo, SolutionName, SolutionDescription, null);
        }
        
        /// <remarks/>
        public void Solution_PackAndDownloadAsync(WebServiceSimpleAuthentication Authentication, string EnvironmentKey, ApplicationTag[] ApplicationTagInfo, string SolutionName, string SolutionDescription, object userState) {
            if ((this.Solution_PackAndDownloadOperationCompleted == null)) {
                this.Solution_PackAndDownloadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSolution_PackAndDownloadOperationCompleted);
            }
            this.InvokeAsync("Solution_PackAndDownload", new object[] {
                        Authentication,
                        EnvironmentKey,
                        ApplicationTagInfo,
                        SolutionName,
                        SolutionDescription}, this.Solution_PackAndDownloadOperationCompleted, userState);
        }
        
        private void OnSolution_PackAndDownloadOperationCompleted(object arg) {
            if ((this.Solution_PackAndDownloadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Solution_PackAndDownloadCompleted(this, new Solution_PackAndDownloadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://LifeTimeServices/ApplicationManagementService/ApplicationPermissionLevel_L" +
            "ist", RequestNamespace="http://www.outsystems.com", ResponseNamespace="http://www.outsystems.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute("ApplicationPermissionLevels")]
        public ApplicationPermissionLevel[] ApplicationPermissionLevel_List(WebServiceSimpleAuthentication Authentication, out APIStatus Status, out bool Success) {
            object[] results = this.Invoke("ApplicationPermissionLevel_List", new object[] {
                        Authentication});
            Status = ((APIStatus)(results[1]));
            Success = ((bool)(results[2]));
            return ((ApplicationPermissionLevel[])(results[0]));
        }
        
        /// <remarks/>
        public void ApplicationPermissionLevel_ListAsync(WebServiceSimpleAuthentication Authentication) {
            this.ApplicationPermissionLevel_ListAsync(Authentication, null);
        }
        
        /// <remarks/>
        public void ApplicationPermissionLevel_ListAsync(WebServiceSimpleAuthentication Authentication, object userState) {
            if ((this.ApplicationPermissionLevel_ListOperationCompleted == null)) {
                this.ApplicationPermissionLevel_ListOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApplicationPermissionLevel_ListOperationCompleted);
            }
            this.InvokeAsync("ApplicationPermissionLevel_List", new object[] {
                        Authentication}, this.ApplicationPermissionLevel_ListOperationCompleted, userState);
        }
        
        private void OnApplicationPermissionLevel_ListOperationCompleted(object arg) {
            if ((this.ApplicationPermissionLevel_ListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ApplicationPermissionLevel_ListCompleted(this, new ApplicationPermissionLevel_ListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class WebServiceSimpleAuthentication {
        
        private string usernameField;
        
        private string passwordField;
        
        private string tokenField;
        
        /// <remarks/>
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class ApplicationPermissionLevel {
        
        private int idField;
        
        private string labelField;
        
        private string shortLabelField;
        
        private string descriptionField;
        
        private int levelField;
        
        private bool isComputedField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        public string ShortLabel {
            get {
                return this.shortLabelField;
            }
            set {
                this.shortLabelField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public int Level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        public bool IsComputed {
            get {
                return this.isComputedField;
            }
            set {
                this.isComputedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class ApplicationTag {
        
        private string applicationKeyField;
        
        private string tagField;
        
        private string commentsField;
        
        /// <remarks/>
        public string ApplicationKey {
            get {
                return this.applicationKeyField;
            }
            set {
                this.applicationKeyField = value;
            }
        }
        
        /// <remarks/>
        public string Tag {
            get {
                return this.tagField;
            }
            set {
                this.tagField = value;
            }
        }
        
        /// <remarks/>
        public string Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class EnvironmentApplicationTagList {
        
        private string environmentKeyField;
        
        private ApplicationTag[] applicationTagListField;
        
        /// <remarks/>
        public string EnvironmentKey {
            get {
                return this.environmentKeyField;
            }
            set {
                this.environmentKeyField = value;
            }
        }
        
        /// <remarks/>
        public ApplicationTag[] ApplicationTagList {
            get {
                return this.applicationTagListField;
            }
            set {
                this.applicationTagListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class APIStatus {
        
        private int idField;
        
        private int responseIdField;
        
        private string responseMessageField;
        
        private string responseAdditionalInfoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int ResponseId {
            get {
                return this.responseIdField;
            }
            set {
                this.responseIdField = value;
            }
        }
        
        /// <remarks/>
        public string ResponseMessage {
            get {
                return this.responseMessageField;
            }
            set {
                this.responseMessageField = value;
            }
        }
        
        /// <remarks/>
        public string ResponseAdditionalInfo {
            get {
                return this.responseAdditionalInfoField;
            }
            set {
                this.responseAdditionalInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class EnvironmentApplicationInfo {
        
        private string environmentKeyField;
        
        private bool existsInEnvironmentField;
        
        private string versionField;
        
        private bool isModifiedField;
        
        private System.DateTime lastPublishedOnField;
        
        private string lastPublishedByField;
        
        /// <remarks/>
        public string EnvironmentKey {
            get {
                return this.environmentKeyField;
            }
            set {
                this.environmentKeyField = value;
            }
        }
        
        /// <remarks/>
        public bool ExistsInEnvironment {
            get {
                return this.existsInEnvironmentField;
            }
            set {
                this.existsInEnvironmentField = value;
            }
        }
        
        /// <remarks/>
        public string Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
        
        /// <remarks/>
        public bool IsModified {
            get {
                return this.isModifiedField;
            }
            set {
                this.isModifiedField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LastPublishedOn {
            get {
                return this.lastPublishedOnField;
            }
            set {
                this.lastPublishedOnField = value;
            }
        }
        
        /// <remarks/>
        public string LastPublishedBy {
            get {
                return this.lastPublishedByField;
            }
            set {
                this.lastPublishedByField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.outsystems.com")]
    public partial class ApplicationInfo {
        
        private string keyField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string uRLPathField;
        
        private string iconHashField;
        
        private string iconURLField;
        
        private EnvironmentApplicationInfo[] statusInEnvironmentsField;
        
        private bool isSystemField;
        
        private bool isHiddenField;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string URLPath {
            get {
                return this.uRLPathField;
            }
            set {
                this.uRLPathField = value;
            }
        }
        
        /// <remarks/>
        public string IconHash {
            get {
                return this.iconHashField;
            }
            set {
                this.iconHashField = value;
            }
        }
        
        /// <remarks/>
        public string IconURL {
            get {
                return this.iconURLField;
            }
            set {
                this.iconURLField = value;
            }
        }
        
        /// <remarks/>
        public EnvironmentApplicationInfo[] StatusInEnvironments {
            get {
                return this.statusInEnvironmentsField;
            }
            set {
                this.statusInEnvironmentsField = value;
            }
        }
        
        /// <remarks/>
        public bool IsSystem {
            get {
                return this.isSystemField;
            }
            set {
                this.isSystemField = value;
            }
        }
        
        /// <remarks/>
        public bool IsHidden {
            get {
                return this.isHiddenField;
            }
            set {
                this.isHiddenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void Application_ListCompletedEventHandler(object sender, Application_ListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Application_ListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Application_ListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ApplicationInfo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ApplicationInfo[])(this.results[0]));
            }
        }
        
        /// <remarks/>
        public APIStatus Status {
            get {
                this.RaiseExceptionIfNecessary();
                return ((APIStatus)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool Success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void Application_SetTag_BulkCompletedEventHandler(object sender, Application_SetTag_BulkCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Application_SetTag_BulkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Application_SetTag_BulkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public APIStatus Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((APIStatus)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool Success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void Solution_PackAndDownloadCompletedEventHandler(object sender, Solution_PackAndDownloadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Solution_PackAndDownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Solution_PackAndDownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public APIStatus Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((APIStatus)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public byte[] ApplicationSolutionBinary {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[1]));
            }
        }
        
        /// <remarks/>
        public string ApplicationSolutionSize {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[2]));
            }
        }
        
        /// <remarks/>
        public bool Success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[3]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ApplicationPermissionLevel_ListCompletedEventHandler(object sender, ApplicationPermissionLevel_ListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ApplicationPermissionLevel_ListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ApplicationPermissionLevel_ListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public ApplicationPermissionLevel[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((ApplicationPermissionLevel[])(this.results[0]));
            }
        }
        
        /// <remarks/>
        public APIStatus Status {
            get {
                this.RaiseExceptionIfNecessary();
                return ((APIStatus)(this.results[1]));
            }
        }
        
        /// <remarks/>
        public bool Success {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[2]));
            }
        }
    }
}

#pragma warning restore 1591