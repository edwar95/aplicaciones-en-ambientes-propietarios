using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTriangle
{
    class TrianguloMovible: Triangulo {


        public void moverTriangulo()
        {
            Linea1.Punto1.X += 50;
            Linea1.Punto1.Y = 0;

            Linea1.Punto2.X += 50;
            Linea1.Punto2.Y += 0;

            Linea2.Punto1.X += 50;
            Linea2.Punto1.Y = 0;

            Linea2.Punto2.X += 50;
            
        }

    }
}
