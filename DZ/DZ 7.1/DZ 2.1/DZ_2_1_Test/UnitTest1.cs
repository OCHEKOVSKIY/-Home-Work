using NUnit.Framework;
using DZ_2_1;

namespace DZ_2_1.Tests
{
    [TestFixture]
    public class SubstringCounterTests
    {
        [Test]
        public void TestCountOccurrences_ValidInput_ReturnsCorrectCount()
        {
            // Arrange
            string s = "hello world hello";
            string s1 = "hello";

            // Act
            int result = SubstringCounter.CountOccurrences(s, s1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestCountOccurrences_EmptyString_ReturnsZero()
        {
            // Arrange
            string s = "";
            string s1 = "hello";

            // Act
            int result = SubstringCounter.CountOccurrences(s, s1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestCountOccurrences_SubstringLargerThanString_ReturnsZero()
        {
            // Arrange
            string s = "short";
            string s1 = "longersubstring";

            // Act
            int result = SubstringCounter.CountOccurrences(s, s1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestCountOccurrences_NoMatch_ReturnsZero()
        {
            // Arrange
            string s = "hello world";
            string s1 = "abc";

            // Act
            int result = SubstringCounter.CountOccurrences(s, s1);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
