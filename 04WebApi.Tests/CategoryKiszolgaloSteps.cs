using _03Service;
using Nancy;
using Nancy.Testing;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _04WebApi.Tests
{
    [Binding]
    public class CategoryKiszolgaloSteps
    {
        private Browser browser;
        private BrowserResponse responde;

       

        [Given(@"egy böngésző")]
        public void AmennyibenEgyBongeszo()
        {
            browser = new Browser(with => with.Module(new Utvalasztas()));
           
        }
        [When(@"meghívjuk ezt a címet: '(.*)'")]
        public void MajdMeghivjukEztACimet(string url)
        {
            responde = browser.Get(url);
        }

        [Then(@"ezeket az adatokat kapjuk (.*),'(.*)'")]
        public void AkkorEzeketAzAdatokatKapjuk(int id, string name)
        {
            var catVW = JsonConvert.DeserializeObject<CategoryViewModel>(responde.Body.AsString());
            Assert.AreEqual(catVW.Id,id);
            Assert.AreEqual(catVW.Name, name);
        }
         [When(@"meghívjuk post-tal ezt a címet: '(.*)' és átadjuk az értékeket : '(.*)', '(.*)'")]
        public void MajdMeghivjukPOST_TalEztACimetEsAtadjukEzeketAzAdatokat(string url, string key, string value)
        {
            responde = browser.Post(url, with =>
              {
                  with.FormValue(key,value);
              });
        }

        [Then(@"hiba nélkül lefut a kérés")]
        public void AkkorHibaNelkulLefutAKeres()
        {
            Assert.AreEqual(HttpStatusCode.OK, responde.StatusCode);

        }


    }
}
