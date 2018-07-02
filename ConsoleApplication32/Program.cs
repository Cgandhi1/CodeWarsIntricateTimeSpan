using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 255559;
            string answer = formatDuration(seconds);
        }

        public static string formatDuration(int seconds)
        {
            //test case 1
            int years = 0;
            string answer = "";

            if (seconds == 0)
            {
                answer = "now";
            }
            //test case 2
            else if (seconds < 31536000)
            {
                TimeSpan timespan = TimeSpan.FromSeconds(seconds);
                int day = timespan.Days;
                int hour = timespan.Hours;
                int min = timespan.Minutes;
                int sec = timespan.Seconds;

                string [] stringArray = new string[] {day + " days, ", hour + " hours, ", min + " minutes and ", sec + " seconds"};
                for (int i = 0; i < stringArray.Length; i++)
                {
                    string dynamic = stringArray[i];
                    string search = new string(dynamic.Where(c => char.IsDigit(c)).ToArray());
                    int searchnum = int.Parse(search);

                    if (searchnum > 0)
                    {
                        answer = answer + stringArray[i];
                    }

                }
                if ((sec == 0) && (hour > 0) && (min > 0))
                {
                    answer = answer.Replace(" and ", "");
                    answer = answer.Replace("hours, ", "hours and ");
                }

                if (day == 1)
                {
                    answer = answer.Replace("days", "day");
                }
                if (hour == 1)
                {
                    answer = answer.Replace("hours", "hour");
                }
                if (min == 1)
                {
                    answer = answer.Replace("minutes", "minute");
                }
                if (sec == 1)
                {
                    answer = answer.Replace("seconds", "second");
                }

            }
            //test case 3
            else if (seconds == 31536000)
            {
                answer = "1 year";
            }

            //test case 4
            else if (seconds > 31536000)
            {
                years = seconds / 31536000;
                int xyearstosec = years * (365 * 24 * 3600);
                int remainingSecs = seconds - xyearstosec;
                TimeSpan timespan = TimeSpan.FromSeconds(remainingSecs);
                int day = timespan.Days;
                int hour = timespan.Hours;
                int min = timespan.Minutes;
                int sec = timespan.Seconds;

                string[] stringArray = new string[] {years + " years, ", day + " days, ", hour + " hours, ", min + " minutes and ", sec + " seconds"};
                for (int i = 0; i < stringArray.Length; i++)
                {
                    string dynamic = stringArray[i];
                    string search = new string(dynamic.Where(c => char.IsDigit(c)).ToArray());
                    int searchnum = int.Parse(search);

                    if (searchnum > 0)
                    {
                        answer = answer + stringArray[i];
                    }
                }
                if ((sec == 0) && (hour > 0) && (min > 0))
                {
                    answer = answer.Replace(" and ", "");
                    answer = answer.Replace("hours, ", "hours and ");
                }

                if (years == 1)
                {
                    answer = answer.Replace("years", "year");
                }
                if (day == 1)
                {
                    answer = answer.Replace("days", "day");
                }
                if (hour == 1)
                {
                    answer = answer.Replace("hours", "hour");
                }
                if (min == 1)
                {
                    answer = answer.Replace("minuts", "minute");
                }
                if (sec == 1)
                {
                    answer = answer.Replace("seconds", "second");
                }

            }
            return answer;
        }


    }
    }
