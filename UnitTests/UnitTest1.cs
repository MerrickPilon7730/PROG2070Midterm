using MidTermPROG2070;
namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Program program = new Program();
        }

        [Test]
        public void BelowZero_NegativeNumber_OutputIdentifiesNegativeNumber()
        {
            int isNegative = -5;
            string result = Program.CategorizeNumber(isNegative);

            Assert.Pass(result, Is.EqualTo("The number is negative."));
        }

        [Test]
        public void NumberIsZero_Zero_OutputIdentifiesZero()
        {
            int zero = 0;
            string result = Program.CategorizeNumber(zero);

            Assert.Pass(result, Is.EqualTo("The number is zero."));
        }

        [Test]
        public void Between1And10_Seven_OutputIdentifiesZero()
        {
            int seven = 7;
            string result = Program.CategorizeNumber(seven);

            Assert.Pass(result, Is.EqualTo("The number is between 1 and 10."));
        }

        [Test]
        public void NumberIs70_70_OutputIdentifiesBetween61And70()
        {
            int seventy = 70;
            string result = Program.CategorizeNumber(seventy);

            Assert.Pass(result, Is.EqualTo("The number is between 61 and 70."));
        }

        [Test]
        public void NumberIsGreaterThan70_100_OutputIdentifiesGreaterThan70()
        {
            int hundred = 100;
            string result = Program.CategorizeNumber(hundred);

            Assert.Pass(result, Is.EqualTo("The number is greater than 70."));
        }
    }
}