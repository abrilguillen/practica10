using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaBinaria
{
    public partial class Form1 : Form
    {
        Vector miVector;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLlenar_Click(object sender, EventArgs e)
        {
            int tamanio = int.Parse(txtTamanioVector.Text);
            miVector = new Vector(tamanio);
            miVector.llenar(tamanio);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = miVector.mostrar();
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            miVector.ordenar();
        }

        private void cmdBusquedaBinaria_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtTamanioVector.Text);
            MessageBox.Show("Está en la posición: " + miVector.busquedaBinaria(numero).ToString() + "," + "total de comparaciones: " + miVector.comp);
        }
    }
}
