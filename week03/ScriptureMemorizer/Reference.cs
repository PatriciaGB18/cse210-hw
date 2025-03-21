class Reference
{
    private string Book { get; }
    private int Chapter { get; }
    private int VerseStart { get; }
    private int? VerseEnd { get; }


    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        Book = book;
        Chapter = chapter;
        VerseStart = verseStart;
        VerseEnd = verseEnd;
    }

    public override string ToString()
    {
        return VerseEnd.HasValue
        ? $"{Book} {Chapter}:{VerseStart}-{VerseEnd}"
        : $"{Book} {Chapter}:{VerseStart}";
    }
}