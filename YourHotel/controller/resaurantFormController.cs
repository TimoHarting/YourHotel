using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel.controller
{
    public class resaurantFormController
    {
        public static DataSet selection(string category)
        {
            int id = 0;
            DataSet dset = new DataSet();
            dset = objects.foodCategory.LoadID(category);

            DataTable dt = dset.Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    id = Convert.ToInt32(dr[dc].ToString());
                }
            }

            dset = objects.food.Load(id);

            return dset;
        }
    }
}
