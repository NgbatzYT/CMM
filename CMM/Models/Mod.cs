using System.Text.Json.Serialization;

namespace CMM.Models
{
    public class Mod
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
