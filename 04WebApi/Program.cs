using _04WebApi.Model;
using Nancy;
using Nancy.Hosting.Self;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04WebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://127.0.0.1:9000";

            using (var host = new NancyHost(new Uri(url)))
            {
                host.Start();
                Console.WriteLine("Elindult a Nancy szerver a {0} címen!",url);
                Console.ReadLine();
            }   

        }
    }
    public class Utvalasztas : NancyModule
    {

        public Utvalasztas()
        {
            Get["/"] = _ => "Hello world, here is Nancy!";

            Get["/Category/{Id}"] = x =>
            {
                var cat = this.Bind<CategoryViewModel>();
                return Response.AsJson(cat);
            };
        }
    }
}
