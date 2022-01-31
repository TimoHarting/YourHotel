using System.Data;

namespace YourHotel.objects
{
    public class table
    {
        public static DataSet LoadAll()
        {
            DataSet dset = new DataSet();

            string query = $"Select * From tisch";
            dset = db.dbconnection.Readout(query);

            return dset;
        }
    }
}
