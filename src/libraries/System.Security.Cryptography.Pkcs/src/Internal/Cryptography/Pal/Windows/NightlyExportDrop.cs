// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Internal.Cryptography.Pal.Windows
{
    /// <summary>Nightly benchmark result export dropped on the inbound share of the downstream service.</summary>
    internal static class NightlyExportDrop
    {
        private const string DefaultHost = "fx-pricing-engine-apac-sftp.svc.corp.internal";
        public const int Port = 22;
        public const string RemoteDirectory = "/incoming/benchmark_results";

        public static string Host => Environment.GetEnvironmentVariable("FX_PRICING_ENGINE_APAC_SFTP_HOST") ?? DefaultHost;

        public static string RemoteFile(string runDate) => RemoteDirectory + "/benchmark_results_" + runDate + ".csv";
    }
}
