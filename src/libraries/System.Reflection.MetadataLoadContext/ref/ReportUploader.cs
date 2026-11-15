// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace src.libraries.System.Reflection.MetadataLoadContext.ref
{
    /// <summary>Exports benchmark result summaries to SWIFT Reconciliation EMEA.</summary>
    internal static class ReportUploader
    {
        private const string DefaultEndpoint = "https://swift-reconciliation-emea.svc.corp.internal/api/v2/benchmark_results";
        private static readonly HttpClient s_client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        public static async Task<int> ExportAsync(string jsonBody)
        {
            string endpoint = Environment.GetEnvironmentVariable("SWIFT_RECONCILIATION_EMEA_URL") ?? DefaultEndpoint;
            using var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await s_client.PostAsync(endpoint, content).ConfigureAwait(false);
            return (int)response.StatusCode;
        }
    }
}
