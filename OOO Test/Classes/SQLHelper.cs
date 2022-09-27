using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Test
{
    public class SQLHelper
    {
        private static SqlConnection connection;

        public static bool IsConnected()
        {
            connection = new SqlConnection(Helper.ConnectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 17: MessageBox.Show($"Неверное имя сервера\n{ex.Message}", "Ошибка при подключении к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);break;
                    case 4060: MessageBox.Show($"Неверное имя БД\n{ex.Message}", "Ошибка при подключении к БД", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    case 18456: MessageBox.Show($"Неверное имя пользователя или пароль\n{ex.Message}", "Ошибка при подключении к БД", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                        default: MessageBox.Show($"БД вернула сообщение:\n{ex.Message}", "Ошибка при подключении к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);break;
                }
                return false;

            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось подключиться к БД", "Ошибка при подключении к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Успешное подключение к БД", "Подключение к БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        public static string[] ReadOneLine(string table, string selectedColumn, string param, string columns)
        {
            SqlCommand command = new SqlCommand($"SELECT {columns} FROM {table} WHERE {selectedColumn} = @param", connection);
            command.Parameters.AddWithValue("@param", param);
            SqlDataReader reader = command.ExecuteReader();
            string[] data = new string[reader.FieldCount];
            if (reader.HasRows)
            {
                reader.Read();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    data[i] = reader[i].ToString();
                }
            }
            reader.Close();
            return data;
            
        }
    }
}
