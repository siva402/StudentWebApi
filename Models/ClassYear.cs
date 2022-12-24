using System.Text.Json.Serialization;

namespace studentdetails.Models
{
    public enum ClassYear
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]

        Senior = 3,
        ImmediateJunior = 2,
        SuperJunior = 1
    }
}