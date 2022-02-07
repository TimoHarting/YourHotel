using System.Data;

namespace YourHotel.objects.hotel
{
    class reservedRoom
    {
        public static DataSet Load()
        {
            DataSet dset = new DataSet();

            string query = "Select * From gebuchte_zimmer";

            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
