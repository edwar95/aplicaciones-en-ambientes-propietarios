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



        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Linea linea1 = new Linea();
            linea1.Longitud = Convert.ToInt32(lado1.Text);

            Linea linea2 = new Linea();
            linea2.Longitud = Convert.ToInt32(lado2.Text);



        }
    }


}
