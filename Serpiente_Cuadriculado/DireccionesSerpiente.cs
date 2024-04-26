/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

*/

using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Serpiente_Cuadriculado
{
    // ESTA ES UNA CLASE PARA QUE LA SERPIENTE PUEDA MOVER EN DISTINTAS DIRECCIONES...

    public class DireccionesSerpiente
    {
        // AQUÍ PRIMERO VAMOS A DECLARAR ALGUNAS VARIABLES...

        // INCLUSIVE, SE AÑADEN ALGUNOS MOVIMIENTOS DE LA SERPIENTE MEDIANTE POSICIONES DE DESPLAZAMIENTO (FILAS Y COLUMNAS)...

        public readonly static DireccionesSerpiente Izquierda = new DireccionesSerpiente(0, -1); // LA SERPIENTE SE DESPLAZARÁ HACIA LA IZQUIERDA.
        public readonly static DireccionesSerpiente Derecha = new DireccionesSerpiente(0, 1); // LA SERPIENTE SE DESPLAZARÁ HACIA LA DERECHA.
        public readonly static DireccionesSerpiente Arriba = new DireccionesSerpiente(-1, 0); // LA SERPIENTE SE DESPLAZARÁ HACIA ARRIBA.
        public readonly static DireccionesSerpiente Abajo = new DireccionesSerpiente(1, 0); // LA SERPIENTE SE DESPLAZARÁ HACIA ABAJO.
        public int DesplazamientoFilas { get; } // LA SERPIENTE PERMITE DESPLAZAR EN FILAS.
        public int DesplazamientoColumnas { get; } // LA SERPIENTE PERMITE DESPLAZAR EN COLUMNAS.

        // EL SIGUIENTE MÉTODO SERÁ PRIVADO YA QUE CADA ATRIBUTO DECLARADO SE VISUALIZARÁ COMO PARÁMETRO, ES DECIR, SE RECONOCERÁ COMO EL CONSTRUCTOR DE ELLA.

        private DireccionesSerpiente(int desplazamientoFila, int desplazamientoColumna)
        {
            DesplazamientoFilas = desplazamientoFila; // LA SERPIENTE PERMITE DESPLAZARSE EN FILAS.
            DesplazamientoColumnas = desplazamientoColumna; // LA SERPIENTE PERMITE DESPLAZARSE EN COLUMNAS.
        }

        // SIN EMBARGO, LA SERPIENTE PERMITE DESPLAZARSE HACIA ATRÁS POR AMBOS EJES DE POSICIÓN...

        public DireccionesSerpiente Retroceso()
        {
            return new DireccionesSerpiente(-DesplazamientoFilas, -DesplazamientoColumnas);
        }

        public override bool Equals(object obj)
        {
            return obj is DireccionesSerpiente serpiente &&
                   DesplazamientoFilas == serpiente.DesplazamientoFilas &&
                   DesplazamientoColumnas == serpiente.DesplazamientoColumnas;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(DesplazamientoFilas, DesplazamientoColumnas);
        }

        public static bool operator ==(DireccionesSerpiente left, DireccionesSerpiente right)
        {
            return EqualityComparer<DireccionesSerpiente>.Default.Equals(left, right);
        }

        public static bool operator !=(DireccionesSerpiente left, DireccionesSerpiente right)
        {
            return !(left == right);
        }
    }
}
