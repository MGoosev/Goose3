//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GymTuto.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=MGOOSEV;Initial Catalog=C:\\USERS\\AFWADMIN\\DOCUMENTS\\GYMDB.MDF;Integra" +
            "ted Security=True")]
        public string C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_AFWADMIN_DOCUMENTS_GYMDB_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.0.106,1433;Initial Catalog=GymDB;Persist Security Info=True;U" +
            "ser ID=sa;Password=1111")]
        public string GymDBConnectionString {
            get {
                return ((string)(this["GymDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=31.31.198.169;Initial Catalog=u1707856_gymdb;Persist Security Info=Tr" +
            "ue;User ID=u1707856_mgoosev;Password=Tyxplm42")]
        public string u1707856_gymdbConnectionString {
            get {
                return ((string)(this["u1707856_gymdbConnectionString"]));
            }
        }
    }
}
