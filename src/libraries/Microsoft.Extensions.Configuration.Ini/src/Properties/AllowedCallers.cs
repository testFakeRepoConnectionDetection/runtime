// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Properties
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "cr-hedging-service-amer.svc.corp.internal",
            "inpseteng-ap.svc.corp.internal",
            "partner-statements-hub.svc.corp.internal",
        };
    }
}
