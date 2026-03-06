using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            // "leetcode" -> l appears once, is first unique at index 0
            Assert.AreEqual(0, Str.UniqueChar("leetcode"));
            // "zbcd" -> z appears once at index 0
            Assert.AreEqual(0, Str.UniqueChar("zbcd"));
        }

        [Test]
        public void UniqueChar_UniqueInMiddle_ReturnsCorrectIndex()
        {
            // "loveleetcode" -> first unique is 'v' at index 2
            Assert.AreEqual(2, Str.UniqueChar("loveleetcode"));
        }

        [Test]
        public void UniqueChar_AllRepeated_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabb"));
        }

        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("z"));
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_NullString_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void UniqueChar_AllSameChar_ReturnsNegativeOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aaaa"));
        }

        [Test]
        public void UniqueChar_UniqueAtEnd_ReturnsLastIndex()
        {
            // "aabbc" -> unique is 'c' at index 4
            Assert.AreEqual(4, Str.UniqueChar("aabbc"));
        }
    }
}
