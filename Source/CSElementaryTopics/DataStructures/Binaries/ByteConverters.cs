using System;

namespace Elementary.DataStructures.Binaries
{
	public static partial class ByteConverters
	{
		[Test(Active = false)]
		public static void Use()
		{
			/**
			 * BitConverters
			 * 
			 */
			Console.WriteLine("\nConvertidor de tipos primitivos a bytes");

			// Enteros
			int[]  intss = {1,288,30000,444444444,500,6};

			// Convertidor a bytes.			
			Converter<int,byte[]> converter1 = (val)=>
			{
				return BitConverter.GetBytes(val);
			};
			byte[][] bytessb = Array.ConvertAll<int, byte[]>(intss, converter1);

			// Imprimir listas de bytes.		
			foreach ( Array item in bytessb )
			{
				Console.Write($"\t{BitConverter.ToInt32((byte[]) item, 0),-15}:\t");
				foreach ( var item2 in item )
				{
					Console.Write($"{item2,-4}");
				}
				Console.WriteLine();
			}
		}


	}
}
