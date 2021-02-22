using System;
using System.Reflection;

namespace Elementary
{
	internal partial class Program
	{
		/// <summary>
		/// Console Start.
		/// </summary>
		/// <param name="args">Console arguments.</param>
		private static void Main(string[] args)
		{
			Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name);
			Execute();
		}

		/// <summary>
		/// Ejecucion de todos los metodos estaticos marcados como TestAttribute.
		/// </summary>
		private static void Execute()
		{
			Module module = Assembly.GetExecutingAssembly().GetModules()[0];
			Type[] types = module.GetTypes();
			foreach ( var type in types )
			{
				if ( type.IsClass )
				{
					MethodInfo[] methodsInfo = type.GetMethods();
					foreach ( var method in methodsInfo )
					{
						if ( method.IsStatic )
						{
							string nameClass = type.FullName;
							string nameMethod = method.Name;							
							bool isTesteable = method.GetCustomAttribute<TestAttribute>()!=null;
							if ( isTesteable && method.GetCustomAttribute<TestAttribute>().Active )
							{
								Console.WriteLine($"\n\t{"RUN".PadRight(5)}{nameClass}.{nameMethod}:\n");
								method.Invoke(null, null);
							}
							else
							{
								//Console.WriteLine($"{"-".PadRight(5)}{nameClass}.{nameMethod}");
							}
						}
					}
				}
			}

		}
		
	}
}

