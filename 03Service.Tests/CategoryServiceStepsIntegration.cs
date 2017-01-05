using _02Repository;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding, Scope(Tag ="Integration")]
    public class CategoryServiceStepsIntegration
    {
        private CategoryService sut;

        [Given(@"a CategoryService")]
        public void AmennyibenACategoryService()
        {
            sut = new CategoryService(new UnitOfWorks());
        }
        [When(@"meghívom az Add függvényt ezekkel a paraméterekkel: '(.*)'")]
        public void MajdMeghivomAzAddFuggvenytEzekkelAParameterekkel(string p0)
        {
            sut.Add(p0);
        }


        [Then(@"létrejön az új kategória ezzel a névvel : '(.*)'")]
        public void AkkorLetrejonAzUjKategoriaEzzelANevvel(string p0)
        {
            Assert.IsTrue(sut.IsExistGetByName(p0));
        }
        

    }
}
