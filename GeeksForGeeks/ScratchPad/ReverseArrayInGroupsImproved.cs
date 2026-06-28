using ScratchPad.lib;

namespace ScratchPad;

public static class ReverseArrayInGroupsImproved
{
    public static void RunSingle(InformativeList<int> arr, int groupingSize)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(ReverseArrayInGroupsImproved)} in {groupingSize} groupings");

        Execute(arr, groupingSize);

        Console.WriteLine(arr);
    }

    public static void RunMultiple(List<(InformativeList<int> items, int k)> tuples)
    {
        foreach (var (items, k) in tuples)
        {
            RunSingle(items, k);
        }
    }

    public static void RunTests(List<(InformativeList<int> input, int groupingSize, InformativeList<int> expected)> testCases)
    {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Running {nameof(ReverseArrayInGroupsImproved)} Tests");
        Console.WriteLine(new string('=', 60));

        int passedTests = 0;
        int totalTests = testCases.Count;

        for (int i = 0; i < testCases.Count; i++)
        {
            var (input, groupingSize, expected) = testCases[i];

            // Create a copy to preserve the original for display
            var inputCopy = new InformativeList<int>();
            inputCopy.AddRange(input);

            Execute(inputCopy, groupingSize);

            bool passed = SequenceEqual(inputCopy, expected);
            passedTests += passed ? 1 : 0;

            Console.WriteLine($"\nTest {i + 1}:");
            Console.WriteLine($"  Input:    {input}");
            Console.WriteLine($"  Grouping: {groupingSize}");
            Console.WriteLine($"  Expected: {expected}");
            Console.WriteLine($"  Actual:   {inputCopy}");
            Console.WriteLine($"  Result:   {(passed ? "✓ PASSED" : "✗ FAILED")}");
        }

        Console.WriteLine(new string('=', 60));
        Console.WriteLine($"Test Results: {passedTests}/{totalTests} passed😜");

        if (passedTests == totalTests)
            Console.WriteLine("All tests passed! ✓");
        else
            Console.WriteLine($"{totalTests - passedTests} test(s) failed! ✗");
    }

    private static bool SequenceEqual(InformativeList<int> list1, InformativeList<int> list2)
    {
        if (list1.Count != list2.Count)
            return false;

        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] != list2[i])
                return false;
        }

        return true;
    }

    private static void Execute(InformativeList<int> arr, int groupingSize)
    {
        // Process each group of elements
        for (int groupStart = 0; groupStart < arr.Count; groupStart += groupingSize)
        {
            // Calculate the end of the current group (handle last group being smaller)
            int groupEnd = Math.Min(groupStart + groupingSize - 1, arr.Count - 1);

            // Reverse the current group
            ReverseRange(arr, groupStart, groupEnd);
        }
    }

    private static void ReverseRange(InformativeList<int> arr, int start, int end)
    {
        // Swap elements from both ends moving towards the center
        while (start < end)
        {
            (arr[start], arr[end]) = (arr[end], arr[start]); // Modern C# tuple swap
            start++;
            end--;
        }
    }
}
