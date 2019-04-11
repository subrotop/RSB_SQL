using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSB_SQL.Startup))]
namespace RSB_SQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
