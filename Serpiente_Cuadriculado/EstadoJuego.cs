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

            AnadirSerpiente(); // LLAMADO DEL MÉTODO PARA AGREGAR LA SERPIENTE DENTRO DEL TABLERO.
        }

        // CREAREMOS UNA SERPIENTE AQUÍ EN ESTA CLASE...

        private void AnadirSerpiente()
        {
            int f = Filas / 2; // LA VARIABLE "f" SE CALCULA MEDIANTE LA MITAD POR CADA FILA...

            // PARA LAS COLUMNAS UTILIZAREMOS EL CICLO "for"...

            for (int c = 1; c <= 3; c++)
            {
                Celdas[f, c] = ValorCelda.Serpiente; // POR CADA CELDA ESTARÁ TODA LA SERPIENTE.
                posicionesSerpiente.AddFirst(new Posicion(f, c)); // PRIMERO TOMAREMOS EN CUENTA LAS POSICIONES EN QUE SE ENCUENTRA AL AÑADIR LA SERPIENTE POR CELDAS DEL TABLERO.
            }
        }

        // CREAREMOS UN NUEVO MÉTODO PARA QUE EL TABLERO ESTÉ DESPEJADO MEDIANTE POSICIONES VACÍAS...

        private IEnumerable<Posicion> PosicionesVacias()
        {
            // POR CADA FILA Y COLUMNA DEL TABLERO CREAREMOS UN CICLO "for"...

            for (int f = 0; f < Filas; f++) // PARA LAS FILAS...
            {
                for (int c = 0; c < Columnas; c++) // PARA LAS COLUMNAS...
                {
                    if (Celdas[f, c] == ValorCelda.Vacio) // SI LA CELDA ESTÁ VACÍA EN ESA POSICIÓN...
                    {
                        yield return new Posicion(f, c); // ENTONCES, LA POSICIÓN DE LA SERPIENTE POR DEFECTO VENDRÍA AQUÍ.
                    }
                }
            }
        }
    }
}
