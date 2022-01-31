using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects
{
    public class foodCategory
    {
        public static DataSet LoadAll()
        {
            DataSet ds = new DataSet();
            string query = $"Select bezeichnung from speisenkategorie";

            ds = db.dbconnection.Readout(query);

            return ds;
        }

        public static DataSet LoadID(string category)
        {
            DataSet ds = new DataSet();
            string query = $"Select id from speisenkategorie where bezeichnung = '{category}'";

            ds = db.dbconnection.Readout(query);

            return ds;
        }
    }
}
