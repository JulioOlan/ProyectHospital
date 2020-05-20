using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace ProyectoHospital
{
    class ConexionNgsqlInventario
    {
        NpgsqlConnection conn3 = new NpgsqlConnection("Server = drona.db.elephantsql.com;" +
            "User Id = zxyjhevl; Password = IrMW-0ZgFCQruBq-4X6KNC6Qtkr1OUOq; Database = zxyjhevl");

        public DataTable Consultar3()
        {
            string query = "SELECT * FROM \"inventario_medicamentos\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn3);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar3(string idmedicamento)
        {
            string query = "SELECT * FROM \"inventario_medicamentos\" WHERE \"id_medicamento\" = '" + idmedicamento + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn3);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Insertar3(int idmedic, string nommedic, string clasificacion, string existencia, string unidad, string estatus)
        {
            string query = "INSERT INTO \"inventario_medicamentos\" VALUES ("
                + idmedic + ", '" + nommedic + "', '" + clasificacion + "', '" + existencia + "','" + unidad + "','" + estatus + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn3);
            conn3.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡MEDICAMENTO REGISTRADO CON EXITO!");
            conn3.Close();
        }

        public void Eliminar3(string idmedic)
        {
            string query = "DELETE FROM \"inventario_medicamentos\" WHERE \"id_medicamento\" = '" + idmedic + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn3);
            conn3.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡MEDICAMENTO ELIMINADO CORRECTAMENTE!");
            conn3.Close();
        }

        public void Actualizar3(int exist, string estatus, string n)
        {
            string query = "UPDATE \"inventario_medicamentos\" SET \"existencias\" = " + exist + ",\"estatus\" = '" + estatus + "'"
                + "WHERE \"id_medicamento\" = '" + n + "'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn3);

            conn3.Open();

            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados");

            conn3.Close();
        }
    }
}
