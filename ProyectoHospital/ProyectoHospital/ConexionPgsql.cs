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
    class ConexionNpgsql
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = drona.db.elephantsql.com;" +
            "User Id = zxyjhevl; Password = IrMW-0ZgFCQruBq-4X6KNC6Qtkr1OUOq; Database = zxyjhevl");

        public void Conectar()
        {
            conn.Open();
            MessageBox.Show("¡Conexion realizada!");
        }

        public void Desconectar()
        {
            conn.Close();
            MessageBox.Show("¡Conexion finalizada!");
        }

        public DataTable Consultar()
        {
            string query = "SELECT * FROM \"pacientes\"";
            NpgsqlCommand conector = new NpgsqlCommand(query,conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            
            return tabla;
        }

        public DataTable Consultar(string idpaciente)
        {
            string query = "SELECT * FROM \"pacientes\" WHERE \"id_paciente\" = '" + idpaciente + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Insertar(int idpaciente, string nompaciente, string apepaciente, string curp, int edad, string sexo, string telefono, string fechanacimiento, string estatus, string lugarnacimiento)
        {
            string query = "INSERT INTO \"pacientes\" VALUES ("
                + idpaciente + ", '" + nompaciente + "', '" + apepaciente + "', '" + curp + "'," + edad + ",'" + sexo +
                "', '" + telefono + "', '" + fechanacimiento + "', '" + estatus + "', '" + lugarnacimiento + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query,conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡PACIENTE INSERTADO CON EXITO!");
            conn.Close();
        }

        public void Eliminar(string id)
        {
            string query = "DELETE FROM \"pacientes\" WHERE \"id_paciente\" = '" + id + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query,conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡EL PACIENTE HA SIDO ELIMINADO CORRECTAMENTE!");
            conn.Close();
        }

        public void Actualizar(string telefono, string estatus, string n)
        {
            string query = "UPDATE \"pacientes\" SET \"estatus\" = '" + estatus + "',\"telefono\" = '" + telefono + "'"
                + "WHERE \"id_paciente\" = '" + n + "'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);

            conn.Open();

            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados");

            conn.Close();
        }
    }
}
