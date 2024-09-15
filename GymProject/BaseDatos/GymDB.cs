using GymProject.Entities;
using System;
using System.Data.SQLite;

namespace GymProject.BaseDatos
{
    public class GymDB
    {
        private static string connectionString = "Data Source=F:\\Projects\\GymProject\\GymProject\\BaseDatos\\gymDB.db;Version=3;";
        public static void BdConnection()
        {
            try
            {

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    NumberId TEXT NOT NULL,
    Name TEXT NOT NULL,
    LastName TEXT NOT NULL,
    Email TEXT,
    PhoneNumber TEXT,
    EntryDate DATETIME NOT NULL
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

        public static void InsertClient(User user)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Users (NumberId, Name, LastName, Email, PhoneNumber, EntryDate) VALUES (@NumberId, @Name, @LastName, @Email, @PhoneNumber, @EntryDate);";


                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@NumberId", user.NumberId);
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@Email", user.phoneNumber);
                        command.Parameters.AddWithValue("@PhoneNumber", user.phoneNumber);
                        command.Parameters.AddWithValue("@EntryDate", user.entryDate);

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
