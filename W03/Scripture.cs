using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.ToString());
        foreach (Word word in _words)
        {
            Console.Write(word.ToString() + " ");
        }
        Console.WriteLine("\n");
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                visibleIndexes.Add(i);
        }
        int toHide = Math.Min(count, visibleIndexes.Count);
        for (int i = 0; i < toHide; i++)
        {
            int idx = rand.Next(visibleIndexes.Count);
            _words[visibleIndexes[idx]].Hide();
            visibleIndexes.RemoveAt(idx);
        }
    }
}
