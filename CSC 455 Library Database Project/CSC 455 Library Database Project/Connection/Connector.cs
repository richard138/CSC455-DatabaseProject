using System;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSC_455_Library_Database_Project.Connection
{
    public class Connector
    {
        public List<MySqlParameter> parameters= new List<MySqlParameter>();
        public DataSet GetDataSet(string queryString)
        {
            //Method Connects to satoshi and executes SELECT statements and returns a DataSet
            //Should maybe refactor this at some point to do the connection to the linux sever in a seperate function 
            try
            {   //Stand up empty dataSet
                DataSet ds = new DataSet();
                //Establish connection to linux server
                using (var client = new SshClient("152.20.12.152", "rac9308", "Washington2@"))
                {
                    client.Connect();
                    if (client.IsConnected)
                    {
                        //Foward port for Mysql sever to localhost
                        var portForwarded = new ForwardedPortLocal("127.0.0.1", 8001, "127.0.0.1", 3306);
                        client.AddForwardedPort(portForwarded);
                        portForwarded.Start();

                        //Build Connection String
                        MySqlConnectionStringBuilder csb = new MySqlConnectionStringBuilder
                        {
                            Server = "127.0.0.1",
                            Port = 8001,
                            UserID = "rac9308",
                            Password = "LOtkBL4Cm",
                            Database = "rac9308"
                        };
                        //connect to Mysql server
                        using (var connection = new MySqlConnection(csb.ConnectionString))
                        {
                            MySqlCommand command = connection.CreateCommand();
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                            dataAdapter.SelectCommand = command;
                            //add sql query parameters
                            foreach (MySqlParameter param in parameters)
                            {
                                dataAdapter.SelectCommand.Parameters.Add(param);
                            }


                            command.CommandText = queryString;
                            command.Connection = connection;

                            connection.Open();
                            //populate dataSet
                            dataAdapter.Fill(ds);
                            connection.Close();

                            return ds;
                        }
                    }
                    else
                    {
                        //If connection could not be established just return empty dataset
                        //Should add logic here later to throw up connection error popup as well
                        return ds;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }       
        }
        public void ClearParameters()
        {
            //reset parameters
            this.parameters = new List<MySqlParameter>();
        }
        public void addParameter(string name, MySqlDbType type, int size, object value)
        {
            MySqlParameter param = new MySqlParameter(name, type, size);
            param.Value = value;
            this.parameters.Add(param);
        }
    }

}
