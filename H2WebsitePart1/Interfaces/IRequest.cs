using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace H2WebsitePart1
{
    public interface IRequest
    {
        public WebRequest _webRequest { get; set; }
        void CreateRequest(string request);
    }
}
