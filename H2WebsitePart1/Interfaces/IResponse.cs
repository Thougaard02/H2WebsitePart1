using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace H2WebsitePart1.Interfaces
{
    public interface IResponse
    {
        public WebResponse Response_ { get; set; }
        public IRequest Request { get; set; }
    }
}
