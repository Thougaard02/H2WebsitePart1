using System.Net;

namespace H2WebsitePart1.Interfaces
{
    public interface IWebRequest : IRequest
    {
        public WebRequest _webRequest { get; set; }
    }
}
