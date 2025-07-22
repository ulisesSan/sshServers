using sshServer.SQL.model;
using sshServer.utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sshServer.SQL.connector
{
    public class Connector
    {

        private static string cadena = ConfigurationManager.
            ConnectionStrings["cadena"].ConnectionString;

        private static Connector _instancia = null;

        public static Connector instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Connector();
                }
                return _instancia;
            }
        }

        public Connector(){ }
        public static bool saveServerData(Servers server)
        {
            bool response = true;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();

                    string query = "insert into servers (serverName,ipServer,serverPassword)" +
                        "values (@serverName,@ipServer,@serverPassword)";

                    SQLiteCommand command = new SQLiteCommand(query, conexion);
                    command.Parameters.Add(new SQLiteParameter("@serverName", server.serverName));
                    command.Parameters.Add(new SQLiteParameter("@ipServer", server.ipServer));
                    command.Parameters.Add(new SQLiteParameter("@serverPassword", server.serverPassword));

                    command.CommandType = System.Data.CommandType.Text;

                    if (command.ExecuteNonQuery() < 1)
                        response = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show(Constants.insertError + ex.Message);
            }
            return response;
        }

        public static List<Servers> getServers()
        {
            List<Servers> servers = new List<Servers>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select idServer, serverName, ipServer, serverPassword, lastConnection from servers";

                    SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conexion);
                    sQLiteCommand.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader reader = sQLiteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            servers.Add(new Servers()
                            {
                                idServer = int.Parse(reader["idServer"].ToString()),
                                serverName = reader["serverName"].ToString(),
                                ipServer = reader["ipServer"].ToString(),
                                serverPassword = reader["serverPassword"].ToString(),
                                lastConnection = reader["lastConnection"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show(Constants.selectError);
            }

            return servers;
        }

        public static List<Servers> getServer(String id)
        {
            List<Servers> servers = new List<Servers>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select idServer, serverName, ipServer, serverPassword, lastConnection from servers where idServer = "+id+"";

                    SQLiteCommand sQLiteCommand = new SQLiteCommand(query, conexion);
                    sQLiteCommand.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader reader = sQLiteCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            servers.Add(new Servers()
                            {
                                idServer = int.Parse(reader["idServer"].ToString()),
                                serverName = reader["serverName"].ToString(),
                                ipServer = reader["ipServer"].ToString(),
                                serverPassword = reader["serverPassword"].ToString(),
                                lastConnection = reader["lastConnection"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show(Constants.selectError);
            }

            return servers;
        }
    }
}

