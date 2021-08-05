using Interfaces;

namespace Services
{
    public class AddContent : IAddContent
    {
        public string AddTheContent(string content)
        {
            return content;
        }
    }
}

