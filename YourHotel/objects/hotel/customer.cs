using System.Data;

namespace YourHotel.objects.hotel
{
    public class customer
    {
        public int Nr { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Kind { get; set; }

        public static DataSet LoadAll()
        {
            DataSet dset = new DataSet();

            string query = "Select id, name from kunde";

            dset = db.dbconnection.Readout(query);

            return dset;
        }

        public customer Load()
        {
            DataSet ds = new DataSet();

            Nr = this.Nr;

            string query = $"Select name, email, telefon, adresse, kundenart From kunde where id = {Nr}";

            ds = db.dbconnection.Readout(query);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    Name = row.ItemArray[0].ToString();
                    Email = row.ItemArray[1].ToString();
                    Tel = row.ItemArray[2].ToString();
                    Address = row.ItemArray[3].ToString();
                    Kind = row.ItemArray[4].ToString();
                }
            }

            return this;
        }
    }
}
