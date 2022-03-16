using H2WebsitePart1.Interfaces;
using System;

namespace H2WebsitePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            IRequest request = new Request();
            request.CreateRequest("https://giphy.com/gifs/rick-roll-g7GKcSzwQfugw");
            IResponse response = new Response(request);
            IReader reader = new Reader(response);
            reader.Read();
        }
    }
}
