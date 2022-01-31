using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.objects.restaurant
{
    public class billDetail
    {
        public string article { get; set; }
        public double price { get; set; }
        public int id { get; set; }

        public void Save()
        {
            article = this.article;
            price = this.price;
            id = this.id;

            string query = $"Insert into rechnung_details(`R-ID`, Artikel, Preis) Values({id}, '{article}', '{price}')";

            db.dbconnection.Basics(query);
        }
    }
}
