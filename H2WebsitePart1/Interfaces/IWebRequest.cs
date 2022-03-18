using System.Net;

namespace H2WebsitePart1.Interfaces
{
    public interface IWebRequest : IRequest
    {
        WebRequest _webRequest { get; set; }
    }
}
