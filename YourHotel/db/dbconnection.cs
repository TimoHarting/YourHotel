using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Text;

namespace YourHotel.db
{
    class dbconnection
    {
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Hotel.accdb";
        private static OleDbConnection con = new OleDbConnection(connectionString);


        //Initialisierung
        private static bool OpenConnection()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                return false;
            }
        }

        private static bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                return false;
            }
        }

        public static void Inizialize()
        {
            if (OpenConnection() == true)
            {
                Debug.WriteLine("Datenbankverbindung war erfolgreich");
            }
            CloseConnection();
        }


        public static bool Basics(string query) //Insert, Update, Delete
        {
            bool successful = false;
            try
            {
                if (OpenConnection() == true)
                {
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    successful = true;
                }
                CloseConnection();
            }
            catch
            {
                CloseConnection();
            }
            return successful;
        }


        public static DataSet Readout(string query) //Read Data
        {
            DataSet dset = new DataSet();
            try
            {
                if (OpenConnection() == true)
                {
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                    da.Fill(dset);
                }
                CloseConnection();
            }
            catch
            {
                CloseConnection();
            }
            return dset;
        }
    }
}
