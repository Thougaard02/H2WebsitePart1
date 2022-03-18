using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace H2WebsitePart1.Interfaces
{
    public interface IResponse
    {
        WebResponse Response_ { get; set; }
        IWebRequest Request { get; set; }
    }
}
