using System;

namespace Elementary.Class
{

	namespace Examples
	{

		/**
		 * Los espacios de nombres tienen implícitamente public la accesibilidad declarada. 
		 * No se permiten modificadores de acceso en las declaraciones de espacio de nombres.
		 * 
		 * Los tipos declarados en unidades de compilación o espacios de nombres pueden tener 
		 * public o internal.
		 * 
		 */

		public class Tree
		{
			public interface IArbol
			{
				string Acceso { get; }
			}

			public class BB : IArbol
			{
				public string Acceso { get; } = "acceso no limitado.";
				public BB()
				{
					Console.WriteLine(this.GetType().FullName);
					Console.WriteLine(this.GetType().Name + " : " + Acceso);
				}
			}

			private class CC : IArbol
			{
				public string Acceso { get; } = "acceso limitado a la clase contenedora.";
				public CC()
				{
					Console.WriteLine(this.GetType().FullName);
					Console.WriteLine(this.GetType().Name + " : " + Acceso);
				}
			}

			protected class DD : IArbol
			{
				public string Acceso { get; } = "acceso limitado a la clase contenedora o a los tipos derivados de la clase contenedora";
				public DD()
				{
					Console.WriteLine(this.GetType().FullName);
					Console.WriteLine(this.GetType().Name + " : " + Acceso);
				}
			}

			internal class EE : IArbol
			{
				public string Acceso { get; } = "acceso limitado al ensamblado del programa.";
				public EE()
				{
					Console.WriteLine(this.GetType().FullName);
					Console.WriteLine(this.GetType().Name + " : " + Acceso);
				}
			}

			public void PrivateCC()
			{
				CC cC = new CC();
			}

		}

		internal class GreenTree : Tree
		{
			public void ProtectedDD()
			{
				DD dD = new DD();
			}
		}

	}

	public static partial class Topic
	{

		[Test(Active = true)]
		public static void AccessModifiers()
		{
			/**
			 * 1 Clase Tree de acceso publico.
			 * 
			 *		Clases internas:
			 *		2	BB de acceso publico Tree.BB
			 *		3	CC de acceso privado a solo en clase Tree.
			 *		4	DD de acceso protected a solo la clase Tree o Derivados(GreenTree).
			 *		5	EE de acceso internal nivel dominio de programa o ensamblado.
			 */

			// 1
			Examples.Tree arbol = new Examples.Tree();

			// 2
			Examples.Tree.BB bB = new Examples.Tree.BB();

			// 3
			arbol.PrivateCC();

			//4
			Examples.GreenTree arbolVerde = new Examples.GreenTree();
			arbolVerde.ProtectedDD();

			// 5
			Examples.Tree.EE eE = new Examples.Tree.EE();



		}

	}
}
