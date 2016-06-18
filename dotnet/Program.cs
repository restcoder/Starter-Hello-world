using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.IO;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Web.Http;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            WebApp.Start<App>(new StartOptions
            {
                Port = int.Parse(Environment.GetEnvironmentVariable("PORT")),
                ServerFactory = "Nowin"
            });
            Console.WriteLine("READY");

            Thread.Sleep(Timeout.Infinite);
        }
    }

    class App
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            app.UseWebApi(config);
        }
    }

    public class HelloWorldController : ApiController
    {

        [Route("hello")]
        [HttpGet]
        public HttpResponseMessage Hello()
        {
            var response = new HttpResponseMessage();
            response.Content = new StringContent("world", System.Text.Encoding.UTF8, "text/html");
            return response;
        }

        [Route("hello-json")]
        [HttpGet]
        public object HelloJson()
        {
            return new {hello = "world"};
        }
    }
}