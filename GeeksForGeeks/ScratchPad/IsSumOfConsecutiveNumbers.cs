using System;
using System.Numerics;

namespace ScratchPad;

public static class IsSumOfConsecutiveNumbers
{

    public static void RunSingle(int i)
    {
        var result = Execute(i);

        Console.WriteLine($"Running {nameof(IsSumOfConsecutiveNumbers)}");
        Console.WriteLine(result);
    }

    public static void RunMultiple(int[] items)
    {
        Console.WriteLine($"===============Running {nameof(IsSumOfConsecutiveNumbers)} for {items.Count()} items");

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