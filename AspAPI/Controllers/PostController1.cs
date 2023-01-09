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

    }
}
