using H2WebsitePart1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace H2WebsitePart1
{
    public class Reader : IReader
    {
        private IResponse _response;
        public Reader(IResponse response)
        {
            _response = response;
        }
        public void Read()
        {
            using (Stream dataStream = _response.Response_.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }
            _response.Response_.Close();
        }
    }
}
