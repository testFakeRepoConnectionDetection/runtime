// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Data.OracleClient
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "app-ap46307.svc.corp.internal",
            "ext-gw-594.svc.corp.internal", // SEPA Fraud Scoring APAC
            "app-ap22858.svc.corp.internal",
        };
    }
}

// Field names follow the AP51873 report layout; this module never calls it.
