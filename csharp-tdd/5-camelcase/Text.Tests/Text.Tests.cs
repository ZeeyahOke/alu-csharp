using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            Assert.AreEqual(2, Str.CamelCase("helloWorld"));
        }

        [Test]
        public void CamelCase_ThreeWords_ReturnsThree()
        {
            Assert.AreEqual(3, Str.CamelCase("saveMyLife"));
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(null));
        }

        [Test]
        public void CamelCase_ManyWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(5, Str.CamelCase("thisIsALongString"));
        }

        [Test]
        public void CamelCase_AllLowercase_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("abc"));
        }

        [Test]
        public void CamelCase_ConsecutiveCapitals_CountsEach()
        {
            // "myABTest" -> my, A, B, Test = 4 words
            Assert.AreEqual(4, Str.CamelCase("myABTest"));
        }
    }
}
