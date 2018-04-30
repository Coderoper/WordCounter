using System.Collections.Generic;
using System.IO;
using System;
namespace WordCounterApp.Models
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _wordCount;
    // private static List<RepeatCounter>_words = new List<RepeateCounter>{};

    public RepeatCounter(string newWord, string newSentence)
    {
      _word = newWord;
      _sentence = newSentence;
      _wordCount=0;
    }
    public int GetWordCount()
    {
      return _wordCount;
    }
    public void SetWordCount(int newWordCount)
    {
      _wordCount = newWordCount;
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
    public static int WordCounter(RepeatCounter newRepeatCounter)
    {
      string newSentence = newRepeatCounter.GetSentence();
      string newWord = newRepeatCounter.GetWord();

      int wordAmount=0;

      char[] delimiters = { ' ', ',', '.', ':', '!', '\t' };
      string[] words=newSentence.Split(delimiters);

      for(int x = 0; x<words.Length; x++)
      {
        if (words[x] == newWord){
          wordAmount++;
          Console.WriteLine(wordAmount);

        } else{}
      }
      newRepeatCounter.SetWordCount(wordAmount);
      return wordAmount;
    }
  }
}
