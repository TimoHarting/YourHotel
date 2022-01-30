using System;
using System.Data;

namespace YourHotel.controller
{
    public class logon
    {
        public static bool login (string uname, string pw)
        {
            try
            {
                DataSet dset = new DataSet();

                string query = $"Select id From mitarbeiter Where benutzername = '{uname}' and passwort = '{pw}'";

                dset = db.dbconnection.Readout(query);
                DataRow dr = dset.Tables[0].Rows[0];

                int id = Convert.ToInt32(dr[0].ToString());

                if (id != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
