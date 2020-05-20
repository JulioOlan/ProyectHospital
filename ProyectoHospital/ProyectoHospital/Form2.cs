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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ConexionNgsqlDoctores conectandose2 = new ConexionNgsqlDoctores();

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            dtgv_Consulta2.DataSource = conectandose2.Consultar2();
            //dtgv_Consulta2.DataSource = conectandose2.Consultar2(txtConsultar_doctor.Text);
        }

        private void btnInsertar2_Click(object sender, EventArgs e)
        {
            // Enviamos por datos de la tabla por parametros.
            conectandose2.Insertar2(
                Convert.ToInt32(txtid_doctor.Text), txtnombre_doctor.Text, txtfecha_nac.Text, txtespecialidad.Text,
                txtcargo.Text, txtconsultorio.Text, txtcorreo.Text, txttelefono.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta2.DataSource = conectandose2.Consultar2();

            // Limpiando los texbox.
            txtid_doctor.Clear();
            txtnombre_doctor.Clear();
            txtfecha_nac.Clear();
            txtespecialidad.Clear();
            txtcargo.Clear();
            txtconsultorio.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
        }
        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            // Enviamos por datos por parametros.
            conectandose2.Eliminar2(txtEliminarIDdoctor.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta2.DataSource = conectandose2.Consultar2();

            // Limpiar los textbox.
            txtEliminarIDdoctor.Clear();
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            conectandose2.Actualizar2(
                txtcargo.Text, txtconsultorio.Text, txtConsultar_doctor.Text);

            //Actualizando el DataGridView.
            dtgv_Consulta2.DataSource = conectandose2.Consultar2();

            //Limpiando los texbox.
            txtcargo.Clear();
            txtconsultorio.Clear();
            txtConsultar_doctor.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
