using H2WebsitePart1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace H2WebsitePart1
{
    public class Response : IResponse
    {
        public WebResponse Response_ { get; set ; }
        public IWebRequest Request { get; set ; }

        public Response(IWebRequest request)
        {
            Request = request;
            Response_ = request._webRequest.GetResponse();
        }
    }
}
