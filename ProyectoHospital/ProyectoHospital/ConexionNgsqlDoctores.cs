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
    class ConexionNgsqlDoctores
    {
        NpgsqlConnection conn2 = new NpgsqlConnection("Server = drona.db.elephantsql.com;" +
            "User Id = zxyjhevl; Password = IrMW-0ZgFCQruBq-4X6KNC6Qtkr1OUOq; Database = zxyjhevl");

        public DataTable Consultar2()
        {
            string query = "SELECT * FROM \"doctores\"";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn2);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public DataTable Consultar2(string iddoctor)
        {
            string query = "SELECT * FROM \"doctores\" WHERE \"id_doctor\" = '" + iddoctor + "'";
            NpgsqlCommand conector = new NpgsqlCommand(query, conn2);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void Insertar2(int iddoctor, string nomdoctor, string fechanac, string especi, string cargo, string consultorio, string correo, string telefono)
        {
            string query = "INSERT INTO \"doctores\" VALUES ("
                + iddoctor + ", '" + nomdoctor + "', '" + fechanac + "', '" + especi + "','" + cargo + "','" + consultorio +
                "', '" + correo + "', '" + telefono + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn2);
            conn2.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡DOCTOR REGISTRADO CON EXITO!");
            conn2.Close();
        }

        public void Eliminar2(string iddoc)
        {
            string query = "DELETE FROM \"doctores\" WHERE \"id_doctor\" = '" + iddoc + "'";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn2);
            conn2.Open();
            ejecutor.ExecuteNonQuery();

            MessageBox.Show("¡EL DOCTOR HA SIDO ELIMINADO CORRECTAMENTE!");
            conn2.Close();
        }

        public void Actualizar2(string cargo, string consultorio, string n)
        {
            string query = "UPDATE \"doctores\" SET \"cargo\" = '" + cargo + "',\"consultorio\" = '" + consultorio + "'"
                + "WHERE \"id_doctor\" = '" + n + "'";

            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn2);

            conn2.Open();

            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados");

            conn2.Close();
        }
    }
}
