using H2WebsitePart1.Interfaces;
using System;

namespace H2WebsitePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebRequest request = new Request();
            request.CreateRequest("https://giphy.com/gifs/rick-roll-g7GKcSzwQfugw");
            IResponse response = new Response(request);
            IWebRequestReader reader = new WebRequestReaderReader(response);
            reader.Read();

            IFileReader fileReader = new LocalFile();

            Console.WriteLine(fileReader.Read(@"C:\Users\rasmu\OneDrive\Dokumenter\bla.txt"));
        }
    }
}
