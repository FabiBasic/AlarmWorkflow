﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.BackendService.Engine.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.BackendService.Engine.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to An exception occurred while disposing alarm source &apos;{0}&apos;. Please check the log..
        /// </summary>
        internal static string AlarmSourceDisposeException {
            get {
                return ResourceManager.GetString("AlarmSourceDisposeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alarm source &apos;{0}&apos; enabled..
        /// </summary>
        internal static string AlarmSourceEnabled {
            get {
                return ResourceManager.GetString("AlarmSourceEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling alarm source &apos;{0}&apos;....
        /// </summary>
        internal static string AlarmSourceEnabling {
            get {
                return ResourceManager.GetString("AlarmSourceEnabling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing Alarmsource &apos;{0}&apos;....
        /// </summary>
        internal static string AlarmSourceInitializing {
            get {
                return ResourceManager.GetString("AlarmSourceInitializing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alarm Source &apos;{0}&apos; did not return an operation! This may indicate that parsing an operation has failed. Please check the log!.
        /// </summary>
        internal static string AlarmSourceNoOperation {
            get {
                return ResourceManager.GetString("AlarmSourceNoOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received operation &apos;{0}&apos; by Alarm Source &apos;{1}&apos;..
        /// </summary>
        internal static string AlarmSourceReceivedOperation {
            get {
                return ResourceManager.GetString("AlarmSourceReceivedOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error initializing alarm source &apos;{0}&apos;. It will not run..
        /// </summary>
        internal static string AlarmSourceStartException {
            get {
                return ResourceManager.GetString("AlarmSourceStartException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting Alarmsource &apos;{0}&apos;..
        /// </summary>
        internal static string AlarmSourceStarting {
            get {
                return ResourceManager.GetString("AlarmSourceStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unhandled exception occurred while running the thread for alarm source &apos;{0}&apos;. The thread is being terminated. Please check the log..
        /// </summary>
        internal static string AlarmSourceThreadException {
            get {
                return ResourceManager.GetString("AlarmSourceThreadException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine started successfully..
        /// </summary>
        internal static string EngineStarted {
            get {
                return ResourceManager.GetString("EngineStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service failed to start because there are no running alarm sources! Please check the log..
        /// </summary>
        internal static string EngineStartFailedNoAlarmSourceException {
            get {
                return ResourceManager.GetString("EngineStartFailedNoAlarmSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting Engine....
        /// </summary>
        internal static string EngineStarting {
            get {
                return ResourceManager.GetString("EngineStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Engine is now stopped..
        /// </summary>
        internal static string EngineStopped {
            get {
                return ResourceManager.GetString("EngineStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping Engine....
        /// </summary>
        internal static string EngineStopping {
            get {
                return ResourceManager.GetString("EngineStopping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using operation store &apos;{0}&apos; ..
        /// </summary>
        internal static string InitializedOperationStore {
            get {
                return ResourceManager.GetString("InitializedOperationStore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while processing the asynchronous job &apos;{0}&apos;!.
        /// </summary>
        internal static string JobExecuteAsyncFailed {
            get {
                return ResourceManager.GetString("JobExecuteAsyncFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beginning execution of async job &apos;{0}&apos; in phase &apos;{1}&apos;....
        /// </summary>
        internal static string JobExecuteAsyncStart {
            get {
                return ResourceManager.GetString("JobExecuteAsyncStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished execution of job &apos;{0}&apos;..
        /// </summary>
        internal static string JobExecuteFinished {
            get {
                return ResourceManager.GetString("JobExecuteFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while processing the synchronous job &apos;{0}&apos;!.
        /// </summary>
        internal static string JobExecuteSyncFailed {
            get {
                return ResourceManager.GetString("JobExecuteSyncFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beginning execution of sync job &apos;{0}&apos; in phase &apos;{1}&apos;....
        /// </summary>
        internal static string JobExecuteSyncStart {
            get {
                return ResourceManager.GetString("JobExecuteSyncStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while initializing job type &apos;{0}&apos;. The error message was: {1}.
        /// </summary>
        internal static string JobGenericError {
            get {
                return ResourceManager.GetString("JobGenericError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Initializing job type &apos;{0}&apos;....
        /// </summary>
        internal static string JobInitializeBegin {
            get {
                return ResourceManager.GetString("JobInitializeBegin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job type &apos;{0}&apos; initialization failed. The job will not be executed..
        /// </summary>
        internal static string JobInitializeError {
            get {
                return ResourceManager.GetString("JobInitializeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job type &apos;{0}&apos; initialization successful..
        /// </summary>
        internal static string JobInitializeSuccess {
            get {
                return ResourceManager.GetString("JobInitializeSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The job &apos;{0}&apos; failed at dispose. This may have unpredictable consequences..
        /// </summary>
        internal static string JobManagerDisposeJobFailed {
            get {
                return ResourceManager.GetString("JobManagerDisposeJobFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while processing the operation! Please check the log!.
        /// </summary>
        internal static string NewAlarmHandlingException {
            get {
                return ResourceManager.GetString("NewAlarmHandlingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished handling operation with ID &apos;{0}&apos;..
        /// </summary>
        internal static string NewAlarmHandlingFinished {
            get {
                return ResourceManager.GetString("NewAlarmHandlingFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation with number &apos;{0}&apos; was ignored because it is already present and the setting specified to skip operations that already exist..
        /// </summary>
        internal static string NewAlarmIgnoringAlreadyPresentOperation {
            get {
                return ResourceManager.GetString("NewAlarmIgnoringAlreadyPresentOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not parse timestamp from the fax. Using the current time as the timestamp..
        /// </summary>
        internal static string NewAlarmInvalidTimestamp {
            get {
                return ResourceManager.GetString("NewAlarmInvalidTimestamp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stored operation with ID &apos;{0}&apos;..
        /// </summary>
        internal static string NewAlarmStored {
            get {
                return ResourceManager.GetString("NewAlarmStored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Storing the operation to the operation store failed! See log for information..
        /// </summary>
        internal static string NewAlarmStoreOperationFailedMessage {
            get {
                return ResourceManager.GetString("NewAlarmStoreOperationFailedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabling Job &apos;{0}&apos; because of a settings change..
        /// </summary>
        internal static string SettingsJobDisabled {
            get {
                return ResourceManager.GetString("SettingsJobDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming text from the alarm source contained not whitelisted words and won&apos;t be processed any further..
        /// </summary>
        internal static string SourceIsNotOnWhitelist {
            get {
                return ResourceManager.GetString("SourceIsNotOnWhitelist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The incoming text from the alarm source contained blacklisted words. Processing is skipped..
        /// </summary>
        internal static string SourceIsOnBlacklist {
            get {
                return ResourceManager.GetString("SourceIsOnBlacklist", resourceCulture);
            }
        }
    }
}
