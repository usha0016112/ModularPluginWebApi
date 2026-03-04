using Microsoft.AspNetCore.Mvc;
using Plugin.Abstractions;
using System.Reflection;

namespace ModularPluginWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PluginController : ControllerBase
    {
        private static List<IPlugin> _plugins = new List<IPlugin>();

        static PluginController()
        {
            var pluginPath = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");

            if (Directory.Exists(pluginPath))
            {
                foreach (var file in Directory.GetFiles(pluginPath, "*.dll"))
                {
                    var assembly = Assembly.LoadFrom(file);

                    var types = assembly.GetTypes()
                        .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsInterface);

                    foreach (var type in types)
                    {
                        var plugin = (IPlugin)Activator.CreateInstance(type);
                        _plugins.Add(plugin);
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_plugins.Select(p => new
            {
                Name = p.Name,
                Result = p.Execute()
            }));
        }
    }
}