// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Http.aspnetcore.Http3.Frames
{
    /// <summary>Where benchmark_results are uploaded at the end of each run. Receiver: Data Platform Directory Service EMEA.</summary>
    internal static class UploadEndpointConfig
    {
        public const string UploadEndpoint = "https://data-platform-directory-service-emea.svc.corp.internal/api/v1/benchmark_results";
        public const int UploadTimeoutMilliseconds = 15000;
        public const int UploadMaxRetries = 3;
    }
}
