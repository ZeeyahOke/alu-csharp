using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_SimpleWord_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        [Test]
        public void IsPalindrome_MixedCase_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        [Test]
        public void IsPalindrome_TwoSameChars_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("aa"));
        }

        [Test]
        public void IsPalindrome_TwoDiffChars_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("ab"));
        }

        [Test]
        public void IsPalindrome_OnlySpaces_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("   "));
        }

        [Test]
        public void IsPalindrome_NumericPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("12321"));
        }

        [Test]
        public void IsPalindrome_NumericNotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("12345"));
        }
    }
}
