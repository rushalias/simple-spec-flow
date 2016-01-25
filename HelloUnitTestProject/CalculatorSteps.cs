using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace HelloUnitTestProject
{
    [Binding]
    public class CalculatorSteps
    {
	    readonly Calculator _calculator = new Calculator();
		private int Result { get; set; }

		[Given(@"I have entered First Number (.*) into the calculator")]
        public void GivenIHaveEnteredFirstNumberIntoTheCalculator(int number)
        {
	        _calculator.FirstNumber = number;
        }
        
        [Given(@"I have entered Second Number (.*) into the calculator")]
        public void GivenIHaveEnteredSecondNumberIntoTheCalculator(int number)
        {
	        _calculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
	        Result = _calculator.Add();
        }

	    [Then(@"the result should be (.*) on the screen")]
	    public void ThenTheResultShouldBeOnTheScreen(int expectedResult) 
        {
			Assert.AreEqual(expectedResult, Result);
        }
    }
}
