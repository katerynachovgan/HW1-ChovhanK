using Interfaces;

namespace Services
{
    public class SaveArticleInfo : ISaveArticleInfo
    {
        public string SaveInformation(string info)
        {
            return info;
        }
    }
}
