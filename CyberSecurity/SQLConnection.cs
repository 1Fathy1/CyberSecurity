using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace CyberSecurity
{
    internal class SQLConnection
    {
        private static readonly string CONN_STR = $"Server=db28096.public.databaseasp.net;Database=db28096;Uid=db28096;Pwd=xY_5!o7C6@Fa;SslMode=Preferred;";

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(CONN_STR);
        }

        public DataTable? Select(string query)
        {
            DataTable dT = new DataTable();

            try
            {
                try
                {
                    using (MySqlConnection sC = GetConnection())
                    {
                        using (MySqlDataAdapter dA = new MySqlDataAdapter(query, sC))
                        {
                            dA.Fill(dT);

                        }
                    }
                }
                catch (Exception eX)
                {
                    MessageBox.Show("Data Base Exuctable Error\n" + eX.ToString());
                    return null;
                }
            }
            catch (Exception eX)
            {
                MessageBox.Show("Data Base Connection Error \n" + eX.ToString());
                return null;
            }
            return dT;
        }

        // Insert, Delete, Update 
        public int? Execute(string query)
        { 
            try
            {
                using (MySqlConnection sC = GetConnection())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, sC)) 
                        {
                            sC.Open(); 
                            return cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception eX) 
                    {
                        MessageBox.Show("Data Base Executable Error \n" + eX.ToString());
                        return null;
                    }
                }
            }
            catch (Exception eX)
            {
                {
                    MessageBox.Show("Data Base Connection Error \n" + eX.ToString());
                    return null;
                }
            }
        }
   
    }
}