// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.CodeDom
{
    /// <summary>Checks the trigger sent by the upstream system when a new benchmark result must be produced.</summary>
    internal static class TriggerSourceCheck
    {
        public const string ExpectedSource = "operational-risk-collateral-engine-emea";
        public const string SecretEnvironmentVariable = "OPERATIONAL_RISK_COLLATERAL_ENGINE_EMEA_WEBHOOK_SECRET";

        public static bool IsAllowed(string? sourceHeader) => sourceHeader == ExpectedSource;
    }
}
