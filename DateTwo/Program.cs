using System;

class Date
{
    private int d;
    private int m;
    private int y;

    public int Day
    {

        get { return d; }

        set
        {
            if (value > 31 || value < 1)
            {

                Console.WriteLine("Invalid day");
            }

            d = value;
        }
    }

    public int Month
    {

        get { return m; }

        set
        {
            if (value > 12 || value < 1)
            {

                Console.WriteLine("Invalid month");
            }

            m = value;
        }
    }

    public int Year
    {

        get { return y; }

        set
        {
            if (Convert.ToString(value).Length != 4)
            {

                Console.WriteLine("Year must be 4 digits");
            }

            y = value;
        }
    }

    public Date()
    {
        m = 1;
        d = 1;
        y = 2000;
    }

    public Date(int m, int d, int y)
    {
        Month = m;
        Day = d;
        Year = y;
    }

    public string DisplayUSFormat()
    {

        if (Month <= 12 && Month >= 1)
        {

            if (Day <= 31 && Day >= 1)
            {

                if (Convert.ToString(Year).Length == 4)
                {

                    return Month.ToString("D2") + "/" + Day.ToString("D2") + "/" + Year;
                }
            }
        }
        return "Invalid date";
    }

    public string DisplayIntlFormat()
    {

        if (Month <= 12 && Month >= 1)
        {

            if (Day <= 31 && Day >= 1)
            {

                if (Convert.ToString(Year).Length == 4)
                {

                    return Year + "-" + Month.ToString("D2") + "-" + Day.ToString("D2");
                }
            }
        }
        return "Invalid date";
    }
    public static bool operator ==(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year == b.Day + b.Month + b.Year;
    }
    public static bool operator !=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year != b.Day + b.Month + b.Year;
    }
    public static bool operator <(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year < b.Day + b.Month + b.Year;
    }
    public static bool operator <=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        if (a.Year <= b.Year && a.Month <= b.Month && a.Day <= b.Day)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool operator >(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        return a.Day + a.Month + a.Year > b.Day + b.Month + b.Year;
    }
    public static bool operator >=(Date a, Date b)
    {
        if (a.Month > 12 && a.Month < 1 || b.Month > 12 && b.Month < 1)
        {
            return false;
        }
        if (a.Day > 31 && a.Day < 1 || b.Day > 31 && b.Day < 1)
        {
            return false;
        }
        if (Convert.ToString(a.Year).Length != 4 || Convert.ToString(b.Year).Length != 4)
        {
            return false;
        }
        if (a.Year >= b.Year && a.Month >= b.Month && a.Day >= b.Day)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override bool Equals(object obj)
    {
        return obj is Date date &&
               d == date.d &&
               m == date.m &&
               y == date.y &&
               Day == date.Day &&
               Month == date.Month &&
               Year == date.Year;
    }

    public override int GetHashCode()
    {
        return 1;
    }
}