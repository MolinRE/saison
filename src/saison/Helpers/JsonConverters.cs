﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saison.Helpers
{
    public class ArrayOrObjectConverter<TModel> : JsonConverter<TModel>
        where TModel : class
    {
        public override TModel Read(ref Utf8JsonReader reader, Type typeToConvert,JsonSerializerOptions options)
        {
            var jsonDoc = JsonDocument.ParseValue(ref reader);
            if (jsonDoc.RootElement.ValueKind == JsonValueKind.Array)
            {
                return null;
            }
            
            return JsonSerializer.Deserialize<TModel>(jsonDoc.RootElement.GetRawText());
        }

        public override void Write(Utf8JsonWriter writer, TModel value, JsonSerializerOptions options)
        {
        }
    }
}