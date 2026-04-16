



public enum BookGenre
{
    Unknown,
    Novel,
    SciFi,
    Detective,
    History
}


public enum ItemStatus
{
    Availiable,
    Reserved,
    OnLoan
}

[Flags]
public enum SearchOptions
{
    None = 0,
    ByTitle = 1,
    ByAuthor = 2,
    ByPublisher = 4,
    All = ByTitle | ByAuthor | ByPublisher
}
