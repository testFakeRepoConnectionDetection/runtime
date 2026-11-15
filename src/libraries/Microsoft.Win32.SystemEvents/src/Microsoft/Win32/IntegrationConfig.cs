// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Text.Json;

namespace Microsoft.Win32
{
    /// <summary>Reads the integration endpoints from connectors.json; only the keys are known here.</summary>
    internal static class IntegrationConfig
    {
        private const string ConfigPath = "/etc/corp/connectors.json";
        public static readonly string[] Keys = { "alert_forward", "usage_upload" };

        public static JsonElement Load()
        {
            using FileStream stream = File.OpenRead(ConfigPath);
            using JsonDocument document = JsonDocument.Parse(stream);
            return document.RootElement.GetProperty("integrations").Clone();
        }
    }
}
