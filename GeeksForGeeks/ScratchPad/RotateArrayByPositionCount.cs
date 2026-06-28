using ScratchPad.lib;

namespace ScratchPad;

public static class RotateArrayByPositionCount
{
    public static void RunSingle(InformativeList<int> arr, int positionCount)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(RotateArrayByPositionCount)}");

        Execute(arr, positionCount);

        Console.WriteLine(arr);
    }

    public static void RunMultiple(List<(InformativeList<int> items, int positionCount)> tuples)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(RotateArrayByPositionCount)}");

        foreach (var tuple in tuples)
        {
            Execute(tuple.items, tuple.positionCount);
        }
    }

    private static void Execute(InformativeList<int> arr, int positionCount)
    {
        for (int i = 0; i < positionCount; ++i)
        {
            

            var firstElement = arr[0];

            for (int x = 1; x < arr.Count-1; ++x)
            {
                //var temp = arr[x];
                //arr[x] = arr[x + 1];
                //arr[x - 1] = temp;

                (arr[x - 1], arr[x]) = (arr[x], arr[x + 1]);
            }

            arr[^1] = firstElement;
        }
    }
}