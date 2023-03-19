using ex1;


namespace ex1.Test
{
    public class Tests
    {
        [Test]
        [TestCase(2000)] 
        [TestCase(1004)] 
        public void YearIsLeapReturnsTrue(int year)
        {
            
            var result = Year.YearV(year);

            Assert.That(result, Is.EqualTo(result));
        }

        [Test]
        [TestCase(2001)] 
        [TestCase(1900)] 
        public void YearIsNotLeapReturnsFalse(int year)
        {
            var result = Year.YearV(year);

            Assert.That(result, Is.EqualTo(result));
        }
    }

}
