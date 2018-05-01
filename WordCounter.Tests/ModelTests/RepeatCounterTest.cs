using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
namespace WordCounterApp.Controllers
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetSentence_ReturnSentence_String()
    {
      RepeatCounter placeHolder = new RepeatCounter("string word", "string sentence");
      //Arrange
      string sentence = placeHolder.GetSentence();
      string word = placeHolder.GetWord();

      Assert.AreEqual("string word", placeHolder.GetWord());
      Assert.AreEqual("string sentence", placeHolder.GetSentence());

    }
    [TestMethod]
    public void SeperateBySpacesCount()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("you","you you you you you");


      // Console.WriteLine(newRepeatCounter.GetWord());
      // Console.WriteLine(newRepeatCounter.GetSentence());

      Console.WriteLine(newRepeatCounter.WordCounter());

      Assert.AreEqual(5, newRepeatCounter.WordCounter());
    }
    [TestMethod]
    public void SeperateByDelimiters()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("you", " you, you! you. you: ");
      Assert.AreEqual(5, newRepeatCounter.WordCounter());

    }
  }
}
