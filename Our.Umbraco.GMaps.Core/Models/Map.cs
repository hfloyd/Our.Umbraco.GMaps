﻿using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Our.Umbraco.GMaps.Models
{
    public class Map
    {
        [DataMember(Name = "address")]
        [JsonProperty("address")]
        public Address Address { get; set; } = new Address();

        [DataMember(Name = "mapconfig")]
        [JsonProperty("mapconfig")]
        public MapConfig MapConfig { get; set; } = new MapConfig();

    }
}