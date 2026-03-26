
public class Magazine : LibraryItem
{
    public int IssueNumber { get; init; }
    public string Publisher { get; init; }

    public Magazine(string title, int year, int issueNumber, string publisher) 
    : base(title, year)
    {
        IssueNumber = issueNumber;
        Publisher = publisher;
    }

    public override string GetInfo()
    {
        return $"{Title} ({Year}), выпуск {IssueNumber}, издательство: {Publisher}";
    }

}
