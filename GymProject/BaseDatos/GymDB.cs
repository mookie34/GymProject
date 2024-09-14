using System;
using System.Data.SQLite;

namespace GymProject.BaseDatos
{
    public class GymDB
    {
        private static string connectionString = "Data Source=F:\\Projects\\GymProject\\GymProject\\BaseDatos\\gymDB.db;Version=3;Password=hola123";
        public static void BdConnection()
        {
            try
            { 

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"CREATE TABLE IF NOT EXISTS Clientes (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nombre TEXT NOT NULL,
                            Apellido TEXT NOT NULL,
                            Edad INTEGER
                          );";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Tabla 'Clientes' creada exitosamente");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear la tabla: " + ex.Message);
            }
        }

        public static void InsertClient(string name, string lastName, int age) {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Clientes (Nombre, Apellido,Edad) VALUES (@Nombre, @Apellido, @Edad);";

                    using (SQLiteCommand command = new SQLiteCommand(sql,connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", name);
                        command.Parameters.AddWithValue("@Apellido", lastName);
                        command.Parameters.AddWithValue("@Edad", age);

                        command.ExecuteNonQuery();
                        Console.WriteLine("cliente insertado exitosamente");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar cliente: " + ex.Message);
                throw;
            }
        }
    }
}
