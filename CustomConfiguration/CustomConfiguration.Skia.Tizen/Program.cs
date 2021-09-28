using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace CustomConfiguration.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new CustomConfiguration.App(), args);
            host.Run();
        }
    }
}
