using Interfaces;

namespace Services
{
    public class CheckArticle : ICheckArticle
    {
        private readonly IArticleInfo _articleinfo;
        public CheckArticle(IArticleInfo articleInfo)
        {
            _articleinfo = articleInfo;
        }

        public void Check(object criteria)
        {
            System.Console.WriteLine($"Article {_articleinfo} have been checked with criteria: {criteria} ");
        }
    }
}
