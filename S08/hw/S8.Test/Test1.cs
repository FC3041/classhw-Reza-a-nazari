using Microsoft.VisualStudio.TestTools.UnitTesting;
using S8;

namespace S8.Test
{
    [TestClass]
    public class StringManipulatorTests
    {
        [TestMethod]
        public void ReverseWords_InputIsHelloWorld_ReturnsWorldHello()
        {
            string input = "Hello World";
            string expected = "World Hello";
            string result = just_rev_string.rev_word_to_end(input);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseWords_Inp()
        {
            string input = "Example Test";
            string expected = "Test Example";

            string input2 = "panir por charb sabah";
            string expected2 = "sabah charb por panir";
            string result = just_rev_string.rev_word_to_end(input);
            string result2 = just_rev_string.rev_word_to_end(input2);
            Assert.AreEqual(expected2,result2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReverseWords_Words()
        {
            string input = "This is a test";
            string expected = "test a is This";
            string result = just_rev_string.rev_word_to_end(input);
            Assert.AreEqual(expected, result);
        }
    }
}
