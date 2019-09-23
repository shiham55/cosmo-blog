using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComoBlog.Data.Models.Blogging
{
    public class Tag
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }
    }
}
