using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLista
{
    class Materia
    {
       public string Clave { get; set; }
        public string Nombre { get; set; }

        public int calificacionPrimerParcial { get; set; }
        public int calificacionSegundoParcial { get; set; }
        public int calificacionTercerParcial { get; set; }
        public int calificacionFinal { get; set; }

        public Materia(string clave, string nombre)
        {
            Clave = clave;
            Nombre = nombre;
            calificacionPrimerParcial = 0;
            calificacionSegundoParcial = 0;
            calificacionTercerParcial = 0;
            calificacionFinal = 0;
        }

        public Materia(string clave, string nombre, int calificacionprimerParcial, int calificacionsegundoparcial, int calificaciontercerparcial, int calificacionfinal)
        {
            Clave = clave;
            Nombre = nombre;
            calificacionprimerParcial = calificacionPrimerParcial;
            calificacionsegundoparcial = calificacionSegundoParcial;
            calificaciontercerparcial = calificacionTercerParcial;
            calificacionfinal = calificacionFinal;
        }
    }
}
