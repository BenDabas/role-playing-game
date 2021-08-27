using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
}