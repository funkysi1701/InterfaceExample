using InterfaceExample.Core;

namespace InterfaceExample.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp r = new RunApp();
            r.CreateContent("facebook");
            r.CreateContent("twitter");
        }
    }
}
