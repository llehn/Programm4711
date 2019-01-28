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

        [Fact]
        public void One_Word_In_String_Should_Return_1()
        {
            var sut = new WordCounter();
            sut.CountWords("Wort").Should().Be(1);
        }

         [Fact]  
         public void Ten_Words_Should_Return_10()
        {
            var sut = new WordCounter();
            sut.CountWords("Ich_bin_Ingo_und_ich_spiele_sehr_gerne_am_Computer").Should().Be(10);
        }
         [Fact]
          public void Words_With_Ä_And_Ü_Should_Return_1()
          {
              var sut = new WordCounter();
              sut.CountWords("Äpfel und Übung").Should().Be(3);
          }
         
          [Fact]
          public void Spaces_Between_Words_Should_Return_10()
          {
              var sut = new WordCounter();
              sut.CountWords("Hi ich bin trölf").Should().Be(4);
          }

          [Fact]
          public void Two_Spaces_Between_Words()
          {
              var sut = new WordCounter();
              sut.CountWords("Hi  ich      bin").Should().Be(3);
          }

        [Fact]
        public void Two_Commas_Between_Words()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi,,,  ich      bin").Should().Be(3);
        }

        [Fact]
        public void With_Commas_Between_Words()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi,ich,bin").Should().Be(3);
        }

        [Fact]
        public void With_Dash_Between_Words1()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi,ich,bin blau-möger").Should().Be(4);
        }

        [Fact]
        public void With_Dash_Between_Words2()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi,ich,bin blau - richtig?").Should().Be(5);
        }
       
          
        [Fact]
        public void With_Exclamation_Mark_In_Between_Words()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi!!! ich!!!!!!!!bin!!richtig!blau!!!!!").Should().Be(5);
        } 

        [Fact]
        public void With_Question_Mark_In_Between_Words()
        {
            var sut = new WordCounter();
            sut.CountWords("Hi??????????ich ?? bin??????blau???? richtig!").Should().Be(5);
        }
                 
        [Fact]
        public void With_LineBreaksb()
        {
            var sut = new WordCounter();
            sut.CountWords("das ist eine\r\ndatei mit\r\nmehreren\r\nzeilen\r\nund zeugs").Should().Be(9);
        }
    }
}