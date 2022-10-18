using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Program
    {
        static void Main()
        {
            DateTime nowData = DateTime.Now;
            string[] date = nowData.ToString().Split(' ')[0].Split('.');
            Console.WriteLine(date);

            string dateMonth = date[0];
            string dateDay = date[1];
            string dateYear = date[2];

            string time = nowData.ToString().Split(' ')[1];

            string timeHour = time.Split(':')[0];
            string timeMinutes = time.Split(':')[1];
            string timeSecond = time.Split(':')[2];

            Years years = new Years();
            years.text = dateYear;

            Month month = new Month();
            month.text = dateMonth;

            day day = new day();
            day.text = dateDay;

            Hour hour = new Hour();
            hour.text = timeHour;

            Minutes minutes = new Minutes();
            minutes.text = timeMinutes;

            Seconds seconds = new Seconds();
            seconds.text = timeSecond;

            Connection.data.Years.Add(years);
            Connection.data.Month.Add(month);
            Connection.data.day.Add(day);
            Connection.data.Hour.Add(hour);
            Connection.data.Minutes.Add(minutes);
            Connection.data.Seconds.Add(seconds);
            Connection.data.SaveChanges();
        }
    }
    internal class Connection
    {
        public static DataEntities data = new DataEntities();
    }
}
