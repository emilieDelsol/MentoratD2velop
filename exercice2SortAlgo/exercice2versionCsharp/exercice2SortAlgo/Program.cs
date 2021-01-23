using System;

namespace exercice2SortAlgo
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("\n\n**********************************" +
                "\nThe INSERTION SORT:" +
                "\n**********************************");
            int[] tableToSortInsertion = new int[] { 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 };
            Console.Write($"first sort: ");
            InsertionSort(tableToSortInsertion);
            Console.Write($"second sort: ");
            InsertionSort(tableToSortInsertion);


            Console.WriteLine("\n**********************************" +
               "\nThe BUBBLE SORT:" +
               "\n**********************************");
            int[] tableToSort = new int[] { 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 };
            Console.Write($"first sort: ");
            BubbleSort(tableToSort);
            Console.Write($"second sort: ");
            BubbleSort(tableToSort);

            Console.WriteLine("\n**********************************" +
                "\nThe COCKTAIL SORT:" +
                "\n**********************************");
            int[] tableToSortCoktail = new int[] { 99, 10, 50, 520, 30, 5, 9, 4, 1, 0 };
            Console.Write($"first sort: ");
            CocktailSort(tableToSortCoktail);
            Console.Write($"second sort: ");
            CocktailSort(tableToSortCoktail);
        }

		private static int[] CocktailSort(int[] integerTable)
		{
                int iteration = 0;
                int comparaison = 0;
            for (int i = 1; i < integerTable.Length; i++)
            {
                int val = integerTable[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    iteration++;
                    if (val < integerTable[j])
                    {
                        comparaison++;
                        integerTable[j + 1] = integerTable[j];
                        j--;
                        integerTable[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }
                }

            }

            Console.WriteLine($"iteration: {iteration} comparaison: {comparaison}");
            return integerTable;
        }

		private static int[] BubbleSort(int[] integerTable)
		{
            int iteration = 0;
            int comparaison = 0;
            for (int j = 0; j <= integerTable.Length - 2; j++)
            {
                iteration++;
                for (int i = 0; i <= integerTable.Length - 2; i++)
                {
                    iteration++;
                    if (integerTable[i] > integerTable[i + 1])
                    {
                        comparaison++;
                        int temp = integerTable[i + 1];
                        integerTable[i + 1] = integerTable[i];
                        integerTable[i] = temp;
                    }

                }
            }
            Console.WriteLine($"iteration: {iteration} comparaison: {comparaison}");

            return integerTable;
        }
	


		private static int[] InsertionSort(int[] table)
		{
            int iteration = 0;
            int comparaison = 0;
            for (int i = 1; i <= table.Length - 1; i++)
            {
                int val = table[i];
                int j = i;
                iteration++;
                while (j>0 && table[j - 1] > val)
                {
                    comparaison++;
                    table[j] = table[j - 1];
                    j = j - 1;
                }
                table[j] = val;
            }
            Console.WriteLine($"iteration: {iteration} comparaison: {comparaison}");
            return table;
        }
	}
}
