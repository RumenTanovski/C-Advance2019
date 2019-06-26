using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private DateTime startDate;
        private DateTime endDate;
        private double days;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public double Days
        {
            get { return days; } 
            set { days = value; }
        }
        public DateModifier()
        {

        }
        public DateModifier(DateTime startDate, DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public void Diferance(DateTime endDate, DateTime startDate)
        {
            var days = (endDate - startDate).TotalDays;
            Console.WriteLine(days);
        }        
    }
}
