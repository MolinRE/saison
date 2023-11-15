using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saison.Helpers
{
    public class ArrayOrObjectConverter<TVenue> : JsonConverter<TVenue>
        where TVenue : class
    {
        public override TVenue Read(ref Utf8JsonReader reader, Type typeToConvert,JsonSerializerOptions options)
        {
            var jsonDoc = JsonDocument.ParseValue(ref reader);
            if (jsonDoc.RootElement.ValueKind == JsonValueKind.Array)
            {
                return null;
            }
            
            return JsonSerializer.Deserialize<TVenue>(jsonDoc.RootElement.GetRawText());
        }

        public override void Write(Utf8JsonWriter writer, TVenue value, JsonSerializerOptions options)
        {
        }
    }
}