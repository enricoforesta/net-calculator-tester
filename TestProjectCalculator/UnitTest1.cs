using net_calculator_tester;
namespace TestProjectCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,1,3)]
        [TestCase(0,1,1)]
        [TestCase(45,1,46)]
        public void TestAdd(float a, float b, float result)
        {
            var result2 = Calculator.Add(a, b);
            Assert.IsTrue(result2 == result);
        }


        [Test]
        [TestCase(2, 1, 1)]
        [TestCase(0, 1, -1)]
        [TestCase(45, 1, 44)]
        public void TestSubtract(float a, float b, float result)
        {
            var result2 = Calculator.Substract(a, b);
            Assert.IsTrue(result2 == result);
        }
        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(0, 1, 0)]
        [TestCase(100, 0, 0)]
        public void TestDivide(float a, float b, float result)
        {
            try
            {
                var result2 = Calculator.Divide(a, b);
                Assert.IsTrue(result2 == result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [Test]
        [TestCase(10, 2, 20)]
        [TestCase(0, 1, 0)]
        [TestCase(100, 0, 0)]
        [TestCase(100, -10, -1000)]
        public void TestMultiply(float a, float b, float result)
        {
            var result2 = Calculator.Multiply(a, b);
            Assert.IsTrue(result2 == result);
        }
    }
}