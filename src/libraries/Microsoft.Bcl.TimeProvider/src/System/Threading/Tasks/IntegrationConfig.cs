// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Text.Json;

namespace System.Threading.Tasks
{
    /// <summary>Reads the integration endpoints from endpoints.json; only the keys are known here.</summary>
    internal static class IntegrationConfig
    {
        private const string ConfigPath = "/etc/corp/endpoints.json";
        public static readonly string[] Keys = { "snapshot_ship" };

        public static JsonElement Load()
        {
            using FileStream stream = File.OpenRead(ConfigPath);
            using JsonDocument document = JsonDocument.Parse(stream);
            return document.RootElement.GetProperty("integrations").Clone();
        }
    }
}
