using System.Text;

namespace DotNetTests.Tests
{
    public class StringBuilderTests
    {
        [Fact]
        public void Append_ForTwoStrings_ReturnsConcatenatedString()
        {
            //NazwaMetody_Scenariusz_Rezultat
            // arrange

            StringBuilder sb = new StringBuilder();

            // act

            sb.Append("test")
                .Append("test2");

            string result = sb.ToString();

            // assert

            Assert.Equal("testtest2", result);
        }
    }
}