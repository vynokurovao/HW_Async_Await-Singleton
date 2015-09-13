using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HW_CSharp_09_11._09.Startup))]
namespace HW_CSharp_09_11._09
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
