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
    class ConexionNgsqlCitas
    {
        NpgsqlConnection conn4 = new NpgsqlConnection("Server = drona.db.elephantsql.com;" +
            "User Id = zxyjhevl; Password = IrMW-0ZgFCQruBq-4X6KNC6Qtkr1OUOq; Database = zxyjhevl");

        public DataTable Consultar4()
        {
            string query = "SELECT * FROM \"citas_pacientes\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn4);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar4(string idcita)
        {
            string query = "SELECT * FROM \"citas_pacientes\" WHERE \"id_cita\" = '" + idcita + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn4);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Insertar4(int idcita, string fechacita, string idpaci, string iddoc, string especialidad)
        {
            string query = "INSERT INTO \"citas_pacientes\" VALUES ("
                + idcita + ", '" + fechacita + "', '" + idpaci + "', '" + iddoc + "','" + especialidad + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn4);
            conn4.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡CITA REGISTRADA CON EXITO!");
            conn4.Close();
        }

        public void Eliminar4(string idcita)
        {
            string query = "DELETE FROM \"citas_pacientes\" WHERE \"id_cita\" = '" + idcita + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn4);
            conn4.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡CITA ELIMINADA CORRECTAMENTE!");
            conn4.Close();
        }

        public void Actualizar4(string fechacita, string n)
        {
            string query = "UPDATE \"citas_pacientes\" SET \"fecha_cita\" = '" + fechacita + "'"
                + "WHERE \"id_cita\" = '" + n + "'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn4);

            conn4.Open();

            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados");

            conn4.Close();
        }
    }
}
