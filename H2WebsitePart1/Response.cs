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
        public IRequest Request { get; set ; }

        public Response(IRequest request)
        {
            Request = request;
            Response_ = Request._webRequest.GetResponse();
        }
    }
}
