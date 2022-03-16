using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace H2WebsitePart1
{
    public class Request : IRequest
    {
        public WebRequest _webRequest { get; set; }
        public void CreateRequest(string request)
        {
            _webRequest = WebRequest.Create(request);
        }
    }
}
