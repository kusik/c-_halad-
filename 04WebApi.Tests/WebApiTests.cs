using Nancy.Testing;
using NUnit.Framework;

namespace _04WebApi.Tests
{
    [TestFixture]
    public class WebApiTests
    {
        [Test]
        public void WebApiTests_Root_Get()
        {
            // TODO: Add your test code here

            var browser = new Browser(with => with.Module(new Utvalasztas()));
            var responde = browser.Get("/");

            Assert.AreEqual("Hello world, here is Nancy!",responde.Body.AsString());
        }

       
    }
}
