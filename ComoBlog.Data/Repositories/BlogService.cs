using ComoBlog.Data.Base;
using ComoBlog.Data.Models.Blogging;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComoBlog.Data.Repositories
{
    public class BlogService : BaseRepository<BlogPost>
    {
        public BlogService() : this(new CosmosClient("AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw=="),
                                        "BlogDatabase",
                                        "BlogPosts")
        {
        }

        public BlogService(CosmosClient dbClient, string databaseName, string containerName) : base(dbClient, databaseName, containerName)
        {
        }
    }
}
