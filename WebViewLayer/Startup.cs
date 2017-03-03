using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebViewLayer.Startup))]
namespace WebViewLayer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {

        }
    }
}
