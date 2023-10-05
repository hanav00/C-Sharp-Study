using System.Data;

namespace LinqPractice
{
    class Profile
    {
        public string? Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="스프링", Height=161},
                new Profile(){Name="써머", Height=169},
                new Profile(){Name="어텀", Height=175},
                new Profile(){Name="윈터", Height=159},
                new Profile(){Name="시즌", Height=171}
            };

            var heightStat = from profile in arrProfile
                             group profile by profile.Height < 170 into g
                             select new
                             {
                                 Group = g.Key ? "170 이하" : "170 이상",
                                 Count = g.Count(),
                                 Max = g.Max(profile => profile.Height),
                                 Min = g.Min(profile => profile.Height),
                                 Average = g.Average(profile => profile.Height)
                             };
            foreach (var stat in heightStat) {
                Console.WriteLine($"{stat.Group} - Count: {stat.Count}, Max: {stat.Max}, Min: {stat.Min}, Average: {stat.Average}");
            }
            /*
                 170 이하 - Count: 3, Max: 169, Min: 159, Average: 163
                 170 이상 - Count: 2, Max: 175, Min: 171, Average: 173
             */
        }
    }
}
