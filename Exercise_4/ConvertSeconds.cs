using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    static class ConvertSeconds
    {
        //Convert seconds to whole minutes
        public static int convertToMinutes(int toBeConverted)
        {
            int answer = toBeConverted / 60;

            return answer;
        }

        //Convert seconds to whole hours
        public static int convertToHours(int toBeConverted)
        {
            int answer = toBeConverted / 3600;

            return answer;
        }

        //Convert seoncds to whole days
        public static int convertToDays(int toBeConverted)
        {
            int answer = toBeConverted / 86400;

            return answer;
        }

        // Create a DHMTTimeConversion object to pass values back to form 
        public static DHMTimeConversion convertToDayHourMinutes(int toBeConverted)
        {
            int days = 0;
            int hours = 0;
            int minutes = 0;

            if(toBeConverted < 60)
            {
                // If seconds input less than 1 minutes, no need to do any computing.  Just pass the default object data back (Default 0, 0, 0);
                return new DHMTimeConversion();

            }else if(toBeConverted >= 60 && toBeConverted < 3600)
            {

                minutes = toBeConverted / 60;

                return new DHMTimeConversion(days, hours, minutes);

            }else if(toBeConverted >= 3600 && toBeConverted < 86400)
            {
                hours = toBeConverted / 3600;
                //Remove value of hours from original seconds to accurate calculate minutes remaining
                minutes = toBeConverted - (hours * 3600);

                return new DHMTimeConversion(days, hours, minutes);

            }else if(toBeConverted >= 86400)
            {
                days = toBeConverted / 86400;
                //Remove value of days from original seconds to accurate calculate hours remaining
                hours = (toBeConverted - (days * 86400)) / 3600;
                //Remove value of days and hours from original seconds to accurate calculate minutes remaining
                minutes = ((toBeConverted - (days * 86400)) - (hours * 3600)) / 60;

                return new DHMTimeConversion(days, hours, minutes);
            }

            //if anything other than specified above is passed in, return a default DHMTimeConversion Object.
            return new DHMTimeConversion();
        }
    }
}
