using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using YourHotel.objects.hotel;

namespace YourHotel.forms
{
    public partial class reservationForm : Form
    {
        public reservationForm()
        {
            InitializeComponent();
            DateCorrection();
            LoadBroads();
        }

        private void DateCorrection()
        {
            starttime.MinDate = DateTime.Today;
            endtime.MinDate = DateTime.Today;
        }

        private void LoadBroads()
        {
            DataSet ds = broad.LoadAll();

            boardNr.Items.Clear();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    boardNr.Items.Add(row.ItemArray[1].ToString() + " " + row.ItemArray[2].ToString() + " €");
                }
            }
        }

        private void LoadCustomer()
        {
            DataSet ds = customer.LoadAll();

            customerNr.Items.Clear();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    customerNr.Items.Add(row.ItemArray[0].ToString() + " " + row.ItemArray[1].ToString());
                }
            }
        }

        private void newCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (oldCustomer.Checked == true)
            {
                LoadCustomer();
                customerNr.Enabled = true;
            }
            else if (newCustomer.Checked)
            {
                customerNr.Enabled = false;
            }
        }

        private void customerNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nr = Convert.ToInt16(customerNr.SelectedItem.ToString().Split(' ')[0]);

            customer c = new customer();
            c.Nr = nr;
            c = c.Load();

            firstname.Text = c.Name.Split(' ')[0];
            lastname.Text = c.Name.Split(' ')[1];
            email.Text = c.Email;
            tel.Text = c.Tel;
            address.Text = c.Address;
            privateBusiness.Text = c.Kind;
        }

        private void endtime_ValueChanged(object sender, EventArgs e)
        {
            LoadFreeRooms();
        }

        private void LoadFreeRooms()
        {
            DateTime startdate = starttime.Value;
            DateTime enddate = endtime.Value;

            Nightcalculation(enddate, startdate);

            DataSet ds = room.LoadRoomIDs();
            List<string> rooms = new List<string>();
 
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    rooms.Add(row.ItemArray[0].ToString());
                }
            }

            ds = reservedRoom.Load();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    var oldCheckout = Convert.ToDateTime(row.ItemArray[1]);
                    var oldCheckin = Convert.ToDateTime(row.ItemArray[0]);
                    var newCheckout = enddate;
                    var newCheckin = startdate;

                    int result1 = newCheckout.CompareTo(oldCheckout);
                    int result2 = newCheckin.CompareTo(oldCheckin);
                    int result3 = newCheckin.CompareTo(oldCheckout);
                    int result4 = newCheckout.CompareTo(oldCheckin);

                    int result = result1 + result2 + result3 + result4;

                    if (result < 4)
                    {
                        rooms.Remove(row.ItemArray[2].ToString());
                    }
                }
            }

            roomNr.Items.Clear();
            foreach (var s in rooms)
            {
                roomNr.Items.Add(s);
            }
        }

        private void Nightcalculation(DateTime enddate, DateTime startdate)
        {
            nightCount.Text = Convert.ToString((enddate.Date - startdate.Date).Days);
        }

        private void CalculatePrice()
        {
            int nights = Convert.ToInt32(nightCount.Text);
            double pricepernight = Convert.ToDouble(pricePerNight.Text);
            double boardprice = Convert.ToDouble(boardPrice.Text);

            double completeNightPrice = pricepernight + boardprice;

            completePricePerNight.Text = completeNightPrice.ToString();
            double stayPrice = nights * completeNightPrice;
            netPrice.Text = stayPrice.ToString();
            double mw = stayPrice * 0.19;

            double complete = stayPrice + mw;
            gross.Text = complete.ToString();
        }

        private void nightCount_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
    }
}
