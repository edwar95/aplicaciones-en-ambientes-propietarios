using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawTriangle
{
    public partial class Form1 : Form
    {


        TrianguloMovible triangulo1 = new TrianguloMovible();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel = this.CreateGraphics();
            Triangulo triangulo1 = new Triangulo();
            Pen lapiz=new Pen(Color.Red);
           

            triangulo1.LongitudA = Convert.ToInt32(lado1.Text);
            triangulo1.LongitudB = Convert.ToInt32(lado2.Text);

            triangulo1.generarLineas();

            papel.DrawLine(lapiz, triangulo1.Linea1.Punto1.X, triangulo1.Linea1.Punto1.Y,
                triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea2.Punto1.X, triangulo1.Linea2.Punto1.Y,
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y, 
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);

            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics papel = this.CreateGraphics();
            
            Pen lapiz = new Pen(Color.Red);


            triangulo1.LongitudA = Convert.ToInt32(lado1.Text);
            triangulo1.LongitudB = Convert.ToInt32(lado2.Text);

            triangulo1.generarLineas();

            papel.DrawLine(lapiz, triangulo1.Linea1.Punto1.X, triangulo1.Linea1.Punto1.Y,
                triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea2.Punto1.X, triangulo1.Linea2.Punto1.Y,
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y,
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);

            button3.Enabled = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triangulo1.moverTriangulo();


            Graphics papel = this.CreateGraphics();

            Pen lapiz = new Pen(Color.Red);

            papel.Clear(Color.LightGray);
            papel.DrawLine(lapiz, triangulo1.Linea1.Punto1.X, triangulo1.Linea1.Punto1.Y,
                triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea2.Punto1.X, triangulo1.Linea2.Punto1.Y,
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);

            papel.DrawLine(lapiz, triangulo1.Linea1.Punto2.X, triangulo1.Linea1.Punto2.Y,
                triangulo1.Linea2.Punto2.X, triangulo1.Linea2.Punto2.Y);
        }
    }


}
