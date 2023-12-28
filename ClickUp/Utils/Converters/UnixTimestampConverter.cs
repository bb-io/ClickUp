using Newtonsoft.Json;

namespace Apps.ClickUp.Utils.Converters;

public class UnixTimestampConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        if (value is not DateTime dateTime)
            throw new ArgumentException("You can only serialize DateTime type to a timestamp");

        var offset = new DateTimeOffset(dateTime);
        var timestamp = offset.ToUnixTimeMilliseconds();

        writer.WriteValue(timestamp);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        var readValue = reader.Value?.ToString();

        if (!long.TryParse(readValue, out var res))
            throw new ArgumentException("Value is not a unix timestamp");

        if (res is 0)
            return null;
        
        return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            .AddMilliseconds(res);
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(DateTime) || objectType == typeof(DateTime?);
    }
}