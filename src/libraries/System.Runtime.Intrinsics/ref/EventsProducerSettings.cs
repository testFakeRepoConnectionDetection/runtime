// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace src.libraries.System.Runtime.Intrinsics.ref
{
    /// <summary>Settings of the producer that publishes benchmark result events for the downstream service.</summary>
    internal static class EventsProducerSettings
    {
        public const string BootstrapServers = "kafka-01.svc.corp.internal:9093";
        public const string Topic = "sepa-sanctions-filter-amer.inbound.benchmark_results";

        public static IReadOnlyDictionary<string, string> ProducerSettings { get; } = new Dictionary<string, string>
        {
            ["bootstrap.servers"] = BootstrapServers,
            ["security.protocol"] = "ssl",
            ["acks"] = "all",
        };
    }
}
