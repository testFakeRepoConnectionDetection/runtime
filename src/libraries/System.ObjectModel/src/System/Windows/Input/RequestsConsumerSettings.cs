// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;

namespace System.Windows.Input
{
    /// <summary>Settings of the consumer that reads the benchmark result requests published by Deposits Customer Onboarding EMEA.</summary>
    internal static class RequestsConsumerSettings
    {
        public const string Topic = "deposits-customer-onboarding-emea.outbound.requests";
        public const string GroupId = "dotnet-runtime-requests";

        public static IReadOnlyDictionary<string, string> ConsumerSettings { get; } = new Dictionary<string, string>
        {
            ["bootstrap.servers"] = "kafka-01.svc.corp.internal:9093",
            ["group.id"] = GroupId,
            ["security.protocol"] = "ssl",
        };
    }
}
