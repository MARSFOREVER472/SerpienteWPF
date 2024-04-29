using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpiente_Cuadriculado
{
    internal class Posicion
    {
        // AQUÍ SE POSICIONARÁ LA SERPIENTE EN CUALQUIER PARTE DEL TABLERO MEDIANTE ALGUNAS VARIABLES A DECLARAR...

        public int Fila { get; } // POSICIÓN DE LA SERPIENTE EN FILAS.
        public int Columna { get; } // POSICIÓN DE LA SERPIENTE EN COLUMNAS.

        // AQUÍ SE CREA UN CONSTRUCTOR DE LA CLASE (Posicion)...

        public Posicion(int fila, int columna)
        {
            Fila = fila; // FILA DEL TABLERO.
            Columna = columna; // COLUMNA DEL TABLERO.
        }

        // FINALMENTE, LA SERPIENTE SE TRASLADA POR CUALQUIER POSICIÓN DENTRO DEL TABLERO...

        public Posicion Traslado(DireccionesSerpiente direccion) // AQUÍ SIMPLEMENTE DEVUELVE UN VALOR INGRESADO CUANDO SE TRASLADA LAS POSICIONES DE TODA LA SERPIENTE DENTRO DEL TABLERO...
        {
            return new Posicion(Fila + direccion.DesplazamientoFilas, Columna + direccion.DesplazamientoColumnas);
        }

        public override bool Equals(object obj)
        {
            return obj is Posicion posicion &&
                   Fila == posicion.Fila &&
                   Columna == posicion.Columna;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Fila, Columna);
        }

        public static bool operator ==(Posicion left, Posicion right)
        {
            return EqualityComparer<Posicion>.Default.Equals(left, right);
        }

        public static bool operator !=(Posicion left, Posicion right)
        {
            return !(left == right);
        }
    }
}
