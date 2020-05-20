using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ConexionNpgsql conectandose = new ConexionNpgsql();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgv_Consulta.DataSource = conectandose.Consultar();
            //dtgv_Consulta.DataSource = conectandose.Consultar(txtConsultar_paciente.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Enviamos por datos de la tabla por parametros.
            conectandose.Insertar(
                Convert.ToInt32(txtid_paciente.Text), txtnombre_paciente.Text, txtapellidos_paciente.Text, txtcurp.Text, Convert.ToInt32(txtedad.Text),
                txtsexo.Text, txttelefono.Text, txtfecha_nacimiento.Text, txtestatus.Text,
                txtlugar_nacimiento.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta.DataSource = conectandose.Consultar();

            // Limpiando los texbox.
            txtid_paciente.Clear();
            txtnombre_paciente.Clear();
            txtapellidos_paciente.Clear();
            txtcurp.Clear();
            txtedad.Clear();
            txtsexo.Clear();
            txttelefono.Clear();
            txtfecha_nacimiento.Clear();
            txtestatus.Clear();
            txtlugar_nacimiento.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Enviamos por datos por parametros.
            conectandose.Eliminar(txtEliminarID.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta.DataSource = conectandose.Consultar();

            // Limpiar los textbox.
            txtEliminarID.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            conectandose.Actualizar(
                txttelefono.Text, txtestatus.Text, txtConsultar_paciente.Text);

            //Actualizando el DataGridView.
            dtgv_Consulta.DataSource = conectandose.Consultar();

            //Limpiando los texbox.
            txttelefono.Clear();
            txtestatus.Clear();
            txtConsultar_paciente.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tablaDoctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form doctores = new Form2();
            doctores.Show();
        }

        private void tablaInventariomedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form inventario = new Form3();
            inventario.Show();
        }

        private void tablaCitaspacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form citas = new Form4();
            citas.Show();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
