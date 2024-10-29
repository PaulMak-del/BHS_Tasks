using BHS_test.Task2.SubTask1;
using BHS_test.Task2.SubTask2;

namespace BHS_test;

class Program
{
    static void Main(string[] args)
    {
        /*
         
        // Taks1
        Task1Solution.Execute();
        
        
        // Task 2.1
        List<int?> list = [3, 9, 20, null, null, 15, 7];
        int result = SubTask1.FindTreeHeight(list);
        
        Console.WriteLine("Result: " + result + "; Expected: 3");
        Console.WriteLine("Test successful?: " + (result == 3));
        
        */
        
        // Task 2.2
        int[,] input =
        {
            {1, 1, 0, 0, 0},
            {1, 1, 0, 0, 0},
            {0, 0, 1, 0, 0},
            {0, 0, 0, 1, 1}
        };
        
        var result = SubTask2.Execute(input);
        
        Console.WriteLine("Result: " + result + "; Expected: 3");
        Console.WriteLine("Test successful?: " + (result == 3));
    }

}