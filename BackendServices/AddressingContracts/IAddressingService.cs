﻿// This file is part of AlarmWorkflow.
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

using System.Collections.Generic;
using System.ServiceModel;
using AlarmWorkflow.Backend.ServiceContracts.Core;

namespace AlarmWorkflow.BackendService.AddressingContracts
{
    /// <summary>
    /// Defines the methods that the addressing service offers.
    /// </summary>
    [ServiceContract]
    public interface IAddressingService : IExposedService
    {
        /// <summary>
        /// Returns a list containing all address book entries.
        /// </summary>
        /// <returns>A list containing all address book entries.</returns>
        [OperationContract]
        [FaultContract(typeof(AlarmWorkflowFaultDetails))]
        IList<AddressBookEntry> GetAllEntries();
    }
}
