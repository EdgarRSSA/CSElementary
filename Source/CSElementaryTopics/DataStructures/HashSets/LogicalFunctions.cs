using System;
using System.Collections.Generic;
using System.Linq;


namespace Elementary.DataStructures.HashSets
{
	public static partial class LogicalFunctions
	{
		[Test(Active = false)]
		public static void Use()
		{

			/**
			 * The HashSet<T> class provides high-performance set operations. A set is 
			 * a collection that contains no duplicate elements, and whose elements 
			 * are in no particular order.
			 * 
			 * 
			 */
			HashSet<string> set1 = new HashSet<string>();
			set1.Add("aaaa");
			set1.Add("bbbb");
			set1.Add("bbbb");
			set1.Add("cccc");
			set1.Add("dddd");
			set1.Add("eeee");


			HashSet<string> set2 = new HashSet<string>();
			set2.Add("axx");
			set2.Add("bvd");
			set2.Add("bb");
			set2.Add("cccc");
			set2.Add("d");
			set2.Add("eeee");
			
			// UNION OR
			Console.WriteLine("\nUNION A or B");
			Print<string>(ref set1);
			Print<string>(ref set2);			
			set1.UnionWith(set2);
			Print<string>(ref set1);

			HashSet<string> set3 = new HashSet<string>();
			set3.Add("ff");
			set3.Add("bbbb");
			set3.Add("qwrt");
			set3.Add("uiopp");
			set3.Add("h");
			set3.Add("eeee");			


			// Intersection AND
			Console.WriteLine("\nINTERSECTION A and B");
			Print<string>(ref set3);
			Print<string>(ref set2);
			set3.IntersectWith(set2);
			Print<string>(ref set3);

			HashSet<string> set4 = new HashSet<string>();
			set4.Add("gkyt");
			set4.Add("bbbb");
			set4.Add("cccc");
			set4.Add("qyuio");
			set4.Add("udfh");
			set4.Add("hjyu");
			set4.Add("eeee");

			// Substraccion 
			Console.WriteLine("\nSUBSTRACTION A-B");
			Print<string>(ref set4);
			Print<string>(ref set2);
			set4.ExceptWith(set2);
			Print<string>(ref set4);


			HashSet<string> set5 = new HashSet<string>();
			set5.Add("qtfs");
			set5.Add("bbbb");
			set5.Add("geth");
			set5.Add("cccc");
			set5.Add("jtty");
			set5.Add("kuio");
			set5.Add("eeee");

			// XOR
			Console.WriteLine("\nSIMETRIC SUBSTRACTION (A or B) - (A and B) ");
			Print<string>(ref set5);
			Print<string>(ref set2);
			set5.SymmetricExceptWith(set2);
			Print<string>(ref set5);

		}

		[Test(Active = false)]
		public static void Use2()
		{
			HashSet<string> set1 = new HashSet<string>();
			set1.Add("aa");
			set1.Add("bb");
			set1.Add("cc");
			set1.Add("dd");
			set1.Add("hh");
			set1.Add("ee");


			HashSet<string> set2 = new HashSet<string>();
			set2.Add("aa");
			set2.Add("bb");
			set2.Add("cc");			

			// SUBSET
			Console.WriteLine("\nUNION A or B");
			Print<string>(ref set1);
			Print<string>(ref set2);
			bool isSub = set2.IsSubsetOf(set1);
			Console.WriteLine($"A is subset of B : {isSub}");


			// SUBSET PORPER
			set2.Clear();
			set2.Add("aa");
			set2.Add("bb");
			set2.Add("cc");
			set2.Add("dd");
			set2.Add("hh");
			//set2.Add("ee");
			Console.WriteLine("\nUNION A or B");
			Print<string>(ref set1);
			Print<string>(ref set2);			
			bool isSubProp = set2.IsProperSubsetOf(set1);
			Console.WriteLine($"A is proper subset of B : {isSubProp}");


		}


		private static void Print<T>(ref HashSet<T> set)
		{
			Console.Write($"Items: {set.Count}\t");
			foreach ( var item in set )
			{
				Console.Write($"{item,-7}");
			}
			Console.WriteLine();
		}

	}
	
}
