using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    static class ConvertSeconds
    {
        public static int convertToMinutes(int toBeConverted)
        {
            int answer = toBeConverted / 60;

            return answer;
        }

        public static int convertToHours(int toBeConverted)
        {
            int answer = toBeConverted / 3600;

            return answer;
        }

        public static int convertToDays(int toBeConverted)
        {
            int answer = toBeConverted / 86400;

            return answer;
        }

        public static DHMTimeConversion convertToDayHourMinutes(int toBeConverted)
        {
            int days = 0;
            int hours = 0;
            int minutes = 0;

            if(toBeConverted < 60)
            {
                return new DHMTimeConversion();

            }else if(toBeConverted >= 60 && toBeConverted < 3600)
            {

                minutes = toBeConverted / 60;

                return new DHMTimeConversion(days, hours, minutes);

            }else if(toBeConverted >= 3600 && toBeConverted < 86400)
            {
                hours = toBeConverted / 3600;
                minutes = toBeConverted - (hours * 3600);

                return new DHMTimeConversion(days, hours, minutes);
            }else if(toBeConverted >= 86400)
            {
                days = toBeConverted / 86400;
                hours = (toBeConverted - (days * 86400)) / 3600;
                minutes = ((toBeConverted - (days * 86400)) - (hours * 3600)) / 60;

                return new DHMTimeConversion(days, hours, minutes);
            }

            return new DHMTimeConversion();
        }
    }
}
