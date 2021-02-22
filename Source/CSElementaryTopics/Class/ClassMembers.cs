using System;

namespace Elementary.Class
{
	namespace Examples
	{
		internal sealed class Qwerty
		{
			/**
			 * Miembros de clase:
			 *		Constantes,
			 *		Campos,
			 *		Metodos,
			 *		Propiedades,			 
			 */

			public const string Constante = "NOT CHANGE";
			private readonly bool isTrue;
			internal void Metodo() { }
			public int NumericProperty { get; set; }
			public static int InstanceCount { get; internal set; }

			/**
			 * 		Eventos, **No se implementara en esta clase**
			 *		Indices, **No se implementara en esta clase**
			 *		Operadores,
			 */
			public static Qwerty operator +(Qwerty qwerty, Qwerty qwerty1)
			{
				// OPERADOR +
				qwerty.NumericProperty += qwerty1.NumericProperty;
				return qwerty;
			}

			/**
			 *		Constructores,
			 *		Destructores,
			 *		Constructores Estaticos,
			 *		Tipos ** Todos los tipos anidados **
			 */

			static Qwerty()
			{
				// CONSTRUCTOR ESTATICO
				System.Console.WriteLine("Usando QWERTY...");
			}

			public Qwerty() : this(true)
			{

				// CONSTRUCTOR BASE
				this.NumericProperty = 0;
				Qwerty.InstanceCount += 1;
				System.Console.WriteLine("#" + Qwerty.InstanceCount);
			}
			private Qwerty(bool flag)
			{

				// CONSTRUCTOR PRIVADO
				this.isTrue = flag;
			}


			~Qwerty()
			{
				// DESTRUCTOR ** Se utilizara Finalize() **
				System.Console.WriteLine("Eliminando instancia...");
			}


		}
	}

	public static partial class Topic
	{

		[Test(Active = false)]
		public static void ClassMembers()
		{
			Examples.Qwerty qwerty = new Examples.Qwerty
			{
				NumericProperty = 5
			};

			Console.WriteLine("# lenght:" + Examples.Qwerty.InstanceCount);

			qwerty = new Examples.Qwerty
			{
				NumericProperty = 10
			};

			Console.WriteLine("# lenght:" + Examples.Qwerty.InstanceCount);

			Examples.Qwerty qwerty1 = new Examples.Qwerty
			{
				NumericProperty = 2
			};

			Examples.Qwerty qwerty2 = qwerty + qwerty1;
			Console.WriteLine("\nSuma de Qwertys:\t" + qwerty2.NumericProperty);
		}


	}


}
