using System;

namespace Elementary.Class
{

	namespace Examples
	{
		#region Modificador New	
		internal interface IDelta
		{
			System.Guid Guid { get; }
			string SID { get; }
		}

		internal class Alfa
		{
			public class Delta : IDelta
			{
				public System.Guid Guid { get; }
				public string SID { get; } = "DELTA";
				public Delta()
				{
					Guid = System.Guid.NewGuid();
					Console.WriteLine("ID<" + this.GetType().FullName + ">:" + Guid);
				}
			}
			public IDelta InterDelta { get; internal set; }
			public Alfa()
			{
				InterDelta = new Delta();
				Console.WriteLine("ID<" + this.GetType().FullName + ">(" + InterDelta.SID + ")" + InterDelta.Guid);
			}
		}

		internal class Beta : Alfa
		{
			private new class Delta : IDelta
			{
				public System.Guid Guid { get; }
				public string SID { get; } = "NEW DELTA";
				public Delta()
				{
					Guid = System.Guid.NewGuid();
					Console.WriteLine("ID<" + this.GetType().FullName + ">:" + Guid);
				}
			}
			public Beta()
			{
				InterDelta = new Delta();
				Console.WriteLine("ID<" + this.GetType().FullName + ">(" + InterDelta.SID + ")" + InterDelta.Guid);
			}

		}

		#endregion
	}


	public static partial class Topic
	{
		[Test(Active = false)]
		public static void NewModifier()
		{

			/**
			 * Clase Alfa con clase interna Alfa.Delta.
			 * 
			 */
			Console.WriteLine("\tEjemplo 1:\n");
			Examples.Alfa alfa = new Examples.Alfa();
			Console.WriteLine("TYPE DELTA : " + alfa.InterDelta.SID);


			/**
			 * Clase Beta, usa en modificador NEW para redefinir la
			 * clase interna Beta.Delta.
			 */
			Console.WriteLine("\n\tEjemplo 3:\n");
			Examples.Beta beta = new Examples.Beta();
			Console.WriteLine("TYPE DELTA : " + beta.InterDelta.SID);


			/**
			 * new Beta.Delta() utiliza Alfa.Delta aun
			 * cuando se definio como NEW CLASS Beta.Delta.
			 */
			Console.WriteLine("\n\tEjemplo 2:\n");
			Examples.Alfa.Delta delta1 = new Examples.Alfa.Delta();
			Console.WriteLine("TYPE DELTA : " + delta1.SID);
			Examples.Beta.Delta delta2 = new Examples.Beta.Delta();
			Console.WriteLine("TYPE DELTA : " + delta2.SID);


		}


	}


}
