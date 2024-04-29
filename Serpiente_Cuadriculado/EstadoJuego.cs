using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpiente_Cuadriculado
{
    public class EstadoJuego
    {
        // CLASE A MODO DE REFERENCIA DEL JUEGO...

        public int Filas { get; } // FILAS.
        public int Columnas { get; } // COLUMNAS.
        public ValorCelda[,] Celdas { get; } // CELDAS DEL TABLERO.
        public DireccionesSerpiente Direccion { get; private set; } // DIRECCIONES DE LA SERPIENTE DENTRO DEL TABLERO DEL JUEGO.
        public int Puntuacion { get; private set; } // PUNTUACIÓN DEL JUEGO.
        public bool FinDelJuego { get; private set; } // FIN DEL JUEGO.
        private readonly LinkedList<Posicion> posicionesSerpiente = new LinkedList<Posicion>(); // POSICIONES DE LA SERPIENTE.
        private readonly Random aleatorio = new Random(); // VALOR ALEATORIO.

        // CONSTRUCTOR DE ESTA CLASE...

        public EstadoJuego(int fila, int columna)
        {
            Filas = fila; // FILAS.
            Columnas = columna; // COLUMNAS.
            Celdas = new ValorCelda[fila, columna]; // CELDAS.
            Direccion = DireccionesSerpiente.Derecha; // DIRECCION PREDETERMINADA
        }
    }
}
