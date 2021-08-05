using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Interfaces;

namespace HW1_ChovhanK.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IAddContent _content;
        private readonly ICheckArticle _checkArticle;
        private readonly IPublishArticle _article;
        private readonly ISaveArticleInfo _articleInfo;
        public ArticleController(IAddContent content,
           ICheckArticle checkArticle,
          IPublishArticle article,
          ISaveArticleInfo articleInfo)
        {
            _content = content;
            _checkArticle = checkArticle;
            _article = article;
            _articleInfo = articleInfo;
        }

        [HttpGet]
        public IActionResult ResultArticle()
        {
            _content.AddTheContent("some content");
            _checkArticle.Check("criteria");
            _articleInfo.SaveInformation("name, author, etc");
            _article.Publish();

            var value = _content.AddTheContent("some content") + _articleInfo.SaveInformation("name, author, etc");

            return Ok(value);
        }
    }
}
