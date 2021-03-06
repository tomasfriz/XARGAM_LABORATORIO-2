using System;
using System.Collections.Generic;

namespace Entidades.Clase07
{
	public class PaletaColeccion
	{
		#region Atributos

		private List<Tempera> _colores;
		private int _cantMaximaElementos;

		#endregion

		#region Indexador

		public Tempera this[int indice]
		{
			set
			{
				if (indice >= 0 && indice < this._cantMaximaElementos)
				{
					this._colores[indice] = value;
				}
			}
			get
			{
				Tempera tempera = null;
				if (indice >= 0 && indice < this._cantMaximaElementos)
				{
					tempera = this._colores[indice];
				}
				return tempera;
			}

		}

		#endregion

		#region Constructor

		private PaletaColeccion() : this(5)
		{
		}

		private PaletaColeccion(int cantMaximaElementos)
		{
			this._cantMaximaElementos = cantMaximaElementos;
			this._colores = new List<Tempera>();
		}

		#endregion

		#region Sobrecargas

		#region Conversion

		public static implicit operator PaletaColeccion(int colores)
		{
			return new PaletaColeccion(colores);
		}

		public static explicit operator string(PaletaColeccion PaletaColeccion)
		{
			return PaletaColeccion.Mostrar();
		}

		#endregion

		#region Comparacion

		public static bool operator ==(PaletaColeccion PaletaColeccion, Tempera tempera)
		{
			bool verify = false;

			for (int i = 0; i < PaletaColeccion._colores.Count; i++)
			{
				if (!Object.Equals(PaletaColeccion._colores[i], null))
				{
					if (PaletaColeccion._colores[i] == tempera)
					{
						verify = true;
						break;
					}
				}

			}
			return verify;
		}

		public static bool operator !=(PaletaColeccion PaletaColeccion, Tempera tempera)
		{
			return !(PaletaColeccion == tempera);
		}

		#endregion

		#region SumaResta

		public static PaletaColeccion operator -(PaletaColeccion PaletaColeccion, Tempera tempera)
		{
			int index = PaletaColeccion.ObtenerIndice(tempera);
			sbyte resta;

			if (index > -1)
			{
				resta = (sbyte)((sbyte)(tempera)*(sbyte)-1);
				if ( (sbyte)(PaletaColeccion._colores[index] + resta) >= 0)
				{
					PaletaColeccion._colores[index] += resta;
				}
				else
				{
					PaletaColeccion._colores.RemoveAt(index);
				}
			}
			return PaletaColeccion;
		}


		public static PaletaColeccion operator +(PaletaColeccion PaletaColeccion, Tempera tempera)
		{
			int index;

			if (PaletaColeccion._colores.Count < PaletaColeccion._cantMaximaElementos)
			{
				if (PaletaColeccion == tempera)
				{
					index = PaletaColeccion.ObtenerIndice(tempera);
					PaletaColeccion._colores[index] += tempera;
				}
				else
				{
					PaletaColeccion._colores.Add(tempera);
				}
			}
			return PaletaColeccion;
		}

		#endregion

		#endregion

		#region Metodos

		private string Mostrar()
		{
			string datos = "Cantidad de elementos: " + this._cantMaximaElementos.ToString() + "\r\n";
			for (int i = 0; i < this._colores.Count; i++)
			{
				if (!Object.Equals(this._colores[i], null))
				{
					datos += this._colores[i] + "\r\n";
				}
			}
			return datos;
		}

		private int ObtenerIndice(Tempera tempera)
		{
			int index = -1;
			for (int i = 0; i < this._colores.Count; i++)
			{
				if (!Object.Equals(this._colores[i], null) && this._colores[i] == tempera)
				{
					index = i;
					break;
				}
			}
			return index;
		}
	}

	#endregion
}



