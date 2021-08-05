using Interfaces;

namespace Services
{
    public class CheckArticle : ICheckArticle
    {
        private readonly IAddContent _content;
        public CheckArticle(IAddContent content)
        {
            _content = content;
        }
        public void Check(object criteria)
        {
            //check the content
        }
    }
}
