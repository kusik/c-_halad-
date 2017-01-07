using _01Data.Model;
using _02Repository;
using _02Repository.Tests;
using _03Service;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace _03Service.Tests
{
    [Binding, Scope(Tag ="UnitTest")]
    public class CategoryServiceStepsUnitTests
    {
        
        [Given(@"a CategoryService")]
        public void AmennyibenACategoryService()
        {
            CategoryServiceStepsGeneral.sut = new CategoryService(MockFactory.GetUnitOfWorks());
        }
      
    }

    
}
