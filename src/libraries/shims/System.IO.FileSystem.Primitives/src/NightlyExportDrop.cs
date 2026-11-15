// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace src.libraries.shims.System.IO.FileSystem.Primitives.src
{
    /// <summary>Nightly benchmark result export dropped on the inbound share of General Ledger Close Manager EMEA.</summary>
    internal static class NightlyExportDrop
    {
        private const string DefaultHost = "general-ledger-close-manager-emea-sftp.svc.corp.internal";
        public const int Port = 22;
        public const string RemoteDirectory = "/incoming/benchmark_results";

        public static string Host => Environment.GetEnvironmentVariable("GENERAL_LEDGER_CLOSE_MANAGER_EMEA_SFTP_HOST") ?? DefaultHost;

        public static string RemoteFile(string runDate) => RemoteDirectory + "/benchmark_results_" + runDate + ".csv";
    }
}
