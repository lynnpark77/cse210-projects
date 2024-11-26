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

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

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
            if ( !word.IsHidden())
            {
                return false;
            }
        }

        return true;

    }

 
}