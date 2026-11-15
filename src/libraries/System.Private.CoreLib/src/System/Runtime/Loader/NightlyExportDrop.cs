// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.Runtime.Loader
{
    /// <summary>Nightly benchmark result export dropped on the inbound share of Trade Surveillance Transaction Monitor AMER.</summary>
    internal static class NightlyExportDrop
    {
        private const string DefaultHost = "trade-surveillance-transaction-monitor-amer-sftp.svc.corp.internal";
        public const int Port = 22;
        public const string RemoteDirectory = "/incoming/benchmark_results";

        public static string Host => Environment.GetEnvironmentVariable("TRADE_SURVEILLANCE_TRANSACTION_MONITOR_AMER_SFTP_HOST") ?? DefaultHost;

        public static string RemoteFile(string runDate) => RemoteDirectory + "/benchmark_results_" + runDate + ".csv";
    }
}
