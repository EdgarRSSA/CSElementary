namespace Elementary.DataStructures.Arrays
{
	public static partial class Topics
	{

		[Test(Active = false)]
		public static void ReadOnly()
		{
			System.Console.WriteLine("Arrays de solo lectura.");

			// ARRAY PRINCIPAL
			byte[] arr = new byte[100];

			// MODIFICACIONES INICIALES
			arr[7] = 87;

			// READ ONLY ARRAY
			var arrForRead = System.Array.AsReadOnly<byte>(arr);

			// MODIFICACIONES DEL ARRAY PRINCIPAL
			arr[45] = 127;
			arr[97] = 200;

			System.Console.WriteLine("Verificar modificaciones en solo lectura:");
			System.Console.WriteLine("Contiene el valor 127:" + arrForRead.Contains(127));
			System.Console.WriteLine("Contiene el valor 87:" + arrForRead.Contains(87));
			System.Console.WriteLine("Contiene el valor 200:" + arrForRead.Contains(200));
		}

	}
}
