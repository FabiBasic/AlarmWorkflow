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
using AlarmWorkflow.Shared.Settings;

namespace AlarmWorkflow.Job.PushJob
{
    static class SettingKeysJob
    {
        // All Information
        internal static readonly SettingKey MessageContentAllInformation = SettingKey.Create("PushJob", "MessageContentAllInformation");
        internal static readonly SettingKey HeaderAllInformation = SettingKey.Create("PushJob", "HeaderAllInformation");
        // Few Information
        internal static readonly SettingKey MessageContentFewInformation = SettingKey.Create("PushJob", "MessageContentFewInformation");
        internal static readonly SettingKey HeaderFewInformation = SettingKey.Create("PushJob", "HeaderFewInformation");
        // All and Few Information
        internal static readonly SettingKey PushoverApiKey = SettingKey.Create("PushJob", "PushoverApiKey");
    }
}
