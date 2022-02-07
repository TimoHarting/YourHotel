using System.Data;

namespace YourHotel.objects.hotel
{
    class broad
    {
        public static DataSet LoadAll()
        {
            DataSet dset = new DataSet();

            string query = "Select * From verpflegung";

            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
