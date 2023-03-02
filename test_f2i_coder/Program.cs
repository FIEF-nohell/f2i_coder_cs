using f2i_coder;

namespace test_f2i_coder
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AIO());
        }
    }
}