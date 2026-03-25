using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Book
{
    private string title;
    private string author;
    private int year;
    private int pageCount;

    public Book(string title, string author, int year, int pageCount)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.pageCount = pageCount;
    }

    public Book(string title, string author) : this (title, author, 2026, 0) {}

    public Book() : this ("", "") {}

    public string GetInfo()
    {
        return $"book: {title}, author: {author}, year: {year}, pages: {pageCount}";
    }

    public string GetInfo(bool showPages)
    {
        if (showPages)
        {
            return GetInfo();
        }
        else
        {
            return $"book: {title}, author: {author}, year: {year}";
        }
    }

    public bool IsOlderThan(int years = 50)
    {
        if ((DateTime.Now.Year - year) > years)
        {
            return true;
        }
        return false;
    }

    public string GetFormattedInfo(string format = "short")
    {

        string PrintShortInfo()
        {
            return $"book: {title}, author: {author}";
        }

        if (format == "short")
        {
            return PrintShortInfo();
        }
        return GetInfo();
    }

}