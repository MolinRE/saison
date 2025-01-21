using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saison.Helpers
{
    public class ArrayOrObjectConverter<TModel> : JsonConverter<TModel> where TModel : class
    {
        public override TModel Read(ref Utf8JsonReader reader, Type typeToConvert,JsonSerializerOptions options)
        {
            var jsonDoc = JsonDocument.ParseValue(ref reader);
            if (jsonDoc.RootElement.ValueKind == JsonValueKind.Array)
            {
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
            
#pragma warning disable CS8603 // Possible null reference return.
            return JsonSerializer.Deserialize<TModel>(jsonDoc.RootElement.GetRawText());
#pragma warning restore CS8603 // Possible null reference return.
        }

        public override void Write(Utf8JsonWriter writer, TModel value, JsonSerializerOptions options)
        {
        }
    }
}