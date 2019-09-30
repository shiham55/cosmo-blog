using Newtonsoft.Json;
using System;

namespace ComoBlog.Data.Base
{
    public class BaseEntity : IEntity
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
