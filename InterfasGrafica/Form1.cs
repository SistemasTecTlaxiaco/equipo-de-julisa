using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfasGrafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAceptar_Click(object sender, EventArgs e)
        {
            string mensaje;
            mensaje = "el pasiente ingreso al hospital se llama" + txtNombre.Text + " " +
            txtApellido.Text + "de" + txtEdad + "años de edad" + "vive en " + cmbCuidad.Text;
            if (chkDolordecabeza.Checked) mensaje += "\n presenta dolor de cabeza";
            if (chkFiebre.Checked) mensaje += "\n presenta fiebre alta";
            if (chkPresion.Checked) mensaje += "\n presenta presion alta";
            if (rbtFemenino.Checked) mensaje += "\n es masculio";
            else mensaje += "\n es femenino";
            if (rbtUrgencia.Checked) mensaje += "\n ingreso por urgencia";
            else mensaje += "\n ingreso por consulta externa";
            MessageBox.Show(mensaje);
        }
    }
}
