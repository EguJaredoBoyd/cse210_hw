public class Reference
{
    private string reference;
    
    // Constructor for a single verse
    public Reference(string reference)
    {
        this.reference = reference;
    }
    
    // Constructor for a range of verses (e.g., "Proverbs 3:5-6")
    public Reference(string book, int startChapter, int startVerse, int endVerse)
    {
        this.reference = $"{book} {startChapter}:{startVerse}-{endVerse}";
    }
    
    public string GetReference()
    {
        return reference;
    }
}
