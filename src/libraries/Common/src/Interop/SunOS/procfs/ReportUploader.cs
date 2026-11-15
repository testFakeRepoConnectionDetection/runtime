// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Interop.SunOS.procfs
{
    /// <summary>Exports benchmark result summaries to Commodities Trade Blotter APAC.</summary>
    internal static class ReportUploader
    {
        private const string DefaultEndpoint = "https://commodities-trade-blotter-apac.svc.corp.internal/api/v2/benchmark_results";
        private static readonly HttpClient s_client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

        public static async Task<int> ExportAsync(string jsonBody)
        {
            string endpoint = Environment.GetEnvironmentVariable("COMMODITIES_TRADE_BLOTTER_APAC_URL") ?? DefaultEndpoint;
            using var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            using HttpResponseMessage response = await s_client.PostAsync(endpoint, content).ConfigureAwait(false);
            return (int)response.StatusCode;
        }
    }
}
