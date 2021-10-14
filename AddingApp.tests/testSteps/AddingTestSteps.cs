using FluentAssertions;
using TechTalk.SpecFlow;

namespace AddingApp.tests
{
    [Binding]
    public class AddingTestSteps
    {
        readonly AddingCommand AddingStoreTest = new AddingCommand();
        readonly ConsoleWriter Console= new ConsoleWriter();
        int sum;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            AddingStoreTest.Value1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            AddingStoreTest.Value2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            sum = AddingStoreTest.Value1 + AddingStoreTest.Value2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            p0.Should().Be(sum);
            Console.PrintInt(sum);
        }
    }
}
