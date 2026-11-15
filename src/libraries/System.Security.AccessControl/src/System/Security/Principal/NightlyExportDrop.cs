// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.Security.Principal
{
    /// <summary>Nightly benchmark result export dropped on the inbound share of Retail Accounts Balance Service.</summary>
    internal static class NightlyExportDrop
    {
        private const string DefaultHost = "retail-accounts-balance-service-sftp.svc.corp.internal";
        public const int Port = 22;
        public const string RemoteDirectory = "/incoming/benchmark_results";

        public static string Host => Environment.GetEnvironmentVariable("RETAIL_ACCOUNTS_BALANCE_SERVICE_SFTP_HOST") ?? DefaultHost;

        public static string RemoteFile(string runDate) => RemoteDirectory + "/benchmark_results_" + runDate + ".csv";
    }
}
