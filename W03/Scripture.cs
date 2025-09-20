using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.ToString() + "\n";
        foreach (Word word in _words)
        {
            display += word.GetDisplayText() + " ";
        }
        return display.Trim();
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int wordsToHide = Math.Min(count, _words.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int idx = rand.Next(_words.Count);
            _words[idx].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden) return false;
        }
        return true;
    }
}
