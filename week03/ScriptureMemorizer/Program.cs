using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message for the user
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        
        // Initialize reference and scripture
        Reference ref1 = new Reference("John 3:16");
        Scripture scripture = new Scripture(ref1, "For God so loved the world that he gave his only begotten Son");
        
        // Start the memorization process
        while (true)
        {
            Console.Clear(); // Clear the console to display updated scripture
            scripture.Display(); // Display the current scripture with hidden words

            // Check if all words are hidden
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("All words have been hidden! Memorization complete.");
                break;
            }

            // Prompt the user to either press enter or quit
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break; // Exit the program if 'quit' is typed
            }

            // Hide a few random words each time the user presses Enter
            scripture.HideRandomWords(3); // Change 3 to any number of words to hide
        }
    }
}
