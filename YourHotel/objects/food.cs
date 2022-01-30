using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects
{
    public class food
    {
        public static DataSet Load(int category)
        {
            DataSet dset = new DataSet();

            string query = $"Select bezeichnung, preis From speisen Where kategorie = {category}";
            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
