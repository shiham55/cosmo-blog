using ComoBlog.Data.Base;
using ComoBlog.Data.Models.Blogging;
using ComoBlog.Data.Repositories;
using ComoBlog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace ComoBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Tag> _tagService;
        private readonly IRepository<BlogPost> _blogService;

        public HomeController()
        {
            _tagService = new TagService();
            _blogService = new BlogService();
        }

        public IActionResult Index()
        {
            Tag tag = new Tag()
            {
                Id = Guid.NewGuid(),
                Name = "test tag name",
                Description = "test tag description",
                IsActive = true
            };

            try
            {
                var tagInsert = _tagService.AddItemAsync(tag);
                tagInsert.Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " " + ex.StackTrace);
                throw;
            }

            var tagList = _tagService.GetItemsAsync("SELECT * FROM Tags");

            tagList.Wait(); // Blocks current thread until GetFooAsync task completes
                         // For pedagogical use only: in general, don't do this!
            var result = tagList.Result;

            return View();
        }

        public IActionResult Privacy()
        {
            var tagListTask = _tagService.GetItemsAsync("SELECT * FROM Tags");
            tagListTask.Wait();
            var tagList = tagListTask.Result;

            BlogPost blog = new BlogPost() 
            {
                Id = Guid.NewGuid(),
                Content = "Blog post content",
                CreatedDate = DateTime.Today.ToShortDateString(),
                IsPublished = true,
                PublishedDate = DateTime.Today.ToShortDateString(),
                Tags = tagList
            };

            var blogInsert = _blogService.AddItemAsync(blog);
            blogInsert.Wait();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
