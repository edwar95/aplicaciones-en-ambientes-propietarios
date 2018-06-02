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
        int x1,x2,y1,y2;

        public int Longitud { get => longitud; set => longitud = value; }
        public int X1 { get => x1; set => x1= value; }
        public int Y1 { get => y1; set => y1= value; }
        public int X2 { get => x2; set => x2= value; }
        public int Y2 { get => y2; set => y2= value; }

        

       
        

        public void trazarLineaHorizontal()
        {
           x1 = 0;
           y1 = 0;

           x2 = longitud;
           y2 = 0;

        }

        public void trazarLineaVertical()
        {
           x1 = 0;
            y1 = 0;

           x2 = 0;
           y2 = longitud;
        }


    }
}
