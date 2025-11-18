using System;

public class Time
{
    private int hours;
    private int minutes;
    private int seconds;
    public Time(int hours, int minutes, int seconds)
    {
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
    }
    public int this[int index]
    {
        get
        {
            switch (index)
            {
                case 0:
                    return hours;
                case 1:
                    return minutes;
                case 2:
                    return seconds;
                default: return 0;
            }
        }
        set
        {
            switch (index)
            {
                case 0:
                    hours = value;
                    break;
                case 1:
                    minutes = value;
                    break;
                case 2:
                    seconds = value;
                    break;
            }
        }
    }
    public static bool operator >(Time time1, Time time2)
    {
        int totalTime1 = time1.hours * 3600 + time1.minutes * 60 + time1.seconds;
        int totalTime2 = time2.hours * 3600 + time2.minutes * 60 + time2.seconds;
        return totalTime1 > totalTime2;
    }
    public static bool operator <(Time time1, Time time2)
    {
        int totalTime1 = time1.hours * 3600 + time1.minutes * 60 + time1.seconds;
        int totalTime2 = time2.hours * 3600 + time2.minutes * 60 + time2.seconds;
        return totalTime1 < totalTime2;
    }
    public override string ToString()
    {
        return $"{hours}:{minutes}:{seconds}";
    }
}