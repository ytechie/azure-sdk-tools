﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.IaaS.Extensions
{
    using System.Management.Automation;
    using Model;

    [Cmdlet(
        VerbsCommon.Set,
        VirtualMachineBGInfoExtensionNoun,
        DefaultParameterSetName = RemoveBGInfoExtensionParamSetName),
    OutputType(
        typeof(IPersistentVM))]
    public class SetAzureVMBGInfoExtensionCommand : VirtualMachineBGInfoExtensionCmdletBase
    {
        protected const string RemoveBGInfoExtensionParamSetName = "RemoveBGInfoExtension";

        [Parameter(
            Mandatory = false,
            Position = 1,
            HelpMessage = "Disable VM BGInfo Extension")]
        public override SwitchParameter Disable
        {
            get;
            set;
        }

        internal void ExecuteCommand()
        {
            ValidateParameters();
            RemovePredicateExtensions();
            AddResourceExtension();
            WriteObject(VM);
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            ExecuteCommand();
        }
    }
}
