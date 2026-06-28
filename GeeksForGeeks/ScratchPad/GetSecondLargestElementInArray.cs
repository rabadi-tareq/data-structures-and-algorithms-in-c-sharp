using ScratchPad.lib;
using System;

namespace ScratchPad;

public static class GetSecondLargestElementInArray
{

    public static void RunSingle(InformativeList<int> i)
    {
        var result = Execute(i);

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(GetSecondLargestElementInArray)}");
        Console.WriteLine(result);
    }

    public static void RunMultiple(List<InformativeList<int>> items)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"===============Running {nameof(GetSecondLargestElementInArray)} for {items.Count()} items");

        foreach (var item in items)
        {
            var result = Execute(item);
            Console.WriteLine($"For item {item.ToString()} the result is {result}");
        }


        Console.WriteLine($"===============Finished Running {nameof(GetSecondLargestElementInArray)}");

    }

    private static int Execute(InformativeList<int> arr)
    {
        int largestNumber = -1, secondLargestNumber = -1;

        for (int i = 0; i < arr.Count; ++i)
        {
            var currentNumber = arr[i];

            if (currentNumber > largestNumber)
            {
                secondLargestNumber = largestNumber;
                largestNumber = currentNumber;
            }

            if (currentNumber >= secondLargestNumber && currentNumber != largestNumber)
                secondLargestNumber = currentNumber;
        }


        return secondLargestNumber;
    }

}