using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects.hotel
{
    public class room
    {
        public static DataSet LoadAll()
        {
            DataSet dset = new DataSet();

            string query = $"Select id From zimmer";
            dset = db.dbconnection.Readout(query);

            return dset;
        }

        public static DataSet LoadRoomCustomer(int roomId)
        {
            DataSet dset = new DataSet();

            string query = $"Select `K-ID` From buchung Where `Z-ID` = {roomId} and status = 'offen'";
            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
