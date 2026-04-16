
public class Magazine : LibraryItem, IContentSearch, IExportable
{
    public int IssueNumber { get; init; }
    public string Publisher { get; init; }

    public Magazine(string title, int year, int issueNumber, string publisher) 
    : base(title, year)
    {
        IssueNumber = issueNumber;
        Publisher = publisher;
    }


    public override string GetCardInfo()
    {
        return $"{Title} ({Year}), выпуск {IssueNumber}, издательство: {Publisher}";
    }

    public string ToCSV()
    {
        return $"magazine;{Title};{Publisher};{Year};{IssueNumber}";
    }

    string IExportable.ToJson()
    {
        return $"{{\"type\":\"magazine\",\"title\":\"{Title}\",\"publisher\":\"{Publisher}\",\"year\":{Year},\"issueNumber\":{IssueNumber}}}";
    }


    public bool ContainsKeyword(string word)
    {
        return Title.Contains(word, StringComparison.OrdinalIgnoreCase) || Publisher.Contains(word, StringComparison.OrdinalIgnoreCase);
    }

}
