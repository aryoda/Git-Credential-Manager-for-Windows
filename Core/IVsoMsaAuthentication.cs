﻿using System;
using System.Threading.Tasks;

namespace Microsoft.TeamFoundation.Git.Helpers.Authentication
{
    public interface IVsoMsaAuthentication
    {
        bool PromptLogon(Uri targetUri);
    }
}
