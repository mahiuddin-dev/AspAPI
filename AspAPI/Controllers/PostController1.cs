using AspAPI.Context;
using AspAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostController1 : ControllerBase
    {
        ApplicationDBContext _dbContext;

        public PostController1(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Post> GetAll()
        {
            var posts = _dbContext.Posts.ToList();
            return posts;  
        }

        [HttpPost]
        public Post Add(Post post)
        {   
            post.CreateDate = DateTime.Now;
            _dbContext.Posts.Add(post);
            bool isSaved = _dbContext.SaveChanges() > 0;
            if (isSaved)
            {
                return post;
            }
            else
            {
                return null;
            }
        }

    }
}
