using System;
using System.Text;

public static class Extetntions
{
     public static TimeSpan ToTimeSpan(this int timeInSeconds)
    {
        return TimeSpan.FromSeconds(timeInSeconds);
    }

    public static string ToMoneyFormat(this int value)
    {
        StringBuilder stringBuilder = new StringBuilder(value.ToString());

        var length = stringBuilder.Length - 3;

        for (int i = length; i > 0; i-=3)
        {
            stringBuilder.Insert(i, ',');
        }

        return stringBuilder.ToString();
    }
}
