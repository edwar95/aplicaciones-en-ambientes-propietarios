using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTriangle
{
    class Linea
    {
        int longitud;

        public int Longitud { get => longitud; set => longitud = value; }
        internal Punto Punto1 { get => punto1; set => punto1 = value; }
        internal Punto Punto2 { get => punto2; set => punto2 = value; }

        Punto punto1 = new Punto();
        Punto punto2 = new Punto();

        

        public void trazarLineaHorizontal()
        {
            Punto1.X = 0;
            Punto1.Y = 0;

            Punto2.X = longitud;
            Punto2.Y = 0;

        }

        public void trazarLineaVertical()
        {
            Punto1.X = 0;
            Punto1.Y = 0;

            Punto2.X = 0;
            Punto2.Y = longitud;
        }


    }
}
