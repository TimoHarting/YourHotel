using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects.tableObjects
{
    public class tableDetail
    {
        public string article { get; set; }
        public double price { get; set; }
        public string table { get; set; }

        public void Save()
        {
            article = this.article;
            price = this.price;
            table = this.table;

            string query = $"Insert Into tisch_details(Artikel, Preis, `T-ID`) Values('{article}', {price}, {table})";
            Console.WriteLine(query);
            db.dbconnection.Basics(query);
        }

        public static DataSet Load(int nr)
        {
            DataSet ds = new DataSet();
            string query = $"Select Artikel, Preis From tisch_details Where `T-ID` = {nr}";

            ds = db.dbconnection.Readout(query);

            return ds;
        }

        public void Delete()
        {
            table = this.table;

            string query = $"Delete * From tisch_details Where `T-ID` = {table}";

            db.dbconnection.Basics(query);
        }
    }
}
