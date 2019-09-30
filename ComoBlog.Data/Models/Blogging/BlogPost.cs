using System;
using System.Collections.Generic;
using System.Text;
using ComoBlog.Data.Base;
using Newtonsoft.Json;

namespace ComoBlog.Data.Models.Blogging
{
    public class BlogPost : BaseEntity
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty(PropertyName = "publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty(PropertyName = "isPublished")]
        public bool IsPublished { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public IEnumerable<Tag> Tags { get; set; }
    }
}
