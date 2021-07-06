using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace StarDB {
    class DBConnection {
        public MySqlConnection dbc = null;
        public string Connection() {
            string connectString = string.Format(@"server = localhost;
                                                   user = root;
                                                   password = ***;
                                                   database = stardb");
            dbc = new MySqlConnection(connectString);
            MySqlConnection connection = new MySqlConnection(connectString);
            try {
                connection.Open();
            }
            catch(Exception ex) {
                return ex.ToString();
            }
            return null;
        }

        public void ConnectionClose() {
            dbc.Close();
        }
        public DataSet Starcraft() {

            MySqlDataAdapter adapter;
            string query = "select * from unit";
            adapter = new MySqlDataAdapter(query, dbc);

            DataSet data = new DataSet();
            adapter.Fill(data, "unit");

            return data;
        }
        public void InsertData() {
            dbc.Open();
            string query = "insert into unit values (null, '테란', '사이클론', 20, 0)";
            MySqlCommand cmd = new MySqlCommand(query, dbc);
            cmd.ExecuteNonQuery();
        }
        public void DeleteData() {
            dbc.Open();
            try{
                string query = "delete from unit where name = '사이클론'";
                MySqlCommand cmd = new MySqlCommand(query, dbc);
                cmd.ExecuteNonQuery();
            } catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
