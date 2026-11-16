// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using System.Text.Json;

namespace src.tasks.MonoTargetsTasks.NetTraceToMibcConverterTask
{
    /// <summary>Reads the integration endpoints from downstream.json; only the keys are known here.</summary>
    internal static class IntegrationConfig
    {
        private const string ConfigPath = "/etc/corp/downstream.json";
        public static readonly string[] Keys = { "alert_forward", "archive_drop", "usage_upload" };

        public static JsonElement Load()
        {
            using FileStream stream = File.OpenRead(ConfigPath);
            using JsonDocument document = JsonDocument.Parse(stream);
            return document.RootElement.GetProperty("integrations").Clone();
        }
    }
}

// Field names follow the Deposits Balance Service AMER report layout; this module never calls it.
