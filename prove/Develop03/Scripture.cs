using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordTokens = text.Split(' ');
        foreach (string wordToken in wordTokens)
        {
            Word word = new Word(wordToken);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        List<int> available = Enumerable.Range(0, _words.Count).Where(i => !_words[i].IsHidden()).ToList();
        if (numberToHide >= available.Count())
        {
            // Hide all _words if numberToHide is greater than or equal to the total _words
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }
        else
        {
            // Hide random _words
            Random random = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int randomIndex = random.Next(0, available.Count());
                _words[available[randomIndex]].Hide();
                available.RemoveAt(randomIndex);
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                displayText.Append(new string('_', word.GetDisplayText().Length)).Append(" ");
            }
            else
            {
                displayText.Append(word.GetDisplayText()).Append(" ");
            }
        }
        return displayText.ToString().Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    public Reference GetReference()
    {
        return _reference;
    }
}