using System.Diagnostics;

namespace BHS_test.Task2.SubTask2;

/// <summary>
/// Задание 2. Задача 2
/// Поиск количества островов
/// </summary>
public class SubTask2
{
    public static int Execute(int[,] input)
    {
        int width = input.GetLength(1);
        int height = input.GetLength(0);
        bool[,] check = new bool[height, width];
        int islandAmount = 0;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (input[i,j] == 1 && check[i,j] == false)
                {
                    islandAmount += 1;
                    FillChecks(check, input, i, j);
                }
            }
        }
        
        return islandAmount;
    }

    private static void FillChecks(bool[,] check, int[,] input, int i, int j)
    {
        if (check[i,j] == true) return;
        check[i,j] = true;
        
        if (input[i,j] == 1)
        {
            if (i < check.GetLength(0) - 1)
                FillChecks(check, input, i + 1, j);
            if (i > 0)
                FillChecks(check, input, i - 1, j);
            if (j < check.GetLength(1) - 1)
                FillChecks(check, input, i, j + 1);
            if (j > 0)
                FillChecks(check, input, i, j - 1);
        }
    }
}