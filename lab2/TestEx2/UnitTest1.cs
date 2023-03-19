using lab2;


namespace lab2.Test
{
    public class Tests
    {
        [Test]
        [TestCase(3)]
        [TestCase(113)]
        [TestCase(211)]
        [TestCase(577)]
        public void PrimeNumberReturnsTrue(int number)
        {
            var result = MathN.PrimeN(number);

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(22)]
        public void PrimeNumberReturnsFalse(int number)
        {
            var result = MathN.PrimeN(number);

            Assert.IsFalse(result);
        }
    }

}