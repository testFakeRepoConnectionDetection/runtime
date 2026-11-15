// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Collections
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "deposits-interest-engine-apac.svc.corp.internal", // Deposits Interest Engine APAC
            "counterparty-risk-exposure-calculator-amer.svc.corp.internal", // Counterparty Risk Exposure Calculator AMER
            "fx-pnl-explain-emea.svc.corp.internal", // FX PnL Explain EMEA
        };
    }
}
