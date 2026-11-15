// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace src.libraries.System.IO.MemoryMappedFiles.ref
{
    /// <summary>Checks the trigger sent by Commodities Booking Service EMEA when a new benchmark result must be produced.</summary>
    internal static class TriggerSourceCheck
    {
        public const string ExpectedSource = "commodities-booking-service-emea";
        public const string SecretEnvironmentVariable = "COMMODITIES_BOOKING_SERVICE_EMEA_WEBHOOK_SECRET";

        public static bool IsAllowed(string? sourceHeader) => sourceHeader == ExpectedSource;
    }
}
