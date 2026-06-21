using System;

namespace ScratchPad;

public static class ReverseArray
{

    public static void RunSingle(InputType i)
    {
        var result = Execute(i);

        Console.WriteLine($"Running {nameof(ReverseArray)}");
        Console.WriteLine(result);
    }

    public static void RunMultiple(List<InputType> items)
    {
        Console.WriteLine($"===============Running {nameof(ReverseArray)} for {items.Count()} items");

        foreach (var item in items)
        {
            var result = Execute(item);
            Console.WriteLine($"For item {item} the result is {result}");
        }


        Console.WriteLine($"===============Finished Running {nameof(ReverseArray)}");

    }

    private static ReturnType Execute(InputType i)
    {
        throw new NotImplementedException();
        
    }
}