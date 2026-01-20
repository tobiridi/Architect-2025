using System.IO.Pipes;

namespace DemoLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataContext ctx = new DataContext();

            //IEnumerable<IGrouping<int, Student>> groupes = ctx.Students.GroupBy(s => s.Section_ID);

            //foreach (IGrouping<int, Student> groupe in groupes)
            //{
            //    Console.WriteLine(groupe.Key);
            //    foreach (Student student in groupe)
            //    {
            //        Console.Write("    ");
            //        Console.WriteLine($"{student.First_Name} {student.Last_Name}");
            //    }

            //}

            //IEnumerable<Dictionary<int, double>> result = ctx.Students.Where(s => s.BirthDate.Year >= 1950)
            //    .GroupBy(s => s.Section_ID)
            //    .Where(g => g.Average(s => s.Year_Result) > 10)
            //    .Select(s => new Dictionary<int, double> {
            //        { s.Key, s.Average(std => std.Year_Result) } 
            //    });

            //foreach (Dictionary<int, double> item in result)
            //{
            //    Console.WriteLine(item.Keys.ToList());
            //    Console.WriteLine(item.Values.ToList());
            //}

            //dynamic result = ctx.Students.Join(ctx.Sections,
            //    st => st.Section_ID,
            //    se => se.Section_ID,
            //    (st, se) => new { lastName = st.Last_Name, sectionName = se.Section_Name });

            //Console.WriteLine(result);

            // Exos 4.1
            //var result = ctx.Students.GroupBy(s => s.Section_ID)
            //        .Select(g => new { sectionId = g.Key, Average = g.Max(s => s.Year_Result) });

            // Exos 4.2
            //var result = ctx.Students.Where(s => s.Section_ID.ToString().StartsWith("10"))
            //    .GroupBy(s => s.Section_ID)
            //    .Select(s => new { Average = s.Average(st => st.Year_Result) });

            //Array.ForEach(result.ToArray(), Console.WriteLine);

            // Exos 4.3
            //var result = ctx.Students
            //    .Where(s => s.BirthDate.Year >= 1970 && s.BirthDate.Year <= 1985)
            //    .GroupBy(s => s.BirthDate.Month)
            //    .Select(s => new { Avergage = s.Average(st => st.Year_Result), month = s.Key });

            //Array.ForEach(result.ToArray(), Console.WriteLine);

            // Exos 4.4
            //var result = ctx.Students
            //    .GroupBy(s => s.Section_ID)
            //    .Where(g => g.Count() > 3)
            //    .Select(s => new { Avergage = s.Average(st => st.Year_Result)});

            //Array.ForEach(result.ToArray(), Console.WriteLine);

            // Exos 4.5

        }
    }
}
