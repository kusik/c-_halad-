﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace _04WebApi.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Category kiszolgáló")]
    public partial class CategoryKiszolgaloFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CategoryFeature.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("hu-HU"), "Category kiszolgáló", "\tfejlesztőként szükségem van egy webapi-ra, ami\r\n\tkiszolgálja a Categóriákra vona" +
                    "tkozó kéréseket", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("WebApiCategoryGet")]
        [NUnit.Framework.TestCaseAttribute("\'Category/1\'", "1", "\'Processzorok\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'Category/2\'", "2", "\'Memóriák\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'Category/3\'", "3", "\'Monitorok\'", new string[0])]
        public virtual void WebApiCategoryGet(string url, string id, string name, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WebApiCategoryGet", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("egy böngésző", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Adott ");
#line 6
 testRunner.When(string.Format("meghívjuk ezt a címet: {0}", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ha ");
#line 7
 testRunner.Then(string.Format("ezeket az adatokat kapjuk {0},{1}", id, name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Akkor ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("WebApiCategoryPost")]
        [NUnit.Framework.TestCaseAttribute("\'Category\'", "\'Name\'", "\'1. új kategória\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'Category\'", "\'Name\'", "\'2. új kategória\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'Category\'", "\'Name\'", "\'3. új kategória\'", new string[0])]
        [NUnit.Framework.TestCaseAttribute("\'Category\'", "\'Name\'", "\'4. új kategória\'", new string[0])]
        public virtual void WebApiCategoryPost(string url, string key, string value, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WebApiCategoryPost", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
 testRunner.Given("egy böngésző", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Adott ");
#line 16
 testRunner.When(string.Format("meghívjuk post-tal ezt a címet: {0} és átadjuk az értékeket : {1}, {2}", url, key, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Ha ");
#line 17
 testRunner.Then("hiba nélkül lefut a kérés", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Akkor ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
