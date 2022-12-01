using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Day1
{
    private List<int> DeerCalories;

    public Day1()
    {
        DeerCalories = new List<int>();
        DeerCalories.Add(0);
    }

    public void Solve()
    {
        var input = File.ReadAllLines(".\\Inputs\\day1.txt");
        foreach (var calories in input)
        {
            if (int.TryParse(calories, out int c))
            {
                DeerCalories[DeerCalories.Count - 1] += c;
            }
            else
            {
                DeerCalories.Add(0);
            }
        }

        DeerCalories.Sort((int a, int b) => b.CompareTo(a));
        Console.WriteLine(DeerCalories[0]);
        Console.WriteLine(DeerCalories[0] + DeerCalories[1] + DeerCalories[2]);
    }
}