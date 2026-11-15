// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Text.Json.Serialization.Converters.Union
{
    /// <summary>Checks the trigger sent by the upstream system when a new benchmark result must be produced.</summary>
    internal static class TriggerSourceCheck
    {
        public const string ExpectedSource = "cmtrablo-am";
        public const string SecretEnvironmentVariable = "CMTRABLO_AM_WEBHOOK_SECRET";

        public static bool IsAllowed(string? sourceHeader) => sourceHeader == ExpectedSource;
    }
}
