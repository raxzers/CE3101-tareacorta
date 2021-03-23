using System;
using System.Collections.Generic;
using System.Text;

// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using prueba1Proyecto.Class;
//
//    var platillos = Platillos.FromJson(jsonString);

namespace prueba1Proyecto.Class
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Platillos
    {
        [JsonProperty("Platillos")]
        public List<Platillo> PlatillosPlatillos { get; set; }
    }

    public partial class Platillo
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Ingredients")]
        public string Ingredients { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Calories")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Calories { get; set; }

        [JsonProperty("Rating")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Rating { get; set; }

        [JsonProperty("Chef")]
        public string Chef { get; set; }
    }

    public partial class Platillos
    {
        public static Platillos FromJson(string json) => JsonConvert.DeserializeObject<Platillos>(json, prueba1Proyecto.Class.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Platillos self) => JsonConvert.SerializeObject(self, prueba1Proyecto.Class.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}

