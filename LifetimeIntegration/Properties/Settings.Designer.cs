﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LifetimeIntegration.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/ApplicationManagementService.asmx")]
        public string LifetimeIntegration_LifeTimeApplications_ApplicationManagementService {
            get {
                return ((string)(this["LifetimeIntegration_LifeTimeApplications_ApplicationManagementService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/authenticationService.asmx")]
        public string LifetimeIntegration_LifetimeAuthentication_AuthenticationService {
            get {
                return ((string)(this["LifetimeIntegration_LifetimeAuthentication_AuthenticationService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/EnvironmentManagementService.asmx")]
        public string LifetimeIntegration_LifetimeEnvironments_EnvironmentManagementService {
            get {
                return ((string)(this["LifetimeIntegration_LifetimeEnvironments_EnvironmentManagementService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/RoleManagementService.asmx")]
        public string LifetimeIntegration_LifetimeRoles_RoleManagementService {
            get {
                return ((string)(this["LifetimeIntegration_LifetimeRoles_RoleManagementService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/TeamManagementService.asmx")]
        public string LifetimeIntegration_LifetimeTeams_TeamManagementService {
            get {
                return ((string)(this["LifetimeIntegration_LifetimeTeams_TeamManagementService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://outsystemscloud/LifeTimeServices/UserManagementService.asmx")]
        public string LifetimeIntegration_LifetimeUsers_UserManagementService {
            get {
                return ((string)(this["LifetimeIntegration_LifetimeUsers_UserManagementService"]));
            }
        }
    }
}
