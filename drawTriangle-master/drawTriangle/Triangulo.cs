﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawTriangle
{
    class Triangulo
    {
        int longitudA;
        int longitudB;

        public int LongitudA { get => longitudA; set => longitudA = value; }
        public int LongitudB { get => longitudB; set => longitudB = value; }
        internal Linea Linea1 { get => linea1; set => linea1 = value; }
        internal Linea Linea2 { get => linea2; set => linea2 = value; }

        Linea linea1 = new Linea();
        Linea linea2 = new Linea();

        public void generarLineas()
        {
            
            linea1.Longitud = longitudA;
            linea2.Longitud = longitudB;

            linea1.trazarLineaHorizontal();
            linea2.trazarLineaVertical();

        }

        public void moverTriangulo()
        {
            

            linea1.X1 += 50;
            linea1.Y1 = 0;

            linea1.X2 += 50;
            linea1.Y2 += 0;

            linea2.X1 += 50;
            linea2.Y1 = 0;

            linea2.X2 += 50;

        }

        public void aumentar()
        {
            linea1.Longitud +=20;
            linea2.Longitud +=20;

            linea1.trazarLineaHorizontal();
            linea2.trazarLineaVertical();

        }

        public void disminuir()
        {
            linea1.Longitud -= 20;
            linea2.Longitud -= 20;

            linea1.trazarLineaHorizontal();
            linea2.trazarLineaVertical();

        }


    }
}
