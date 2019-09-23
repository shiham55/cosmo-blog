using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ComoBlog.Data.Models.Blogging
{
    public class BlogPost
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty(PropertyName = "publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty(PropertyName = "isPublished")]
        public bool IsPublished { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public List<Tag> Tags { get; set; }
    }
}
