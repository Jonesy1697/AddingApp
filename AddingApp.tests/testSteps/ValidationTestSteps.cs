using FluentAssertions;
using TechTalk.SpecFlow;

namespace AddingApp.tests
{
    [Binding]
    public class ValidationTestSteps
    {
        string inputValue;
        private readonly AddingService testAddingService = new AddingService();
        readonly ConsoleWriter Console = new ConsoleWriter();

        [Given(@"the string value of ""(.*)""")]
        public void GivenTheStringValueOf(string p0)
        {
            inputValue = p0;
        }

        [Given(@"the string value of ""(.*)"" input to class call")]
        public void GivenTheValueOf(string p0)
        {
            testAddingService.ValidateInput(p0);
        }

        [Then(@"the valid result should be ""(.*)""")]
        public void ThenTheValidResultShouldBe(string p0)
        {
            bool resultTest = false;
            if (p0.Equals("true")) { resultTest = true; }

            resultTest.Should().Be(testAddingService.ValidInput(inputValue));
        }
    }
}
