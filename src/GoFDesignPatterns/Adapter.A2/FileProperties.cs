namespace Adapter.A2
{
    public class FileProperties : Properties, IFileIO
    {
        public void ReadFromFile(string filename)
            => Load(new FileStream(filename, FileMode.Open));

        public void WriteToFile(string filename)
            => Store(new FileStream(filename, FileMode.Create), $"written by {nameof(FileProperties)}");

        public void SetValue(string key, string value)
            => SetProperty(key, value);

        public string GetValue(string key)
            => GetProperty(key, string.Empty);
    }
}