namespace Adapter.A2
{
    public interface IFileIO
    {
        void ReadFromFile(string filename);

        void WriteToFile(string filename);

        void SetValue(string key, string value);

        string GetValue(string key);
    }
}