using System;
using System.Text;

public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    public Event(DateTime date, string title, string location)
    {
        this.date = date;

        this.title = title;
        this.location = location;
    }

    public DateTime Date { get; set; }

    public string Title { get; set; }

    public string Location { get; set; }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int compareByDates = this.date.CompareTo(other.date);
        int compareByTitles = this.title.CompareTo(other.title);

        int compareByLocations = this.location.CompareTo(other.location);
        if (compareByDates == 0)
        {
            if (compareByTitles == 0)
            {
                return compareByLocations;
            }
            else
            {
                return compareByTitles;
            }
        }
        else
        {
            return compareByDates;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append(" | " + this.title);
        if (this.location != null && this.location != string.Empty)
        {
            toString.Append(" | " + this.location);
        }

        return toString.ToString();
    }
}
