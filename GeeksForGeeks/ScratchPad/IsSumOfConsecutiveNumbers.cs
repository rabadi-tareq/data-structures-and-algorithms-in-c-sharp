using System;
using System.Numerics;

namespace ScratchPad;

public static class IsSumOfConsecutiveNumbers
{

    public static void RunSingle(int i)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running  {nameof(IsSumOfConsecutiveNumbers)}");

        var result = Execute(i);

        Console.WriteLine(result);
    }

    public static void RunMultiple(int[] items)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"===============Running tareq {nameof(IsSumOfConsecutiveNumbers)} for {items.Count()} items");

        foreach (var item in items)
        {
            var result = Execute(item);
            Console.WriteLine($"For item {item} the result is {result}");
        }


        Console.WriteLine($"===============Finished Running {nameof(IsSumOfConsecutiveNumbers)}");

    }

    private static bool Execute(int i)
    {
        if (i == 1)
            return false;

        if (BitOperations.IsPow2(i))
            return false;

        return true;
    }

}