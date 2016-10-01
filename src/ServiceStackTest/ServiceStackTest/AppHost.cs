using Funq;
using ServiceStack;
using ServiceStackTest.ServiceInterface;

namespace ServiceStackTest
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("ServiceStackTest", typeof(HelloService).Assembly) { }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            this.Plugins.Add(new PostmanFeature());
            this.Plugins.Add(new CorsFeature());
        }
    }
}