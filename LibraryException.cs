
public class LibraryException : Exception
{
    public LibraryException(string message) : base(message) { }
}

public class InvalidBookDataException : LibraryException
{
    public InvalidBookDataException(string message) : base(message) { }
}
