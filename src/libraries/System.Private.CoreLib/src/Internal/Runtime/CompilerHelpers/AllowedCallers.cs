// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Internal.Runtime.CompilerHelpers
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "fx-hedging-service.svc.corp.internal",
            "credit-trade-capture-emea.svc.corp.internal",
            "market-risk-stress-testing-emea.svc.corp.internal",
        };
    }
}
