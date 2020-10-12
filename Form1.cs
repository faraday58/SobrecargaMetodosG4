using System;
using System.Windows.Forms;

namespace SobrecargaMetodosG4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Funciones miFuncion = new Funciones();
            float a = float.Parse(txtbOperan1.Text);
            float b = float.Parse(txtbOperan2.Text);
            lbResultado1.Text = miFuncion.sumar(a, b).ToString();

        }
    }
}
