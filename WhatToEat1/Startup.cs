using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatToEat1.Startup))]
namespace WhatToEat1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
