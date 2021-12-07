using FluentAssertions;
using TechTalk.SpecFlow;
using BPCalculator;

namespace SpecFlowProject1.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly BloodPressure _calculator = new BloodPressure();

        private BPCategory _result;
        private string _resultstring;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the systolic number is (.*)")]
        public void GivenTheSystolicNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.Systolic = number;
        }

        [Given("the diastolic number is (.*)")]
        public void GivenTheDiastolicNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _calculator.Diastolic = number;
        }

        [When("the blood pressure is determined")]
        public void WhenTheBloodPressureIsDetermined()
        {
            //TODO: implement act (action) logic

            _result = _calculator.Category;
            _resultstring = _result.ToString();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            //TODO: implement assert (verification) logic

            _resultstring.Should().Be(result);
        }
    }
}