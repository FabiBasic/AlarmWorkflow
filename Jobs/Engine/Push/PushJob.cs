// This file is part of AlarmWorkflow.
// 
// AlarmWorkflow is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// AlarmWorkflow is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with AlarmWorkflow.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlarmWorkflow.BackendService.AddressingContracts;
using AlarmWorkflow.BackendService.AddressingContracts.EntryObjects;
using AlarmWorkflow.BackendService.EngineContracts;
using AlarmWorkflow.BackendService.SettingsContracts;
using AlarmWorkflow.Shared.Core;
using AlarmWorkflow.Shared.Diagnostics;

namespace AlarmWorkflow.Job.PushJob
{
    [Export(nameof(PushJob), typeof(IJob))]
    [Information(DisplayName = "ExportJobDisplayName", Description = "ExportJobDescription")]
    class PushJob : IJob
    {
        #region Constants

        private const string ApplicationName = "Feuerwehr-Alarmierung";

        #endregion

        #region Fields

        private ISettingsServiceInternal _settings;
        private IAddressingServiceInternal _addressing;

        #endregion

        #region IDisposable Members

        void IDisposable.Dispose()
        {
        }

        #endregion

        #region IJobs Members

        bool IJob.Initialize(IServiceProvider serviceProvider)
        {
            _settings = serviceProvider.GetService<ISettingsServiceInternal>();
            _addressing = serviceProvider.GetService<IAddressingServiceInternal>();

            return true;
        }

        void IJob.Execute(IJobContext context, Operation operation)
        {
            if (context.Phase != JobPhase.AfterOperationStored)
            {
                return;
            }

            // All Information 
            string headerAllInformation = _settings.GetSetting(SettingKeysJob.HeaderAllInformation).GetValue<string>();
            string expressionAllInformation = _settings.GetSetting(SettingKeysJob.MessageContentAllInformation).GetValue<string>();
            string messageAllInformation = operation.ToString(expressionAllInformation);

            // Few Information 
            string headerFewInformation = _settings.GetSetting(SettingKeysJob.HeaderFewInformation).GetValue<string>();
            string expressionFewInformation = _settings.GetSetting(SettingKeysJob.MessageContentFewInformation).GetValue<string>();
            string messageFewInformation = operation.ToString(expressionFewInformation);


            Task.Factory.StartNew(() => SendToProwlAllInformation(operation, messageAllInformation, headerAllInformation));
            Task.Factory.StartNew(() => SendToProwlFewInformation(operation, messageFewInformation, headerFewInformation));
            Task.Factory.StartNew(() => SendToNotifyMyAndroidAllInformation(operation, messageAllInformation, headerAllInformation));
            Task.Factory.StartNew(() => SendToNotifyMyAndroidFewInformation(operation, messageFewInformation, headerFewInformation));
            Task.Factory.StartNew(() => SendToPushalotAllInformation(operation, messageAllInformation, headerAllInformation));
            Task.Factory.StartNew(() => SendToPushalotFewInformation(operation, messageFewInformation, headerFewInformation));
            Task.Factory.StartNew(() => SendToPushoverAllInformation(operation, messageAllInformation, headerAllInformation));
            Task.Factory.StartNew(() => SendToPushoverFewInformation(operation, messageFewInformation, headerFewInformation));

        }

        bool IJob.IsAsync => false;

        #endregion

        #region Methods

        private IEnumerable<string> GetRecipientApiKeysFor(Operation operation, string consumer)
        {
            var recipients = _addressing.GetCustomObjectsFiltered<PushEntryObject>(PushEntryObject.TypeId, operation);

            return recipients
                .Select(ri => ri.Item2)
                .Where(item => item.Consumer == consumer)
                .Select(item => item.RecipientApiKey);
        }

        private IList<PushEntryObject> GetRecipientApiKeysForPushover(Operation operation, string consumer)
        {
            var recipients = _addressing.GetCustomObjectsFiltered<PushEntryObject>(PushEntryObject.TypeId, operation);
            return recipients
                .Select(ri => ri.Item2)
                .Where(item => item.Consumer == consumer).ToList();
        }

        private void SendToNotifyMyAndroidAllInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "NMA-All");

                if (recipients.Any())
                {
                    NotifyMyAndroid.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorNMA, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToNotifyMyAndroidFewInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "NMA-Few");

                if (recipients.Any())
                {
                    NotifyMyAndroid.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorNMA, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToPushalotAllInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "Pushalot-All");

                if (recipients.Any())
                {
                    Pushalot.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorPushalot, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToPushalotFewInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "Pushalot-Few");

                if (recipients.Any())
                {
                    Pushalot.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorPushalot, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToProwlAllInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "Prowl-All");

                if (recipients.Any())
                {
                    Prowl.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorProwl, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToProwlFewInformation(Operation operation, string message, string header)
        {
            try
            {
                IEnumerable<string> recipients = GetRecipientApiKeysFor(operation, "Prowl-Few");

                if (recipients.Any())
                {
                    Prowl.SendNotifications(recipients, ApplicationName, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorProwl, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToPushoverAllInformation(Operation operation, string message, string header)
        {
            try
            {
                IList<PushEntryObject> recipients = GetRecipientApiKeysForPushover(operation, "Pushover-All");
                string apiKey = _settings.GetSetting(SettingKeysJob.PushoverApiKey).GetValue<string>();

                if (recipients.Any())
                {
                    if (String.IsNullOrEmpty(apiKey))
                    {
                        throw new ArgumentException("No Api-Key for Pushover");
                    }

                    Pushover.SendNotifications(recipients, apiKey, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorPushover, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        private void SendToPushoverFewInformation(Operation operation, string message, string header)
        {
            try
            {
                IList<PushEntryObject> recipients = GetRecipientApiKeysForPushover(operation, "Pushover-Few");
                string apiKey = _settings.GetSetting(SettingKeysJob.PushoverApiKey).GetValue<string>();

                if (recipients.Any())
                {
                    if (String.IsNullOrEmpty(apiKey))
                    {
                        throw new ArgumentException("No Api-Key for Pushover");
                    }

                    Pushover.SendNotifications(recipients, apiKey, header, message);
                }
            }
            catch (Exception ex)
            {
                Logger.Instance.LogFormat(LogType.Error, this, Properties.Resources.ErrorPushover, ex.Message);
                Logger.Instance.LogException(this, ex);
            }
        }

        #endregion
    }
}