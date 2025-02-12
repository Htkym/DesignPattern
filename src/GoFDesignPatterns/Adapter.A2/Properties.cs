namespace Adapter.A2
{
    public class Properties
    {
        private readonly Dictionary<string, string> _properties = [];

        public string? GetProperty(string key)
            => _properties.TryGetValue(key, out var value) ? value : null;

        public string GetProperty(string key, string defaultValue)
            => GetProperty(key) ?? defaultValue;

        public void SetProperty(string key, string value)
            => _properties[key] = value;

        public void Load(Stream inputStream)
        {
            using var reader = new StreamReader(inputStream);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith('#'))
                    continue;

                var separatorIndex = line.IndexOf('=');
                if (separatorIndex > 0)
                {
                    var key = line[..separatorIndex].Trim();
                    var value = line[(separatorIndex + 1)..].Trim();
                    _properties[key] = value;
                }
            }
        }

        public void Store(Stream outputStream, string comments)
        {
            using var writer = new StreamWriter(outputStream);
            if (!string.IsNullOrEmpty(comments))
            {
                writer.WriteLine($"# {comments}");
            }
            writer.WriteLine($"# {DateTime.Now}");

            foreach (var entry in _properties)
            {
                writer.WriteLine($"{entry.Key}={entry.Value}");
            }
        }
    }
}