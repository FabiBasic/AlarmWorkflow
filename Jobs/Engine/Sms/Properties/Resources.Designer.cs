﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.Job.SmsJob.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.Job.SmsJob.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Benutzt GroupAlarm zum Nachrichtenversand..
        /// </summary>
        internal static string ExportGroupAlarmDescription {
            get {
                return ResourceManager.GetString("ExportGroupAlarmDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GroupAlarm.
        /// </summary>
        internal static string ExportGroupAlarmDisplayName {
            get {
                return ResourceManager.GetString("ExportGroupAlarmDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Versendet SMS mit Alarmdetails..
        /// </summary>
        internal static string ExportJobDescription {
            get {
                return ResourceManager.GetString("ExportJobDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SMS-Versand.
        /// </summary>
        internal static string ExportJobDisplayName {
            get {
                return ResourceManager.GetString("ExportJobDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Benutzt RETTalarm zum Nachrichtenversand..
        /// </summary>
        internal static string ExportRettAlarmDescription {
            get {
                return ResourceManager.GetString("ExportRettAlarmDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RETTalarm.
        /// </summary>
        internal static string ExportRettAlarmDisplayName {
            get {
                return ResourceManager.GetString("ExportRettAlarmDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Benutzt SMS 77 zum Nachrichtenversand..
        /// </summary>
        internal static string ExportSms77Description {
            get {
                return ResourceManager.GetString("ExportSms77Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SMS 77.
        /// </summary>
        internal static string ExportSms77DisplayName {
            get {
                return ResourceManager.GetString("ExportSms77DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Benutzt Smstrade zum Nachrichtenversand..
        /// </summary>
        internal static string ExportSmstradeDescription {
            get {
                return ResourceManager.GetString("ExportSmstradeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Smstrade.
        /// </summary>
        internal static string ExportSmstradeDisplayName {
            get {
                return ResourceManager.GetString("ExportSmstradeDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no recipients configured!.
        /// </summary>
        internal static string NoRecipientsErrorMessage {
            get {
                return ResourceManager.GetString("NoRecipientsErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The phone number &apos;{0}&apos; contains invalid chars! Make sure it does only contain digits (0-9)!.
        /// </summary>
        internal static string PhoneNumberContainsInvalidCharsMessage {
            get {
                return ResourceManager.GetString("PhoneNumberContainsInvalidCharsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while sending SMS messages with the selected provider. See log for further information..
        /// </summary>
        internal static string SendSmsErrorMessage {
            get {
                return ResourceManager.GetString("SendSmsErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while sending an SMS to &apos;{0}&apos;..
        /// </summary>
        internal static string SendToRecipientGenericErrorMessage {
            get {
                return ResourceManager.GetString("SendToRecipientGenericErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The result from the SMS provider represented an error! Status code = {0}..
        /// </summary>
        internal static string SendToRecipientSMSProviderErrorMessage {
            get {
                return ResourceManager.GetString("SendToRecipientSMSProviderErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SMS was sucessfully delivered to SMS provider. The SMS provider returned: {0}.
        /// </summary>
        internal static string SendToRecipientSuccessMessage {
            get {
                return ResourceManager.GetString("SendToRecipientSuccessMessage", resourceCulture);
            }
        }
    }
}
