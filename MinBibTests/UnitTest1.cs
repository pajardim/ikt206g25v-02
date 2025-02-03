using Xunit;
using MinBib;

namespace MinBibTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.True(result, 
                    $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [Fact]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.False(result, 
                    $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [Fact]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string?[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.False(result, 
                    $"Expected for '{word ?? "<null>"}': false; Actual: {result}");
            }
        }
    }
}
