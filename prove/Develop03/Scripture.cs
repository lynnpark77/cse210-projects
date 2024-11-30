using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }
    public Reference GetReference()
    {
        return _reference;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        int nonHiddenWordsCount = 0;

        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                nonHiddenWordsCount++;
                
            }
        }
        
        int wordsToHide = numberToHide;
        if(nonHiddenWordsCount < numberToHide)
        {
            wordsToHide = nonHiddenWordsCount;
        }
        
        while(hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);

            if(!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }



    }
    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                text += new string('_', word.GetDisplayText().Length);
            }
            else
            {
                text += word.GetDisplayText();
            }
            text += " ";
        }

        return text;


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

 
}