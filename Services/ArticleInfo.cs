using Interfaces;

namespace Services
{
    public class ArticleInfo : IArticleInfo
    {
        private string info = "some info";

        public string GetInformation()
        {
            return info; 
        }
    }
}
