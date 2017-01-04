using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding]
    public class CategoryServiceSteps
    {
        [Given(@"a CategoryService")]
        public void AmennyibenACategoryService()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"meghívom az Add függvényt ezekkel a paraméterekkel: ""(.*)""")]
        public void MajdMeghivomAzAddFuggvenytEzekkelAParameterekkel(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"létrejön az új kategória")]
        public void AkkorLetrejonAzUjKategoria()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
