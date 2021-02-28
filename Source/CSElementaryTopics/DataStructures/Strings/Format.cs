using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary.DataStructures.Strings
{
	public static partial class Format
	{
		[Test(Active = false)]
		public static void Use() {

			Console.WriteLine("\tFormatos de Strings");


			/**
			 * Formato de numeros:
			 *
			 */
			decimal val = 254530.54M;
			Console.WriteLine("Precio: {0,10:$ 000,000 .00 MXN}", val);

			int val2 = 123755;
			byte[] val2tobytes = BitConverter.GetBytes(val2);
			Console.WriteLine("Bytes {0,3:000} {1,3:000} {2,3:000} {3,3:000}",val2tobytes[0], val2tobytes[1], val2tobytes[2], val2tobytes[3]);

		}

	}
}
