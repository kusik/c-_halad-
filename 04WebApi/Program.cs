using _03Service;
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

            Get["/Category/{Id}"] = CategoryGet;
            Post["/Category/"] = CategoryPost;
            Delete["/Category/{Id}"] = CategoryDelete;
            Get["/Category/"] = CategoryGetAll;

        }

        private dynamic CategoryGetAll(dynamic arg)
        {
            var service = new CategoryService();
            var catResponde = service.FindAll();

            return Response.AsJson(catResponde);

        }

        private dynamic CategoryGet(dynamic arg)
        {
            var catRequest = this.Bind<CategoryViewModel>();

            var service = new CategoryService();
            var catResponde = service.Find(catRequest.Id);

            return Response.AsJson(catResponde);
        }

        private dynamic CategoryPost(dynamic arg)
        {
            var catRequest = this.Bind<CategoryViewModel>();

            var service = new CategoryService();
            service.Add(catRequest.Name);
            var catResponde=catRequest.Message = "Sikeres feltöltés!";
            return Response.AsJson(catResponde);
            ;
        }

        private dynamic CategoryDelete(dynamic arg)
        {
            throw new NotImplementedException();
        }

       
    }
}
