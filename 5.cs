using System;

class Program
{
    static void Main()
    {
        int[,] originalMatrix = new int[,] { { 1, 0, 1 }, { 0, 1, 1 }, { 1, 1, 0 } }; // Пример исходной матрицы

        int rowCount = originalMatrix.GetLength(0); // Получаем количество строк в исходной матрице
        int colCount = originalMatrix.GetLength(1); // Получаем количество столбцов в исходной матрице

        int[,] newMatrix = new int[rowCount, colCount + 1]; // Создаем новую матрицу с дополнительным столбцом

        for (int i = 0; i < rowCount; i++)
        {
            int countOnes = 0; // Инициализируем переменную для подсчета единиц в текущей строке

            for (int j = 0; j < colCount; j++)
            {
                newMatrix[i, j] = originalMatrix[i, j]; // Копируем элементы из исходной матрицы в новую

                if (originalMatrix[i, j] == 1)
                {
                    countOnes++; // Увеличиваем количество единиц в текущей строке
                }
            }

            // Делаем количество единиц четным в новом столбце
            newMatrix[i, colCount] = (countOnes % 2 == 0) ? 0 : 1;
        }

        // Выводим новую матрицу
        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount + 1; j++)
            {
                Console.Write(newMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}