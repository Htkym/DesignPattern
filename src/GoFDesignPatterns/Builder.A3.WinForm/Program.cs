namespace Builder.A3.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var frameBuilder = new FrameBuilder();
            var director = new Director(frameBuilder);
            director.Construct();
            var frame = frameBuilder.GetResult();
            Application.Run(frame);
        }
    }
}