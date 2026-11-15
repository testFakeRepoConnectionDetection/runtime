// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace src.libraries.System.Xml.XDocument.ref
{
    /// <summary>Where benchmark_results are uploaded at the end of each run. Receiver: the downstream service.</summary>
    internal static class UploadEndpointConfig
    {
        public const string UploadEndpoint = "https://equity-derivatives-position-keeper.svc.corp.internal/api/v1/benchmark_results";
        public const int UploadTimeoutMilliseconds = 15000;
        public const int UploadMaxRetries = 3;
    }
}
