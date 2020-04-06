﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{

    public class SndPowerRenameSettings
    {
        [JsonPropertyName("PowerRename")]
        public PowerRenameSettings PowerRename { get; set; }

        public SndPowerRenameSettings(PowerRenameSettings settings)
        {
            this.PowerRename = settings;
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}

