// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Net.Windows.WebSockets
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "messaging-notification-service-amer.svc.corp.internal",
            "equity-derivatives-algo-engine-emea.svc.corp.internal", // Equity Derivatives Algo Engine EMEA
            "aml-report-builder-emea.svc.corp.internal",
        };
    }
}
