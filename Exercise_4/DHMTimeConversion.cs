using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class DHMTimeConversion
    {
        public DHMTimeConversion()
        {

        }

        public DHMTimeConversion(int days, int hours, int minutes)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }

        int days = 0;
        int hours = 0;
        int minutes = 0;

        public void setDays(int days)
        {
            this.days = days;
        }

        public int getDays()
        {
            return this.days;
        }

        public void setHours(int hours)
        {
            this.hours = hours;
        }

        public int getHours()
        {
            return this.hours;
        }

        public void setMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public int getMinutes()
        {
            return this.minutes;
        }
    }
}
