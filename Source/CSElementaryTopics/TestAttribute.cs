using System;

namespace Elementary
{
	/// <summary>
	/// Ejecuta los metodos estaticos segun la propiedad Active.
	/// </summary>
	[System.AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	sealed class TestAttribute : Attribute
	{
		/// <summary>
		/// Determina si un Metodo Estatico se ejecutara.
		/// </summary>
		public bool Active { get; set; }
		public TestAttribute()
		{
			Active = false;
			// Este atributo idenfitica y ejecuta un Metodo Statico.
		}
	}
}

