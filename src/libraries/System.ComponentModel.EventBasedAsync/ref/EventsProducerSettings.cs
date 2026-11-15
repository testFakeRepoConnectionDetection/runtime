// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace src.libraries.System.ComponentModel.EventBasedAsync.ref
{
    /// <summary>Settings of the producer that publishes benchmark result events for Corporate Actions Event Processor.</summary>
    internal static class EventsProducerSettings
    {
        public const string BootstrapServers = "kafka-01.svc.corp.internal:9093";
        public const string Topic = "ext-gw-390.inbound.benchmark_results";

        public static IReadOnlyDictionary<string, string> ProducerSettings { get; } = new Dictionary<string, string>
        {
            ["bootstrap.servers"] = BootstrapServers,
            ["security.protocol"] = "ssl",
            ["acks"] = "all",
        };
    }
}
