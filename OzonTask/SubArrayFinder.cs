using System;

namespace OzonTask
{

	//XVII Задача о поиске не отсортированного подмассива ⭐⭐

	//Дана коллекция частично отсортированных целых неотрицательных чисел
	//Нужно реализовать алгоритм поиска не отсортированного подмассива

	//func findUnsortedSubarray(array[]uint) (left uint, right uint)


	public class SubArrayFinder
	{

		public static (int left, int right) FindUnsortedSubArray(int[] array)
		{
			var arrayCopy = new int[array.Length];
			array.CopyTo(arrayCopy, 0);
			Array.Sort(arrayCopy);

			int left = -1;

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != arrayCopy[i])
				{
					left = i;
					break;
				}
			}

			var right = -1;
			for (int i = array.Length - 1; i >= 0; i--)
			{
				if (array[i] != arrayCopy[i])
				{
					right = i;
					break;
				}
			}
			return (left, right);
		}
	}
}