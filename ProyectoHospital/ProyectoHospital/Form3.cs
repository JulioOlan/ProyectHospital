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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ConexionNgsqlInventario conectandose3 = new ConexionNgsqlInventario();

        private void btnConsultar3_Click(object sender, EventArgs e)
        {
            dtgv_Consulta3.DataSource = conectandose3.Consultar3();
            //dtgv_Consulta3.DataSource = conectandose3.Consultar3(txtConsultar_inventario.Text);
        }

        private void btnInsertar3_Click(object sender, EventArgs e)
        {
            // Enviamos por datos de la tabla por parametros.
            conectandose3.Insertar3(
                Convert.ToInt32(txtid_medicamento.Text), txtnombre_medicamento.Text, txtclasificacion.Text, txtexistencia.Text,
                txtunidad_medida.Text, txtestatus.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta3.DataSource = conectandose3.Consultar3();

            // Limpiando los texbox.
            txtid_medicamento.Clear();
            txtnombre_medicamento.Clear();
            txtclasificacion.Clear();
            txtexistencia.Clear();
            txtunidad_medida.Clear();
            txtestatus.Clear();
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            // Enviamos por datos por parametros.
            conectandose3.Eliminar3(txtEliminarIDinventario.Text);

            // Actualiza el DataGridView.
            dtgv_Consulta3.DataSource = conectandose3.Consultar3();

            // Limpiar los textbox.
            txtEliminarIDinventario.Clear();
        }

        private void btnActualizar3_Click(object sender, EventArgs e)
        {
            conectandose3.Actualizar3(Convert.ToInt32(txtexistencia.Text), txtestatus.Text, txtConsultar_inventario.Text);

            //Actualizando el DataGridView.
            dtgv_Consulta3.DataSource = conectandose3.Consultar3();

            //Limpiando los texbox.
            txtexistencia.Clear();
            txtestatus.Clear();
            txtConsultar_inventario.Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
    }
}
