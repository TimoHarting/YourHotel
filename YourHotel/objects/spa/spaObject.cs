using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects.spa
{
    public class spaObject
    {
        public static DataSet Load()
        {
            DataSet dset = new DataSet();

            string query = $"Select bezeichnung, preis From spa";
            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
