using ScratchPad.lib;
using System;

namespace ScratchPad;

public static class ReverseArray
{

    public static void RunSingle(InformativeList<int> i)
    {
        var result = Execute(i);

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(ReverseArray)}");
        Console.WriteLine(result);
    }

    public static void RunMultiple(List<InformativeList<int>> items)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"===============Running {nameof(ReverseArray)} for {items.Count()} items");

        foreach (var item in items)
        {
            var result = Execute(item);
            Console.WriteLine($"For item {item} the result is {result}");
        }


        Console.WriteLine($"===============Finished Running {nameof(ReverseArray)}");

    }

    private static InformativeList<int> Execute(InformativeList<int> items)
    {
        // 1, 4, 3, 2, 6, 5
        for (int i = 0; i < items.Count / 2; i++)
        {
            var temp = items[i];
            items[i] = items[items.Count - 1 - i];
            items[items.Count - 1 - i] = temp;
        }

        return items;
    }
}