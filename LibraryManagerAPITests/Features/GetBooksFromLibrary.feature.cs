﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LibraryManagerAPITests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GetBooksFromLibrary")]
    public partial class GetBooksFromLibraryFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GetBooksFromLibrary.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GetBooksFromLibrary", "As a User I want to get details for books So that I can choose which books to add" +
                    " in my reading list.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for book without description by Id")]
        [NUnit.Framework.CategoryAttribute("Scenario_1.1")]
        public virtual void SearchForBookWithoutDescriptionById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for book without description by Id", null, new string[] {
                        "Scenario_1.1"});
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table1.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "TestTitle",
                        ""});
#line 6
 testRunner.Given("I add to my reading list the following book", ((string)(null)), table1, "Given ");
#line 9
 testRunner.When("I search for book with Id \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table2.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "TestTitle",
                        ""});
#line 10
 testRunner.Then("the result should should retun the following book", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for book with description by Id")]
        [NUnit.Framework.CategoryAttribute("Scenario_1.2")]
        public virtual void SearchForBookWithDescriptionById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for book with description by Id", null, new string[] {
                        "Scenario_1.2"});
#line 15
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table3.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "TestTitle",
                        "TestDescription"});
#line 16
 testRunner.Given("I add to my reading list the following book", ((string)(null)), table3, "Given ");
#line 19
 testRunner.When("I search for book with Id \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table4.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "TestTitle",
                        "TestDescription"});
#line 20
 testRunner.Then("the result should should retun the following book", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for book with 100 character title by Id")]
        [NUnit.Framework.CategoryAttribute("Scenario_1.3")]
        public virtual void SearchForBookWith100CharacterTitleById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for book with 100 character title by Id", null, new string[] {
                        "Scenario_1.3"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table5.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "eT7d5HNl9bAmcovlc1X7 eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X " +
                            "eT7d5HNl9bAmcovlc10",
                        "TestDescription"});
#line 26
 testRunner.Given("I add to my reading list the following book", ((string)(null)), table5, "Given ");
#line 29
 testRunner.When("I search for book with Id \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table6.AddRow(new string[] {
                        "6",
                        "TestAuthor",
                        "eT7d5HNl9bAmcovlc1X7 eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X eT7d5HNl9bAmcovlc1X " +
                            "eT7d5HNl9bAmcovlc10",
                        "TestDescription"});
#line 30
 testRunner.Then("the result should should retun the following book", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search for book with 30 character author by Id")]
        [NUnit.Framework.CategoryAttribute("Scenario_1.4")]
        public virtual void SearchForBookWith30CharacterAuthorById()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for book with 30 character author by Id", null, new string[] {
                        "Scenario_1.4"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table7.AddRow(new string[] {
                        "6",
                        "eT7d5HNl9bAmcovlc1X7 asGd3H459",
                        "TestTitle",
                        "TestDescription"});
#line 36
 testRunner.Given("I add to my reading list the following book", ((string)(null)), table7, "Given ");
#line 39
 testRunner.When("I search for book with Id \"6\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Id",
                        "Author",
                        "Title",
                        "Description"});
            table8.AddRow(new string[] {
                        "6",
                        "eT7d5HNl9bAmcovlc1X7 asGd3H459",
                        "TestTitle",
                        "TestDescription"});
#line 40
 testRunner.Then("the result should should retun the following book", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

