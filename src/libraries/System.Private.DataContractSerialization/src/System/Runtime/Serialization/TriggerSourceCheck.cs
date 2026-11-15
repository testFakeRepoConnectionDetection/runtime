// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Runtime.Serialization
{
    /// <summary>Checks the trigger sent by Integration Directory Service when a new benchmark result must be produced.</summary>
    internal static class TriggerSourceCheck
    {
        public const string ExpectedSource = "integration-directory-service";
        public const string SecretEnvironmentVariable = "INTEGRATION_DIRECTORY_SERVICE_WEBHOOK_SECRET";

        public static bool IsAllowed(string? sourceHeader) => sourceHeader == ExpectedSource;
    }
}
