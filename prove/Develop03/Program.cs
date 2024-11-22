using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Reference.GetReference());
        foreach (var word in Words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Any())
        {
            var rand = new Random();
            var wordToHide = visibleWords[rand.Next(visibleWords.Count)];
            wordToHide.Hide();
        }
    }
}

public class Reference
{
    public string ReferenceText { get; set; }

    public Reference(string reference)
    {
        ReferenceText = reference;
    }

    public string GetReference() => ReferenceText;
}

public class Word
{
    public string OriginalWord { get; set; }
    public string DisplayedWord { get; set; }
    public bool IsHidden { get; private set; }

    public Word(string word)
    {
        OriginalWord = word;
        DisplayedWord = word;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
        DisplayedWord = new string('_', OriginalWord.Length);
    }

    public string Display() => DisplayedWord;
}

class Program
{
    static void Main()
    {
        string scriptureText = "For God so loved the world that He gave His only begotten Son";
        string reference = "John 3:16";

        var scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");

            var userInput = Console.ReadLine();
            if (userInput?.ToLower() == "quit") break;

            scripture.HideRandomWord();
        }

        Console.WriteLine("All words hidden. Goodbye!");
    }
}
