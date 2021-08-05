using Interfaces;

namespace Services
{
    public class PublishArticle : IPublishArticle
    {
        private readonly IAddContent _content;
        private readonly ISaveArticleInfo _info;
        public PublishArticle(IAddContent content, ISaveArticleInfo info)
        {
            _content = content;
            _info = info;
        }
        public void Publish()
        {
            System.Console.WriteLine(_content);
            System.Console.WriteLine(_info);
        }
    }
}
