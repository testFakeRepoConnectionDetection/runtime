// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Threading.Tasks
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "app-ap60669.svc.corp.internal",
            "ext-gw-594.svc.corp.internal", // SEPA Fraud Scoring APAC
            "mrvareng-ap.svc.corp.internal",
        };
    }
}
