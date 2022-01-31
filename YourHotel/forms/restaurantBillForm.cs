using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourHotel.objects.hotel;
using YourHotel.objects.restaurant;
using YourHotel.objects.tableObjects;

namespace YourHotel.forms
{
    public partial class restaurantBillForm : Form
    {
        public restaurantBillForm()
        {
            InitializeComponent();
            LoadTable();
            LoadRooms();
        }

        private void LoadRooms()
        {
            DataSet ds = new DataSet();
            ds = objects.hotel.room.LoadAll();

            List<string> u = new List<string>();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    roomNr.Items.Add(row.ItemArray[0].ToString());
                }
            }
        }

        private void LoadTable()
        {
            DataSet ds = new DataSet();
            ds = objects.table.LoadAll();

            List<string> u = new List<string>();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    tableNr.Items.Add(row.ItemArray[0].ToString() + " " + row.ItemArray[1].ToString());
                }
            }
        }

        private void hotelguestCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(hotelguestCheck.Checked)
            {
                metroLabel7.Visible = true;
                roomNr.Visible = true;
            }
            else if(hotelguestCheck.Checked == false)
            {
                metroLabel7.Visible = false;
                roomNr.Visible = false;
            } 
        }

        private void tableNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookGrid.Rows.Clear();
            int nr = Convert.ToInt32(tableNr.Text.Split(' ')[0]);

            DataSet ds = new DataSet();
            ds = objects.tableObjects.tableDetail.Load(nr);

            List<string> u = new List<string>();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    bookGrid.Rows.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if(hotelguestCheck.Checked)
            {
                DataSet ds = new DataSet();
                int customerId = 0;
                int tableId = Convert.ToInt32(tableNr.Text.Split(' ')[0]);
                int roomId = Convert.ToInt32(roomNr.Text.ToString());
                ds = objects.hotel.room.LoadRoomCustomer(roomId);

                DataTable dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataColumn dc in dt.Columns)
                    {
                        customerId = Convert.ToInt32(dr[dc].ToString());
                    }
                }

                bill b = new bill();
                b.customer = customerId;
                b.state = "offen";
                int billId = b.Save();

                for (int i = 0; i < bookGrid.Rows.Count - 1; ++i)
                {
                    billDetail bd = new billDetail();
                    bd.article = bookGrid.Rows[i].Cells[0].Value.ToString();
                    bd.price = Convert.ToDouble(bookGrid.Rows[i].Cells[1].Value.ToString());
                    bd.id = billId;
                    bd.Save();
                }

                tableDetail td = new tableDetail();
                td.table = tableId.ToString();
                td.Delete();

                bookGrid.Rows.Clear();
            }
        }
    }
}
