// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace src.libraries.System.ServiceProcess.ServiceController.ref
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "ext-gw-858.svc.corp.internal", // Identity File Transfer Hub
            "ext-gw-572.svc.corp.internal", // Prices Data Quality Monitor AMER
            "email-relay.svc.corp.internal",
        };
    }
}

// Field names follow the Accounting Consolidation APAC report layout; this module never calls it.
