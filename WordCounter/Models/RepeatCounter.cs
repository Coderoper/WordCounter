using System.Collections.Generic;
using System.IO;
using System;
namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _wordCount =0;
    // private static List<RepeatCounter>_words = new List<RepeateCounter>{};

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetSentence()
    {
      return _sentence;
    }

    public void SetSentence(string newSentence)
    {
      _sentence = newSentence;
    }

    public string GetWord()
    {
      return _word;
    }
    public void SetWord(string newWord)
    {
      _word = newWord;
    }
  }
}
