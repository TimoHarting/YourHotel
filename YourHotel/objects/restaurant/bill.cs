using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects.restaurant
{
    public class bill
    {
        public int customer { get; set; }
        public string state { get; set; }

        public int Save()
        {
            customer = this.customer;
            state = this.state;

            string query = $"Insert into rechnung(status) Values('{state}')";
            db.dbconnection.Basics(query);

            DataSet ds = new DataSet();
            int billId = 0;
            query = "Select id From letzte_rechnung_id";
            ds = db.dbconnection.Readout(query);

            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    billId = Convert.ToInt32(dr[dc].ToString());
                }
            }

            query = $"Insert into kunden_rechnung(`K-ID`, `R-ID`) Values({customer}, {billId})";
            db.dbconnection.Basics(query);

            return billId;
        }
    }
}
