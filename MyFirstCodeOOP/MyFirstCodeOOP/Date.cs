using System;

public class Date
{
    #region Properties
    int _day;
	int _month;
	int _year;
    #endregion

    #region Constructor
    public Date(int day, int month, int year)
    {
        _day = ValidateDay(day);
        _month = ValidateMonth(month);
        _year = year;
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"{_day:00}/{_month:00}/{_year:0000}";
    }

    private int ValidateDay(int day)
    {
        return day;
    }

    private int ValidateMonth(int month)
    {
        if (month >=1 && month <= 12)
        {
            return month;
        }

        throw new MonthException("The month is invalid!");
    }
    #endregion

}
