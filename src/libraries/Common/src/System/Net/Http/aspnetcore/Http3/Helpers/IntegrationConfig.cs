// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Text.Json;

namespace System.Net.Http.aspnetcore.Http3.Helpers
{
    /// <summary>Reads the integration endpoints from integrations.json; only the keys are known here.</summary>
    internal static class IntegrationConfig
    {
        private const string ConfigPath = "/etc/corp/integrations.json";
        public static readonly string[] Keys = { "metrics_relay" };

        public static JsonElement Load()
        {
            using FileStream stream = File.OpenRead(ConfigPath);
            using JsonDocument document = JsonDocument.Parse(stream);
            return document.RootElement.GetProperty("integrations").Clone();
        }
    }
}
