namespace Bridge.A2
{
    public class FileDisplayImpl : DisplayImpl
    {
        private readonly string _filename;
        private StreamReader? _reader;

        public FileDisplayImpl(string filename)
        {
            _filename = filename;
        }

        public override void RawOpen()
        {
            try
            {
                _reader = new StreamReader(_filename);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"=-=-=-=-=-= {_filename} =-=-=-=-=-=");
        }

        public override void RawPrint()
        {
            try
            {
                _reader?.BaseStream.Seek(0, SeekOrigin.Begin);
                string? line;
                while ((line = _reader?.ReadLine()) != null)
                    Console.WriteLine($"> {line}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void RawClose()
        {
            Console.WriteLine("=-=-=-=-=-= ");
            try
            {
                _reader?.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}