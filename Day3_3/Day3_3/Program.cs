using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_3
{
    class DayCollection
    {
        string[] days = { "일", "월", "화", "수", "목", "금", "토" };

        private int GetDay(string testDay)
        {
            for(int i=0; i < days.Length; i++)
            {
                if(days[i] == testDay) { return i; }
            }
            return 999; 
        }

        public int this[string day]
        {
            get { return (GetDay(day)); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DayCollection week = new DayCollection();
            System.Console.WriteLine(week["일"]);
            System.Console.WriteLine(week["Made-up day"]);

        }
    }
}
