// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RestApiTesting.Framework.Cheetah.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DeletePostsFeature : Xunit.IClassFixture<DeletePostsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DeletePosts.feature"
#line hidden
        
        public DeletePostsFeature(DeletePostsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DeletePosts", "As a non-authenticated user,\r\nI want the ability to delete a post.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
  #line 6
    testRunner.Given("I have a client \"client1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="A non-authenticated user successfully deletes a post")]
        [Xunit.TraitAttribute("FeatureTitle", "DeletePosts")]
        [Xunit.TraitAttribute("Description", "A non-authenticated user successfully deletes a post")]
        [Xunit.TraitAttribute("Category", "AcceptanceCriteria")]
        public virtual void ANon_AuthenticatedUserSuccessfullyDeletesAPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-authenticated user successfully deletes a post", null, new string[] {
                        "AcceptanceCriteria"});
#line 9
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 10
     testRunner.When("I send a \"Delete\" request to \"/posts/1\" using client \"client1\" and get the respon" +
                    "se \"deletePostsResponse1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
      testRunner.And("I get the content \"deletePostsResponse1Body\" of the response \"deletePostsResponse" +
                    "1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
     testRunner.Then("the response \"deletePostsResponse1\" should have the status code \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
#line 13
      testRunner.And("the model \"deletePostsResponse1Body\" should match the following values:", ((string)(null)), table3, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="A non-authenticated user attempts to delete a post with nonexistent id")]
        [Xunit.TraitAttribute("FeatureTitle", "DeletePosts")]
        [Xunit.TraitAttribute("Description", "A non-authenticated user attempts to delete a post with nonexistent id")]
        [Xunit.TraitAttribute("Category", "NegativePath")]
        public virtual void ANon_AuthenticatedUserAttemptsToDeleteAPostWithNonexistentId()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-authenticated user attempts to delete a post with nonexistent id", null, new string[] {
                        "NegativePath"});
#line 17
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 18
     testRunner.When("I send a \"Delete\" request to \"/posts/101\" using client \"client1\" and get the resp" +
                    "onse \"deletePostsResponse1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
      testRunner.And("I get the content \"deletePostsResponse1Body\" of the response \"deletePostsResponse" +
                    "1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
     testRunner.Then("the response \"deletePostsResponse1\" should have the status code \"OK\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
#line 21
      testRunner.And("the model \"deletePostsResponse1Body\" should match the following values:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DeletePostsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DeletePostsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
