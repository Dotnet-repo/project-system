﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.ProjectSystem.Query;
using Microsoft.VisualStudio.ProjectSystem.Query.ProjectModelMethods.Actions;
using Microsoft.VisualStudio.ProjectSystem.Query.QueryExecution;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Query
{
    /// <summary>
    /// <see cref="IQueryActionExecutor"/> handling <see cref="ProjectModelActionNames.RenameLaunchProfile"/> actions.
    /// </summary>
    internal sealed class RenameLaunchProfileAction : LaunchProfileActionBase
    {
        private readonly RenameLaunchProfile _executableStep;

        public RenameLaunchProfileAction(RenameLaunchProfile executableStep)
        {
            _executableStep = executableStep;
        }

        protected override Task ExecuteAsync(ILaunchSettingsActionService launchSettingsActionService, CancellationToken cancellationToken)
        {
            return launchSettingsActionService.RenameLaunchProfileAsync(
                _executableStep.CurrentProfileName,
                _executableStep.NewProfileName,
                cancellationToken);
        }
    }
}
