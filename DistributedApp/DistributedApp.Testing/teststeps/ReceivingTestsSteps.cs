using FluentAssertions;
using Infrastructure;
using ReceivingApp.Handlers;
using TechTalk.SpecFlow;

namespace DistributedApp.Testing.teststeps
{
    [Binding]
    public class ReceivingTestsSteps
    {
        AddingCommand AddingTest;
        AddingCommandHandler AddingHandle;
        IOutputWriter OutputWriter;

        [BeforeScenario]
        public void SetupSender()
        {
            OutputWriter = new ConsoleWriter();
            AddingHandle = new AddingCommandHandler(OutputWriter);
        }

        //[Given(@"input first input value of (.*)")]
        //public void GivenInputFirstInputValueOf(int p0)
        //{
        //    valueOne = p0;
        //}

        //[Given(@"the second input value of (.*)")]
        //public void GivenTheSecondInputValueOf(int p0)
        //{
        //    valueTwo = p0;
        //}

        //[When(@"an adder instance is created")]
        //public void WhenAnAdderInstanceIsCreated()
        //{
        //    AddingTest = new AddingCommand(valueOne, valueTwo);
        //}

        [Given(@"input first input value of (.*) and (.*)")]
        public void GivenInputFirstInputValueOfAnd(int p0, int p1)
        {
            AddingTest = AddingCommandTransform(p0, p1);
        }

        [Then(@"the sum should be (.*)")]
        public void ThenTheSumShouldBe(int p0)
        {
            p0.Should().Be(AddingHandle.CalculateSum(AddingTest));
        }

        [StepArgumentTransformation]      //Not really how this should be used
        AddingCommand AddingCommandTransform(int v1, int v2)
        {
            return new AddingCommand(v1, v2);
        }
    }
}
