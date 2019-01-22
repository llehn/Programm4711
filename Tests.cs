using FluentAssertions;
using Xunit;

namespace Programm4711
{
    public class Tests
    {
        [Fact]
        public void Empty_String_Has_0_Words()
        {
            var sut = new WordCounter();
            sut.CountWords("").Should().Be(0);
        }        
    }
}