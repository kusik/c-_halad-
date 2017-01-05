using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding]
    public class CategoryServiceSteps
    {
        private CategoryService sut;

        [Given(@"a CategoryService")]
        public void AmennyibenACategoryService()
        {
            sut = new CategoryService();
        }

        [When(@"meghívom az Add függvényt ezekkel a paraméterekkel: ""(.*)""")]
        public void MajdMeghivomAzAddFuggvenytEzekkelAParameterekkel(string name)
        {
            sut.Add(name);
        }
        
        [Then(@"létrejön az új kategória ezzel a névvel : ""(.*)""")]
        public void AkkorLetrejonAzUjKategoriaEzzelANevvel(string name)
        {
            var newCat = sut.GetByName(name);
        }

    }
}
