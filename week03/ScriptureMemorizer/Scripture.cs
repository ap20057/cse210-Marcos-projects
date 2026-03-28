using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count = 3)
    {
        int hidden = 0;
        while (hidden < count)
        {
            int index = _random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (var word in _words)
            if (!word.IsHidden()) return false;
        return true;
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
            Console.Write(word.GetDisplayText() + " ");
        Console.WriteLine("\n");
    }
}