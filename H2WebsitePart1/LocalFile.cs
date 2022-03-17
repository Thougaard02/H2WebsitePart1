using H2WebsitePart1.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace H2WebsitePart1
{
    public class LocalFile : IFileReader
    {
        public string Read(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            { // Read the content.
                string response = reader.ReadToEnd();
                // Display the content.
                return response;
            }
        }
    }
}
