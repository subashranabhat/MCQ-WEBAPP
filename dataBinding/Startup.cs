using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dataBinding.Startup))]
namespace dataBinding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
