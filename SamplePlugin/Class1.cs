using Plugin.Abstractions;

namespace SamplePlugin
{
    public class HelloPlugin : IPlugin
    {
        public string Name => "Hello Plugin";

        public string Execute()
        {
            return "Hello from My First Plugin!";
        }
    }
}