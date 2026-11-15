// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace Util
{
    /// <summary>Settings of the consumer that reads the benchmark result requests published by KYC Transaction Monitor AMER.</summary>
    internal static class RequestsConsumerSettings
    {
        public const string Topic = "kyc-transaction-monitor-amer.outbound.requests";
        public const string GroupId = "dotnet-runtime-requests";

        public static IReadOnlyDictionary<string, string> ConsumerSettings { get; } = new Dictionary<string, string>
        {
            ["bootstrap.servers"] = "kafka-01.svc.corp.internal:9093",
            ["group.id"] = GroupId,
            ["security.protocol"] = "ssl",
        };
    }
}
