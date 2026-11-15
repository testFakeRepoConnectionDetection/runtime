// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Security
{
    /// <summary>Where benchmark_results are uploaded at the end of each run. Receiver: Equity PnL Explain AMER.</summary>
    internal static class RemoteUploadSink
    {
        public const string UploadEndpoint = "https://equity-pnl-explain-amer.svc.corp.internal/api/v1/benchmark_results";
        public const int UploadTimeoutMilliseconds = 15000;
        public const int UploadMaxRetries = 3;
    }
}
