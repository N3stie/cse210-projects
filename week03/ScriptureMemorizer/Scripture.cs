using System;


// this class it responsible for managing the scripture reference and the words in the scripture.
// so that i can use it in the program.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        while (wordsHidden < numberHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden++;
            }
        }
    }


    // i use this method to get the display text of the scripture.
    // it will return the reference and the words in the scripture.
    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}\n\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}