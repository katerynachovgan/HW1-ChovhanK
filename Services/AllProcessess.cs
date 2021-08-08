using Interfaces;

namespace Services
{
    public class AllProcessess
    {
        private readonly IAddContent _addContent;
        private readonly ICheckArticle _checkArticle;
        private readonly IPublishArticle _articlePublish;
        private readonly IArticleInfo _articleInfo;


        public AllProcessess(IAddContent addContent, 
            ICheckArticle checkArticle,
            IPublishArticle articlePublish, IArticleInfo articleInfo)
        {
            _articleInfo = articleInfo;
            _addContent = addContent;
            _checkArticle = checkArticle;
            _articlePublish = articlePublish;
        }

        public void AllPublicLogic()
        {
            _articleInfo.GetInformation();
            _addContent.AddTheContent("some text");
            _checkArticle.Check(1);
            _articlePublish.Publish();
        }
    }
}
