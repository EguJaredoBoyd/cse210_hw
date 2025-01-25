using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();
        
        // Split the scripture text into words and add to the words list.
        foreach (var word in text.Split(' '))
        {
            words.Add(new Word(word));
        }
    }
    
    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (var word in words)
        {
            Console.Write(word.GetDisplay() + " ");
        }
        Console.WriteLine();
    }
    
    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        
        // Hide words randomly
        while (hiddenCount < count)
        {
            int index = rand.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hiddenCount++;
            }
        }
    }
    
    public bool AreAllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
