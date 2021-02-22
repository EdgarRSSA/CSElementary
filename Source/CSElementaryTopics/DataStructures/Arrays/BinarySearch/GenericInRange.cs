using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary.DataStructures.Arrays.BinarySearch
{

	namespace Examples
	{
		public class SearchInRange<T>
		{
			private int _min;
			private int _until;

			public SearchInRange(int min, int until)
			{
				_min = min;
				_until = until;
			}

			public static SearchInRange<T> Range(int min, int until)
			{
				return new SearchInRange<T>(min, until);
			}

			public void Search(ref T[] array, T target)
			{
				Array.Sort<T>(array);
				for ( int i = 0; i < array.Length; i++ )
				{
					Console.WriteLine($"\t{i}-{array[i]}");
				}
				int loc = Array.BinarySearch<T>(array, _min, _until, target);
				Console.WriteLine($"Item {target} into range {_min} until {_until} in : {( loc < 0 ? "Not Found" : loc.ToString() )}");
			}

		}


	}


	public static partial class Topic
	{

		[Test(Active = false)]
		public static void GenericInRange()
		{

			byte[] bytesArray = { 1, 2, 3, 4, 6, 35, 7, 9, 8, 9, 2, 8, 4, 5, 6 };
			Examples.SearchInRange<byte>.Range(0, 7).Search(ref bytesArray, 5);

		}

	}
}
