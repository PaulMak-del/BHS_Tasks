namespace BHS_test.Task2.SubTask1;

/// <summary>
/// Задание 2. Задача 1
/// Поиск высоты дерева
/// </summary>
public class SubTask1
{
    /// <summary>
    /// Из-за структуры входных данных, максимальную глубину дерева
    /// можно узнать по количеству элементов во входном списке
    /// </summary>
    public static int FindTreeHeight(List<int?> root)
    {
        int power = 0;      // Степень двойки
        int numToPower = 1; // 2 в степени i
        int lenght = root.Count;
        while (true)
        {
            if (lenght < numToPower)
            {
                return power;
            }

            power++;
            numToPower *= 2;
        }
    }
}