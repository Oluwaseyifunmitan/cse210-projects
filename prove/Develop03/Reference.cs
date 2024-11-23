public class Reference
{
    public string Book { get; private set; }
    public string VerseRange { get; private set; }

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        VerseRange = $"{chapter}:{verse}";
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        VerseRange = $"{chapter}:{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return $"{Book} {VerseRange}";
    }
}
