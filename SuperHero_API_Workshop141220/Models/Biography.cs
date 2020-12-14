﻿using Newtonsoft.Json;

namespace SuperHero_API_Workshop141220.Models
{
    public class Biography
    {
        [JsonProperty("place-of-birth")]
        public string Place_of_birth { get; set; }
        public string FirstAppearance { get; set; }
        public string Publisher { get; set; }
    }
    }