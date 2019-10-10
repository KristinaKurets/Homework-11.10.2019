using System;
using System.Collections.Generic;
using System.Text;

namespace homework_11._10
{
    class Tolchok
    {
        public string Name { get; set; }
        public int Age { get { return Years(DateOfBirth, DateTime.Now); } }
        public DateTime DateOfBirth { get; set; }
        

        private int Years(DateTime start, DateTime end)
        {
            int difference = (end.Year - start.Year - 1) +
                (((end.Month > start.Month) ||
                ((end.Month == start.Month) && (end.Day >= start.Day)))
                ? 1 : 0);
            return difference;
        }

    }
}
