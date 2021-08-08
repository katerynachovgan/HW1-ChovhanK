using Interfaces;

namespace Services
{
    public class AddContent : IAddContent
    {
        private readonly IArticleInfo _articleinfo;
        public AddContent(IArticleInfo articleInfo)
        {
            _articleinfo = articleInfo;
        }
        public string AddTheContent(string text)
        {
            return _articleinfo + text;
        }
    }
}

