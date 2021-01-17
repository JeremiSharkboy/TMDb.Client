﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using TMDb.Client.JsonConverters;

namespace TMDb.Client
{
    internal static class NewtonsoftExtensions
    {
        internal static readonly JsonSerializerSettings _defaultSettings;

        static NewtonsoftExtensions() =>
            _defaultSettings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new EnumDescriptionConverter(),
                    new StringEnumConverter(),
                    new RatedBoolUnionConverter()
                }
            };

        internal static string ToJson(this object @object, JsonSerializerSettings settings = null) =>
            JsonConvert.SerializeObject(@object, settings ?? _defaultSettings);

        internal static T ToObject<T>(this string json, JsonSerializerSettings settings = null) =>
            JsonConvert.DeserializeObject<T>(json, settings ?? _defaultSettings);
    }
}