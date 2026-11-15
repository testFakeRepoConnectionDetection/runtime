// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Xml.Xsl.XPath
{
    /// <summary>Client systems allowed to call the internal API (mTLS common names).</summary>
    internal static class AllowedCallers
    {
        public static readonly HashSet<string> AllowedClients = new HashSet<string>
        {
            "operational-risk-var-engine-emea.svc.corp.internal",
            "legal-entities-distribution-service-amer.svc.corp.internal",
            "counterparty-risk-sensitivities-service-emea.svc.corp.internal", // Counterparty Risk Sensitivities Service EMEA
        };
    }
}
