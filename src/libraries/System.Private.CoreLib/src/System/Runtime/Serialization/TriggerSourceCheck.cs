// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.Serialization
{
    /// <summary>Checks the trigger sent by the upstream system when a new benchmark result must be produced.</summary>
    internal static class TriggerSourceCheck
    {
        public const string ExpectedSource = "monitoring-log-collector-amer";
        public const string SecretEnvironmentVariable = "MONITORING_LOG_COLLECTOR_AMER_WEBHOOK_SECRET";

        public static bool IsAllowed(string? sourceHeader) => sourceHeader == ExpectedSource;
    }
}
