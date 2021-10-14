using AppliedSystems.Messaging.Infrastructure.Commands;
using FluentAssertions;
using Infrastructure;
using SendingApp;
using System;
using TechTalk.SpecFlow;

namespace DistributedApp.Testing.teststeps
{
    [Binding]
    public class SendingTestsSteps
    {
        private IMessageSender messageSender;
        private string inputString;
        AddingCommand AddingTest;
        private readonly ICommandDispatcher dispatcher;
        private Exception exceptionRaised;

        [BeforeScenario]
        public void SetupSender()
        {
            IRouter commandRouter = new Router(commandDispatcher: dispatcher);
            messageSender = new MessageSender(commandRouter);
        }

        [Given(@"the input string of (.*)")]
        public void GivenTheInputStringOf(string p0)
        {
            inputString = p0;
        }

        [When(@"the sender is called")]
        public void WhenTheSenderIsCalled()
        {
            try
            {
                AddingTest = messageSender.ParseMessage(inputString);

            }
            catch (Exception ex)
            {
                exceptionRaised = ex;
            }
        }

        [Then(@"the first value should be (.*)")]
        public void ThenTheFirstValueShouldBe(int p0)
        {
            p0.Should().Be(AddingTest.TermOne);
        }

        [Then(@"the second value should be (.*)")]
        public void ThenTheSecondValueShouldBe(int p0)
        {
            p0.Should().Be(AddingTest.TermTwo);
        }

        [Then(@"an exception should be raised")]
        public void ThenAnExceptionShouldBeRaised()
        {
            exceptionRaised.Should().BeOfType<ArgumentException>();
            exceptionRaised.Message.Should().Be("Two parameters are required");
        }

    }
}