using Interfaces;

namespace Services
{
    public class PublishArticle : IPublishArticle
    {
        private readonly IArticleInfo _info;
        public PublishArticle(IAddContent content, IArticleInfo info)
        {
            _info = info;
        }
        public void Publish()
        {
            System.Console.WriteLine(_info);
        }
    }
}
