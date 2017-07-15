using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TabernaRolera.Startup))]
namespace TabernaRolera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
