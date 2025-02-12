namespace Adapter.Sapmple1
{
    public class Banner
    {
        private string _string;

        public Banner(string str)
        {
            _string = str;
        }

        public void ShowWithParen()
           => Console.WriteLine($"({_string})");

        public void ShowWithAster()
           => Console.WriteLine($"*{_string}*");
    }
}