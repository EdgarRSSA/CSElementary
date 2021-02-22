using System;

namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{
		[Test(Active = false)]
		public static void CopyMethods()
		{
			Method1();
			Method2();
			Method3();
		}


		/// <summary>
		/// CopyTo
		/// </summary>
		private static void Method3()
		{
			Console.WriteLine("CopyTo and similar copies methods:");

			Console.WriteLine("\t-CopyTo(Array, Int32)");
			Console.WriteLine("\t-CopyTo(Array, Int64)\n");

			byte[] source = new byte[20];

			new Random().NextBytes(source);

			byte[] destination = new byte[40];

			// Copiando:
			int elem = 15;
			source.CopyTo(destination, elem);

			// mostrando listas
			Console.WriteLine($"\t{"i",-5}{"",-3}{"A",-5}{"",-3}{"B",-5}");
			for ( int i = 0; i < destination.Length; i++ )
			{
				char[] xx =new char[2]{
					((i>=0)&&(i<=(source.Length-1)))?'>':' ',
					((i>=elem)&&(i<=(destination.Length-1-(source.Length-elem))))?'c':' ',
				};

				string src = (i<source.Length)?source[i].ToString():"";

				Console.WriteLine($"\t{i,-5}{xx[0],-3}{src,-5}{xx[1],-3}{destination[i],-5}");
			}

			Console.WriteLine();
		}

		/// <summary>
		/// Copy A to B, a # items.
		/// </summary>
		private static void Method2()
		{
			Console.WriteLine("Copy and similar copies methods:");

			Console.WriteLine("\t-Copy(Array, Array, Int32)");
			Console.WriteLine("\t-Copy(Array, Array, Int64)\n");

			byte[] source = new byte[20];

			new Random().NextBytes(source);

			byte[] destination = new byte[20];

			// Copiando:
			Array.Copy(source, destination, 6);

			// mostrando listas
			Console.WriteLine($"\t{"i",-5}{"",-3}{"A",-5}{"",-3}{"B",-5}");
			for ( int i = 0; i < 20; i++ )
			{
				char[] xx =new char[2]{
					((i>=0)&&(i<=(0+6-1)))?'>':' ',
					((i>=0)&&(i<=(0+6-1)))?'c':' ',
				};

				Console.WriteLine($"\t{i,-5}{xx[0],-3}{source[i],-5}{xx[1],-3}{destination[i],-5}");
			}

			Console.WriteLine();

		}

		/// <summary>
		/// Constrained Copy.
		/// </summary>
		private static void Method1()
		{
			Console.WriteLine("Constrained Copy and similar copies methods:");
			Console.WriteLine("\t-ConstrainedCopy(Array, Int32, Array, Int32, Int32)");
			Console.WriteLine("\t-Copy(Array, Int32, Array, Int32, Int32)");
			Console.WriteLine("\t-Copy(Array, Int64, Array, Int64, Int64)\n");

			byte[] source = new byte[20];

			new Random().NextBytes(source);

			byte[] destination = new byte[20];

			// Copiando:
			Array.ConstrainedCopy(source, 3, destination, 9, 5);

			// mostrando listas
			Console.WriteLine($"\t{"i",-5}{"",-3}{"A",-5}{"",-3}{"B",-5}");
			for ( int i = 0; i < 20; i++ )
			{
				char[] xx =new char[2]{
					((i>=3)&&(i<=(3+5-1)))?'>':' ',
					((i>=9)&&(i<=(9+5-1)))?'c':' ',
				};

				Console.WriteLine($"\t{i,-5}{xx[0],-3}{source[i],-5}{xx[1],-3}{destination[i],-5}");
			}

			Console.WriteLine();

		}





	}
}
