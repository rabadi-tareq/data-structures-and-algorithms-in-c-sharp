using ScratchPad.lib;

namespace ScratchPad;

public static class ReverseArrayInGroups
{

    public static void RunSingle(InformativeList<int> actual, int groupingSize, InformativeList<int> expected)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(ReverseArrayInGroups)} in {groupingSize} groupings");

        Execute(actual,groupingSize);

        if (CompareSequence(actual,expected) == false)
            Console.WriteLine($"✂Failed: {actual} - {expected}");
        else
        {
            Console.WriteLine($"Passed ✔ : {actual} - {expected}");
        }
    }

    public static void RunMultiple(List<(InformativeList<int> items, int k, InformativeList<int> expected)> tuples)
    {
        foreach (var (items, k, expected) in tuples)
        {
            RunSingle(items,k, expected);
        }
    }

    private static void Execute(InformativeList<int> arr, int groupingSize)
    {
        for (int groupStart = 0; groupStart < arr.Count; groupStart += groupingSize)
        {
            var groupEnd = Math.Min(groupStart + groupingSize - 1, arr.Count - 1);

            ReverseRange(arr, groupStart, groupEnd);
        }
    }

    private static void ReverseRange(InformativeList<int> arr, int start, int end)
    {
        while (start < end)
        {
            (arr[start], arr[end]) = (arr[end], arr[start]);
            ++start;
            --end;
        }
    }

    private static bool CompareSequence(InformativeList<int> actual, InformativeList<int> expected)
    {
        if (actual.Count != expected.Count)
            return false;

        for (int i = 0; i < actual.Count; ++i)
        {
            if (actual[i] != expected[i])
            {
                return false;
            }
        }

        return true;
    }
}