using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SeaBattle
{
    class RecordDB
    {
        MySqlConnection conn = new MySqlConnection(
            "server=localhost;user=root;database=record_db;");

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("\tРекорды\n");

            using (conn)
            {
                conn.Open(); int i = 1;

                string sql = "SELECT name, time FROM r_list";
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(i + $") {reader[0].ToString()} ({reader[1].ToString()})");
                    i++;
                }
                Console.ReadKey();
            }
        }

        public void UpdList(string time)
        {//Доработать
            Console.WriteLine("Введи имя: ");
            string name = Console.ReadLine();

            using (conn)
            {
                conn.Open();

                string sql = $"INSERT INTO r_list (name, time) VALUES ({name}, {time});";
                MySqlCommand command = new MySqlCommand(sql, conn);
            }
        }
    }
}
