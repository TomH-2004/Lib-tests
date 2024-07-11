using WorkingCode;

namespace TestsForMethodsToTest
{
    [TestFixture(10, 3628800)]
    [TestFixture(7, 5040)]
    [TestFixture(4, 24)]
    [TestFixture(1, 1)]
    [TestFixture(0, 1)]
    public class FactorialTests
    {
        int _factorial;
        int _expectedValue;
        public FactorialTests(int factorial, int expectedValue)
        {
            _factorial = factorial;
            _expectedValue = expectedValue;
        }


        [Test]
        public void CheckFactorial()
        {
            var methods = new MethodsToBeTested();

            var calculatedFactorial = methods.CalculateFactorial(_factorial);
            Assert.That(_expectedValue, Is.EqualTo(calculatedFactorial));
        }
    }
}