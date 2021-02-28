using System;

namespace Elementary.DataStructures.Binaries
{
	public static partial class Buffers
	{

		[Test(Active = false)]
		public static void Use()
		{
			Console.WriteLine("Using C#/Buffers");

			/**
			 * Buffer is applicable to the following primitive types: Boolean, Char, SByte, 
			 * Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, IntPtr, UIntPtr, 
			 * Single, and Double.
			 * 
			 * 
			 */

			// Primitive Arrays
			char[] myarray = "asdcvbdfg".ToCharArray();



			/**
			 * Copies a specified number of bytes from a source array starting 
			 * at a particular offset to a destination array starting at a 
			 * particular offset.
			 * 
			 */
			Array destino = Array.CreateInstance(typeof (char),15);
			Buffer.BlockCopy(myarray, 0, destino, 0, myarray.Length);

			Console.WriteLine($"\nBlockCopy Count: {destino.Length}");
			foreach ( var item in destino )
			{
				Console.WriteLine($"\t-{item}");
			}


			/**
			 * Returns the number of bytes in the specified array.
			 * 
			 */
			Console.WriteLine($"\nByteLenght: {Buffer.ByteLength(destino)}");


			/**
			 * Set and Get Bytes.
			 *
			 */
			Buffer.SetByte(destino, 0, 65);
			Console.WriteLine($"\nSetByte 45 in Buffer: {(char) Buffer.GetByte(destino, 0)}");




		}

	}
}
