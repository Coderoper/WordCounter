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
  }
}
