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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        ConexionNgsqlCitas conectandose4 = new ConexionNgsqlCitas();

        private void btnConsultar4_Click(object sender, EventArgs e)
        {
            dtgv_Consulta4.DataSource = conectandose4.Consultar4();
            //dtgv_Consulta4.DataSource = conectandose4.Consultar4(txtConsultar_cita.Text);
        }

        private void btnInsertar4_Click(object sender, EventArgs e)
        {
            // Enviamos por datos de la tabla por parametros.
            conectandose4.Insertar4(
                Convert.ToInt32(txtid_cita.Text), txtfecha_cita.Text, txtid_paciente.Text, txtid_doctor.Text,
                txtespecialidadcita.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta4.DataSource = conectandose4.Consultar4();

            // Limpiando los texbox.
            txtid_cita.Clear();
            txtfecha_cita.Clear();
            txtid_paciente.Clear();
            txtid_doctor.Clear();
            txtespecialidadcita.Clear();
        }

        private void btnEliminar4_Click(object sender, EventArgs e)
        {
            // Enviamos por datos por parametros.
            conectandose4.Eliminar4(txtEliminarIDcita.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta4.DataSource = conectandose4.Consultar4();

            // Limpiar los textbox.
            txtEliminarIDcita.Clear();
        }

        private void btnActualizar4_Click(object sender, EventArgs e)
        {
            conectandose4.Actualizar4(txtfecha_cita.Text, txtConsultar_cita.Text);

            //Actualizando el DataGridView.
            dtgv_Consulta4.DataSource = conectandose4.Consultar4();

            //Limpiando los texbox.
            txtfecha_cita.Clear();
            txtConsultar_cita.Clear();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}
