using System;

namespace Elementary.DataStructures.Arrays
{

	public static partial class Topics
	{
		[Test(Active = false)]
		public static void Clone()
		{
			// Array Principal
			string[] mainArray = {
				"Alfa","Beta","Gamma"
			};
			Console.WriteLine("Lista de elementos clonados:");
			for ( int i = 0; i < mainArray.Length; i++ )
			{
				Console.WriteLine($"\t{i}-{mainArray[i]}");
			}

			// Clonando un array
			var clone = (object[])mainArray.Clone();

			mainArray[0] = "xxx"; // Modificacion sin efecto en el clon.

			Console.WriteLine("Lista de elementos clonados:");
			for ( int i = 0; i < clone.Length; i++ )
			{
				Console.WriteLine($"\t{i}-{clone[i]}");
			}

		}


	}


}
