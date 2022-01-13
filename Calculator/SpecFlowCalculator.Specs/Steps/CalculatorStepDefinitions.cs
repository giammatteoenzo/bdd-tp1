using System;
using TechTalk.SpecFlow;
using Xunit;


namespace SpecFlowCalculator.Specs.Steps
{
    using Calculator;
    
    [Binding]
    public sealed class CalculatorStepDefinitions
    { 

        private int _result;
        private string _error;
        private readonly Calculator _calculator = new Calculator();
        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        

        [Given("the first addition number is (.*)")]
        public void GivenTheFirstAdditionNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second addition number is (.*)")]
        public void GivenTheSecondAdditionNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two additions numbers are added")]
        public void WhenTheTwoAdditionsNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the addition result should be (.*)")]
        public void ThenTheAdditionResultShouldBe(int result)
        {
            Xunit.Assert.Equal(result, _result);
        }
        
        [Given("the first multiplication number is (.*)")]
        public void GivenTheFirstMultiplicationNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second multiplication number is (.*)")]
        public void GivenTheSecondMultiplicationNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two multiplications numbers are added")]
        public void WhenTheTwoMultiplicationsNumbersAreAdded()
        {
            _result = _calculator.Multiply();
        }

        [Then("the multiplication result should be (.*)")]
        public void ThenTheMultiplicationResultShouldBe(int result)
        {
            Console.WriteLine(_result);
            Xunit.Assert.Equal(result, _result);
        }
        
        [Given("the first division number is (.*)")]
        public void GivenTheFirstDivisionNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second division number is (.*)")]
        public void GivenTheSecondDivisionNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two division numbers are added")]
        public void WhenTheTwoDivisionNumbersAreAdded()
        {
            _result = _calculator.Divide();
            Console.WriteLine(_result);
        }

        [Then("the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(int result)
        {
            Xunit.Assert.Equal(result, _result);
        }
        
        [Given("the first division by zero number is (.*)")]
        public void GivenTheFirstDivisionByZeroNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second division by zero number is (.*)")]
        public void GivenTheSecondDivisionByZeroNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers division by zero are added")]
        public void WhenTheTwoNumbersDivisionByZeroAreAdded()
        {
            try
            {
                _calculator.Divide();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
            }
        }

        [Then(@"the error '(.*)' should be raised")]
        public void ThenTheErrorShouldBeRaised(string result)
        {
            Xunit.Assert.Equal(result, _error);
        }
    }
}