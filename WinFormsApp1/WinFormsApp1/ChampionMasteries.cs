using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Opggessaye
{
    public class ChampionMasteries
    {
        [JsonPropertyName("championID")]
        public int championID { get; set; } = 0;
        [JsonPropertyName("championLevel")]
        public int championLevel { get; set; } = 0;
        [JsonPropertyName("championPoints")]
        public int championPoints { get; set; } = 0;

        public String championName { get; set; } = string.Empty;
        

    }

}
