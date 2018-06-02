using System;
using System.Drawing;
using System.Windows.Forms;

namespace drawTriangle
{
    public partial class Form1 : Form
    {

        
        Triangulo triangulo1 = new Triangulo();
        
        public Form1()
        {
            InitializeComponent();

        }


        private void dibujarTriangulo(object sender, EventArgs e)
        {
            Graphics papel = CreateGraphics();
            Pen lapiz = new Pen(Color.Red);
            

            triangulo1.LongitudA = Convert.ToInt32(lado1.Text);
            triangulo1.LongitudB = Convert.ToInt32(lado2.Text);

            triangulo1.generarLineas();

            papel.DrawLine(lapiz, triangulo1.Linea1.X1, triangulo1.Linea1.Y1,
                triangulo1.Linea1.X2, triangulo1.Linea1.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea2.X1, triangulo1.Linea2.Y1,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea1.X2, triangulo1.Linea1.Y2,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

         

        }

        private void moverTriangulo(object sender, EventArgs e)
        {

            
            triangulo1.moverTriangulo();
            
            
            Graphics papel = this.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);
            papel.Clear(Color.White);


            papel.DrawLine(lapiz, triangulo1.Linea1.X1, triangulo1.Linea1.Y1,
                triangulo1.Linea1.X2, triangulo1.Linea1.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea2.X1, triangulo1.Linea2.Y1,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea1.X2, triangulo1.Linea1.Y2,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

        }

        private void aumentaraTamaño(object sender, EventArgs e)
        {
            triangulo1.aumentar();
            Graphics papel = this.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);
            papel.Clear(Color.White);

            papel.DrawLine(lapiz, triangulo1.Linea1.X1, triangulo1.Linea1.Y1,
                triangulo1.Linea1.X2, triangulo1.Linea1.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea2.X1, triangulo1.Linea2.Y1,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea1.X2, triangulo1.Linea1.Y2,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            triangulo1.disminuir();
            Graphics papel = this.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);
            papel.Clear(Color.White);

            papel.DrawLine(lapiz, triangulo1.Linea1.X1, triangulo1.Linea1.Y1,
                triangulo1.Linea1.X2, triangulo1.Linea1.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea2.X1, triangulo1.Linea2.Y1,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);

            papel.DrawLine(lapiz, triangulo1.Linea1.X2, triangulo1.Linea1.Y2,
                triangulo1.Linea2.X2, triangulo1.Linea2.Y2);
        }
    }


}
