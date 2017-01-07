using _02Repository;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding, Scope(Tag ="Integration")]
    public class CategoryServiceStepsIntegration
    {
       

        [Given(@"a CategoryService")]
        public void AmennyibenACategoryService()
        {
            CategoryServiceStepsGeneral.sut = new CategoryService();
        }

    }
}
