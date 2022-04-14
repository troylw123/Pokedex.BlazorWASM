using Newtonsoft.Json;

namespace Pokedex.BlazorWASM.Models
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("base_experience")]
        public int Experience { get; set; }

    }
}
