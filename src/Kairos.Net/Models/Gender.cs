﻿using Newtonsoft.Json;

namespace Kairos.Net.Models
{
    public class Gender
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("maleConfidence")]
        public float MaleConfidence { get; set; }

        [JsonProperty("femaleConfidence")]
        public float FemaleConfidence { get; set; }
    }
}