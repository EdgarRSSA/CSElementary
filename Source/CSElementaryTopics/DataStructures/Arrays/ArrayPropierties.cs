namespace Elementary.DataStructures.Arrays
{

	public static partial class Topics
	{
		[Test(Active = false)]
		public static void Propierties()
		{
			System.Console.WriteLine("Propiedades de Un Array:");

			byte[] arr = new byte[100];

			System.Console.WriteLine($"Tipo Base: {arr.GetType().BaseType}");

			#region Propiedades

			System.Reflection.PropertyInfo[] properties = arr.GetType().GetProperties();
			foreach ( System.Reflection.PropertyInfo item in properties )
			{
				string name = item.Name.PadRight(20);
				string type = item.PropertyType.Name.PadRight(20);
				string value = item.GetValue(arr).ToString().PadRight(20);
				System.Console.WriteLine($"{value}{name}{type}");

			}

			#endregion

			// Array para sincronizar
			//System.Console.WriteLine(((System.Byte[])arr.SyncRoot).Length);

		}


	}


}