using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day3_16
{
    /*
        class LynqLetExample
        {
            static void Main()
            {
                string[] myFavor =
                {
                    "Apple,Banana,Strawberry",
                    "Baseball,Football,Soccur",
                    "Programming,Design,Assembly",
                };

                var favorite =
                                from m in myFavor
                                let favor = m.Split(',')
                                from word in favor
                                let w = word.ToLower()
                                where w[0] == 'a'
                                select word; 

                foreach(var w in favorite)
                {
                    Console.WriteLine("A로 시작되는 단어 : {0}", w);
                }
            }
        }
        */
    class OnjProfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Onj
    {
        static void Main(string[] args)
        {
            OnjProfile[] onjProfile = {
            new OnjProfile() {Name="ONJSYSTEM", Age=8},
            new OnjProfile() {Name="오라클자바커뮤니티학원", Age=6},
            new OnjProfile() {Name="오라클자바커뮤니티1", Age=13},
            new OnjProfile() {Name="오라클자바커뮤니티2", Age=13},
            new OnjProfile() {Name="오라클자바커뮤니티3", Age=13}
};
            var onjs = from onj in onjProfile
                       orderby onj.Name
                       group onj by onj.Age into g
                       select new
                       {
                           GroupKey = g.Key,
                           Profiles = g
                       };
            foreach (var item in onjs)
            {
                Console.WriteLine("item.GroupKey : {0}", item.GroupKey);
                foreach (var profile in item.Profiles)
                {
                    Console.WriteLine(" {0}, {1}", profile.Name, profile.Age);
                }
            }
        }
    }
}
