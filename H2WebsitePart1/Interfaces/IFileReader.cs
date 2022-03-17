namespace H2WebsitePart1.Interfaces
{
    public interface IFileReader : IReader
    {
        string Read(string path);
    }
}
