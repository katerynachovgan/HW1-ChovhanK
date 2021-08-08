using Microsoft.AspNetCore.Mvc;
using Services;
using System.Linq;
using Interfaces;

namespace HW1_ChovhanK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly AllProcessess _article;
       
        public ArticleController(AllProcessess article)
        {
            _article = article;
        }

        [HttpGet]
        public IActionResult ResultArticle()
        {
            _article.AllPublicLogic();

            return Ok();
        }
    }
}
