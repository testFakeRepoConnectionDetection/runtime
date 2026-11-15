// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.Net.Windows.WebSockets
{
    /// <summary>Nightly benchmark result export dropped on the inbound share of the downstream service.</summary>
    internal static class NightlyExportDrop
    {
        private const string DefaultHost = "irexegat-am-sftp.svc.corp.internal";
        public const int Port = 22;
        public const string RemoteDirectory = "/incoming/benchmark_results";

        public static string Host => Environment.GetEnvironmentVariable("IREXEGAT_AM_SFTP_HOST") ?? DefaultHost;

        public static string RemoteFile(string runDate) => RemoteDirectory + "/benchmark_results_" + runDate + ".csv";
    }
}
