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
    public partial class CreatePostsFeature : Xunit.IClassFixture<CreatePostsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CreatePosts.feature"
#line hidden
        
        public CreatePostsFeature(CreatePostsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CreatePosts", "As a non-authenticated user,\r\nI want the ability to create a post.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.FactAttribute(DisplayName="A non-authenticated user successfully creates a post")]
        [Xunit.TraitAttribute("FeatureTitle", "CreatePosts")]
        [Xunit.TraitAttribute("Description", "A non-authenticated user successfully creates a post")]
        [Xunit.TraitAttribute("Category", "AcceptanceCriteria")]
        public virtual void ANon_AuthenticatedUserSuccessfullyCreatesAPost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A non-authenticated user successfully creates a post", null, new string[] {
                        "AcceptanceCriteria"});
#line 9
  this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line 10
    testRunner.Given("I have a string \"title\" named \"title1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
      testRunner.And("I have a string \"str body\" named \"body1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
      testRunner.And("I have an int \"1\" named \"userId1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
      testRunner.And("I have an int \"101\" named \"id1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "userId",
                        "userId1"});
            table1.AddRow(new string[] {
                        "id",
                        "id1"});
            table1.AddRow(new string[] {
                        "title",
                        "title1"});
            table1.AddRow(new string[] {
                        "body",
                        "body1"});
#line 14
      testRunner.And("I have a model \"createPostsModel1\" with the following values:", ((string)(null)), table1, "And ");
#line 20
     testRunner.When("I send a \"Post\" request to \"/posts\" with model \"createPostsModel1\" using client \"" +
                    "client1\" and get the response \"createPostsResponse1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
      testRunner.And("I get the content \"createPostsResponse1Body\" of the response \"createPostsResponse" +
                    "1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
     testRunner.Then("the response \"createPostsResponse1\" should have the status code \"Created\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
      testRunner.And("the model \"createPostsResponse1Body\" should have 4 parameters", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "userId",
                        "userId1"});
            table2.AddRow(new string[] {
                        "id",
                        "id1"});
            table2.AddRow(new string[] {
                        "title",
                        "title1"});
            table2.AddRow(new string[] {
                        "body",
                        "body1"});
#line 24
      testRunner.And("the model \"createPostsResponse1Body\" should match the following values:", ((string)(null)), table2, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CreatePostsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CreatePostsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
