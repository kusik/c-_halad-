using _01Data.Model;
using _02Repository;
using _02Repository.Tests;
using _03Service;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding, Scope(Tag = "General")]

    public class CategoryServiceStepsGeneral
    {
        public static CategoryService sut;
        private CategoryViewModel category;

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

        [When(@"meghívom a Find függvényt ezekkel a paraméterekkel: '(.*)'")]
        public void MajdMeghivomAFindFuggvenytEzekkelAParameterekkel(int p0)
        {
            category = sut.Find(p0);
        }

        [Then(@"megkapom a kért kategóriát")]
        public void AkkorMegkapomAKertKategoriat()
        {
            Assert.IsNotNull(category);
            Assert.AreEqual(1,category.Id);
        }
    }

    
}
